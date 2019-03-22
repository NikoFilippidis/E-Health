using System;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;

namespace eRezeptRCF{
	public static class SSLHandler{
		public static void checkERezept(ERezept er){
			String e=er.getExportFormat();
			String []lines=e.Split('#');
			TcpClient client = new TcpClient(Settings.Default.server_ip,Settings.Default.server_port);
			SslStream sslStream = new SslStream(client.GetStream(),  false, new RemoteCertificateValidationCallback (SecurityHelper.ValidateServerCertificate),  null );
			sslStream.AuthenticateAsClient("eRezeptCA");
			ASCIIEncoding asen=new ASCIIEncoding();
			String str="check:"+lines[0]+"<EOF>";
			sslStream.Write(asen.GetBytes(str));
			String erg = ReadMessage(sslStream);
			erg=erg.Replace("<EOF>","");
	            	if(erg.Equals("errornotfound"))
	            		throw new Exception("eRezept not from a doctor!");
	            	if(!SecurityHelper.RSAValidateSignature(
								lines[0]+
								lines[1]+
								lines[2]+
								lines[3]+
								lines[4]+
								lines[5]+
								lines[6]+
								lines[7],lines[8],erg))
			    		throw new Exception("eRezept was manipulate!");
		}
		private static String ReadMessage(SslStream sslStream) {
            byte [] buffer = new byte[2048];
            StringBuilder messageData = new StringBuilder();
            int bytes = -1;
            do{
                bytes = sslStream.Read(buffer, 0, buffer.Length);
                Decoder decoder = Encoding.UTF8.GetDecoder();
                char[] chars = new char[decoder.GetCharCount(buffer,0,bytes)];
                decoder.GetChars(buffer, 0, bytes, chars,0);
                messageData.Append (chars);
                // disable once StringIndexOfIsCultureSpecific
                if (messageData.ToString().IndexOf("<EOF>") != -1){
                    break;
                }
            } while (bytes != 0); 
            return messageData.ToString();
        }
	}
}
