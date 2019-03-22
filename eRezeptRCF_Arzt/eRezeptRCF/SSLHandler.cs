using System;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;

namespace eRezeptRCF{
	public static class SSLHandler{
		public static void login(String username, String password){
			password=SecurityHelper.MD5HashText(password);
			TcpClient client = new TcpClient(Settings.Default.server_ip,Settings.Default.server_port);
			SslStream sslStream = new SslStream(client.GetStream(),  false, new RemoteCertificateValidationCallback (SecurityHelper.ValidateServerCertificate),  null );
			sslStream.AuthenticateAsClient("eRezeptCA");
			ASCIIEncoding asen=new ASCIIEncoding();
			String str="login:"+username+"#"+password+"<EOF>";
			sslStream.Write(asen.GetBytes(str));
			String erg = ReadMessage(sslStream);
			if(!SecurityHelper.ValueStringUsable(erg))
				throw new Exception("Keine Antwort vom Server...");
			erg = erg.Replace("<EOF>", "");
			client.Close();
			if (erg.Equals("errornotfound") || !SecurityHelper.ValueStringUsable(erg))
				throw new Exception("Falscher Benutzername oder Passwort!");
			String[] data = erg.Split('#');
			if (!SecurityHelper.ValueStringUsable(data[0]))
				throw new Exception("Receiving error!");
			if (!SecurityHelper.ValueStringUsable(data[1]))
				throw new Exception("Receiving error!");
			if (!SecurityHelper.ValueStringUsable(data[2]))
				throw new Exception("Receiving error!");
			if (!SecurityHelper.ValueStringUsable(data[3]))
				throw new Exception("Receiving error!");
			if (!SecurityHelper.ValueStringUsable(data[4]))
				throw new Exception("Receiving error!");
			if (!SecurityHelper.ValueStringUsable(data[5]))
				throw new Exception("Receiving error!");
			if (!SecurityHelper.ValueStringUsable(data[6]))
				throw new Exception("Receiving error!");
			if (!SecurityHelper.ValueStringUsable(data[7]))
				throw new Exception("Receiving error!");
			if (!SecurityHelper.ValueStringUsable(data[8]))
				throw new Exception("Receiving error!");
			int id = Convert.ToInt32(data[0]);
			String hospital = data[1];
			String name = data[2];
			String state = data[3];
			String cityAndCode = data[4];
			String street = data[5];
			String phone = data[6];		
			String prKey = data[7];
			String puKey = data[8];
			LocalDoctor.setValues(id,hospital,name,state,cityAndCode,street,phone,prKey,puKey);
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
