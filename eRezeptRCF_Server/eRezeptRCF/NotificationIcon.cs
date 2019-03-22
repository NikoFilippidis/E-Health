/*
 * Created by SharpDevelop.
 * User: steve
 * Date: 22.03.2016
 * Time: 10:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace eRezeptRCF{
	public sealed class NotificationIcon{
		private NotifyIcon notifyIcon;
		private ContextMenu notificationMenu;
		private Thread s;
		private F_AddP fAddP;
		private List<Person> persons;
		private Boolean run;
		
		#region Initialize icon and menu
		public NotificationIcon(){
			notifyIcon = new NotifyIcon();
			notificationMenu = new ContextMenu(InitializeMenu());
			
			notifyIcon.DoubleClick += IconDoubleClick;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationIcon));
			notifyIcon.Icon = (Icon)resources.GetObject("$this.Icon");
			notifyIcon.ContextMenu = notificationMenu;
			init();
			
		}
		
		private void init(){
			run=true;
			SecurityHelper.IDinit();
			persons=new List<Person>();
			s=new Thread(new ThreadStart(sslServer));
			s.Start();
		}
		
		private MenuItem[] InitializeMenu(){
			MenuItem[] menu = new MenuItem[] {
				//new MenuItem("Show all Persons", menuShowPClick),
				//new MenuItem("-"),
				//new MenuItem("Edit Person", menuEditPClick),
				//new MenuItem("Delete Person", menuDeletePClick),
				new MenuItem("Add Person", menuAddPClick),
				new MenuItem("-"),
				new MenuItem("Exit", menuExitClick)
			};
			return menu;
		}
		#endregion
		
		#region Main - Program entry point
		[STAThread]
		public static void Main(string[] args){
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			bool isFirstInstance;
			using (Mutex mtx = new Mutex(true, "eRezeptRCF", out isFirstInstance)) {
				if (isFirstInstance) {
					NotificationIcon notificationIcon = new NotificationIcon();
					notificationIcon.notifyIcon.Visible = true;
					Application.Run();
					notificationIcon.notifyIcon.Dispose();
				} else {
					MessageBox.Show("Server is already running!", "Attention", 
   	 						MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			} // releases the Mutex
		}
		#endregion
		
		#region Event Handlers		
		private void menuExitClick(object sender, EventArgs e){
			run=false;
			try{
				Thread.Sleep(1000);
				s.Abort();
				Thread.Sleep(1000);
				s=null;
			}catch{}
			Application.Exit();
		}
		
		private void menuShowPClick(object sender, EventArgs e){

		}
		private void menuEditPClick(object sender, EventArgs e){
			
		}
		private void menuDeletePClick(object sender, EventArgs e){
			
		}
		private void menuAddPClick(object sender, EventArgs e){
			try{
				if(fAddP==null||!fAddP.Visible){
					fAddP=new F_AddP(persons);
					fAddP.ShowDialog();
				}				
			// disable once EmptyGeneralCatchClause
			}catch{}
		}
		private void IconDoubleClick(object sender, EventArgs e){
			
		}
		#endregion
		private X509Certificate serverCertificate;
        public  void sslServer() {
			serverCertificate=SecurityHelper.GenerateCertificate("127.0.0.1","127.0.0.1","127.0.0.1");
			TcpListener listener = new TcpListener(IPAddress.Any, 443);    
            listener.Start();
            while (run) {
            	try{
	                TcpClient client = listener.AcceptTcpClient();
	                ProcessClient(client);
            	// disable once EmptyGeneralCatchClause
            	}catch{}
            }
        }
        private void ProcessClient (TcpClient client){
            SslStream sslStream = new SslStream(
                client.GetStream(), false);
            try  {
                sslStream.AuthenticateAsServer(serverCertificate, 
                    false, SslProtocols.Tls, true);
                sslStream.ReadTimeout = 5000;
                sslStream.WriteTimeout = 5000;  
                String messageData = ReadMessage(sslStream);
                messageData=messageData.Replace("<EOF>","");
                if(messageData.Contains("login:")){
	        			messageData=messageData.Replace("login:","");
	        			String []info=messageData.Split('#');
	        			ASCIIEncoding asen=new ASCIIEncoding();
	        			String response="errornotfound";
	        			foreach(Person p in persons){
	        				if(p.username.Equals(info[0])){
	        					if(info[1].Equals(p.password)){
	        						response=p.getResponseText();
	        					}
	        				}
	        			}	
	        			sslStream.Write(asen.GetBytes(response+"<EOF>"));        					
	        		}else if(messageData.Contains("check:")){
	        			messageData=messageData.Replace("check:","");
	        			ASCIIEncoding asen=new ASCIIEncoding();
	        			Boolean found=false;
	        			foreach(Person p in persons){
	        				if(p.id==Convert.ToInt32(messageData)){
	        					sslStream.Write(asen.GetBytes(p.puKey+"<EOF>"));
	        					found=true;
	        				}
	        			}
	        			if(!found)
	        				sslStream.Write(asen.GetBytes("errornotfound<EOF>"));
	        		}               
                client.Close();
            }
            catch {
                sslStream.Close();
                client.Close();
                return;
            }
            finally {
                sslStream.Close();
                client.Close();
            }
        }
        private string ReadMessage(SslStream sslStream){
			try{
	            byte [] buffer = new byte[2048];
	            StringBuilder messageData = new StringBuilder();
	            int bytes = -1;
	            do{
	                bytes = sslStream.Read(buffer, 0, buffer.Length);
	                Decoder decoder = Encoding.UTF8.GetDecoder();
	                char[] chars = new char[decoder.GetCharCount(buffer,0,bytes)];
	                decoder.GetChars(buffer, 0, bytes, chars,0);
	                messageData.Append (chars);
	                if (messageData.ToString().IndexOf("<EOF>") != -1) {
	                    break;
	                }
	            } while (bytes !=0); 
	            return messageData.ToString();
			}catch(Exception err){
				return "";
			}
        }
	}
}
