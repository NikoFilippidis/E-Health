using System;
using System.Windows.Forms;

namespace eRezeptRCF{
	public partial class F_Login : Form{
			private String defTextUsename="Benutzernamen...";
			private String defTextPasswort="Passwort...";
		public F_Login(){
			InitializeComponent();
			textBox_username.Text=defTextUsename;
			textBox_password.Text=defTextPasswort;
			textBox_username.GotFocus+=new EventHandler(gfUsername);
			textBox_username.LostFocus+=new EventHandler(lfUsername);
			textBox_password.GotFocus+=new EventHandler(gfPassword);
			textBox_password.LostFocus+=new EventHandler(lfPassword);
		}

		void gfUsername(object sender, EventArgs e){
			if(textBox_username.Text.Equals(defTextUsename)){
				textBox_username.Text="";
			}
		}

		void lfUsername(object sender, EventArgs e){
			if(!SecurityHelper.ValueStringUsable(textBox_username.Text)){
				textBox_username.Text=defTextUsename;
			}
		}
		void gfPassword(object sender, EventArgs e){
			if(textBox_password.Text.Equals(defTextPasswort)){
				textBox_password.Text="";
				textBox_password.PasswordChar='*';
			}
		}

		void lfPassword(object sender, EventArgs e){
			if(!SecurityHelper.ValueStringUsable(textBox_password.Text)){
				textBox_password.Text=defTextPasswort;
				textBox_password.PasswordChar='\0';
			}
		}
			
		void B_loginClick(object sender, EventArgs e){
			try {
				if (textBox_username.Text.Equals(defTextUsename)) 
					textBox_username.Text = "";
				if (textBox_password.Text.Equals(defTextPasswort)) 
					textBox_password.Text = "";
				if ((!SecurityHelper.ValueStringUsable(textBox_username.Text)
				    || textBox_username.Text.Length < 4)
				    && (!SecurityHelper.ValueStringUsable(textBox_password.Text)
				    || textBox_password.Text.Length < 4))
					throw new Exception("Bitte Login-Daten angeben oder den Offline Modus wählen...");
				if (!SecurityHelper.ValueStringUsable(textBox_username.Text)
				    || textBox_username.Text.Length < 4)
					throw new Exception("Bitte einen gültigen Benutzernamen eingeben...");
				if (!SecurityHelper.ValueStringUsable(textBox_password.Text)
				    || textBox_password.Text.Length < 4)
					throw new Exception("Bitte einen gültigens Passwort eingeben...");
				SSLHandler.login(textBox_username.Text, textBox_password.Text);
				if (!LocalDoctor.allSet)
					throw new Exception("Irgendwas ist fehlgeschlagen...");
				this.Visible = false;
				F_Workbench w = new F_Workbench();
				w.ShowDialog();
				if (w.isLogut) {
					this.Visible = true;
				} else {
					this.Close();	
				}
			} catch (Exception err) {
				showError(err.Message);
				if (!SecurityHelper.ValueStringUsable(textBox_username.Text)) 
					textBox_username.Text = defTextUsename;
				if (!SecurityHelper.ValueStringUsable(textBox_password.Text)) 
					textBox_password.Text = defTextPasswort;
			}
		}
			
		void B_offlineClick(object sender, EventArgs e){
				this.Visible=false;
				F_WorkbenchOffline fw=new F_WorkbenchOffline();
				fw.ShowDialog();
				if(fw.isLogut){
					this.Visible=true;
				}else{
					this.Close();
				}
		}
			
		private void showError(String msg){
			label_error.Text=msg;
		}
	}
}
