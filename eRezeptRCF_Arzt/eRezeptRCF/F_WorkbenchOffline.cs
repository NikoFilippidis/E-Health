using System;
using System.Windows.Forms;

namespace eRezeptRCF{
	public partial class F_WorkbenchOffline : Form{
		public  Boolean isLogut;
		public F_WorkbenchOffline(){
			InitializeComponent();
			isLogut=false;
			datum.Value = DateTime.Now;
			date_from.Value = DateTime.Now;
			date_to.Value = DateTime.Now.AddDays(14);
		}
		
		void ToolStripButton_GoOutClick(object sender, EventArgs e){
			isLogut=true;
			this.Close();
		}
		
		void ToolStripButton_NewClick(object sender, EventArgs e){
			errorInfo.Visible=false;
			checkBox_gebuehrenfrei.Checked = false;
			checkBox_gebuehrenpflichtig.Checked = false;
			checkBox_noctu.Checked = false;
			checkBox_sonstige.Checked = false;
			checkBox_AutIdem.Checked = false;
			checkBox_O1.Checked = false;
			checkBox_O2.Checked = false;
			checkBox_O3.Checked = false;
			checkBox_O4.Checked = false;
			textBox_T_RezeptNR.Text = "";
			textBox_signatur.Text = "";
			textBox_KKostentraeger.Text = "";
			textBox_NVVVersicherter.Text = "";
			textBox3_KassenNr.Text = "";
			textBox_VersichertenNr.Text = "";
			textBox_Status.Text = "";
			textBox_BetriebsstaettenNr.Text = "";
			textBox_ArztNr.Text = "";
			textBox_BVG.Text = "";
			textBox_ApothekenNr.Text = "";
			textBox_Zuzahlung.Text = "";
			textBox_GesamtBrutto.Text = "";
			textBox_1_Pharamazentralnummer.Text = "";
			textBox_2_Pharamazentralnummer.Text = "";
			textBox_3_Pharamazentralnummer.Text = "";
			textBox_1_Faktor.Text = "";
			textBox_2_Faktor.Text = "";
			textBox_3_Faktor.Text = "";
			textBox_1_Taxe.Text = "";
			textBox_2_Taxe.Text = "";
			textBox_3_Taxe.Text = "";
			datum.Value = DateTime.Now;
			date_from.Value = DateTime.Now;
			date_to.Value = DateTime.Now.AddDays(14);
		}
		
		void ToolStripButton_SpeichernClick(object sender, EventArgs e){
			try{
				errorInfo.Visible=false;
				eRezept_API.saveERezeptLocal(new ERezept(
					checkBox_gebuehrenfrei.Checked,
					checkBox_gebuehrenpflichtig.Checked,
					checkBox_noctu.Checked,
					checkBox_sonstige.Checked,
					checkBox_AutIdem.Checked,
					checkBox_O1.Checked,
					checkBox_O2.Checked,
					checkBox_O3.Checked,
					checkBox_O4.Checked,
					textBox_T_RezeptNR.Text,
					textBox_signatur.Text,
					textBox_KKostentraeger.Text,
					textBox_NVVVersicherter.Text,
					textBox3_KassenNr.Text,
					textBox_VersichertenNr.Text,
					textBox_Status.Text,
					textBox_BetriebsstaettenNr.Text,
					textBox_ArztNr.Text,
					textBox_BVG.Text,
					textBox_ApothekenNr.Text,
					textBox_Zuzahlung.Text,
					textBox_GesamtBrutto.Text,
					textBox_1_Pharamazentralnummer.Text,
					textBox_2_Pharamazentralnummer.Text,
					textBox_3_Pharamazentralnummer.Text,
					textBox_1_Faktor.Text,
					textBox_2_Faktor.Text,
					textBox_3_Faktor.Text,
					textBox_1_Taxe.Text,
					textBox_2_Taxe.Text,
					textBox_3_Taxe.Text,
					datum.Value,
					date_from.Value,
					date_to.Value
				));
			}catch(Exception err){
				showError(err.Message);
			}
		}
		
		void ToolStripButton_DruckenClick(object sender, EventArgs e){
			try{
				errorInfo.Visible=false;
				eRezept_API.printERezept(new ERezept(
					checkBox_gebuehrenfrei.Checked,
					checkBox_gebuehrenpflichtig.Checked,
					checkBox_noctu.Checked,
					checkBox_sonstige.Checked,
					checkBox_AutIdem.Checked,
					checkBox_O1.Checked,
					checkBox_O2.Checked,
					checkBox_O3.Checked,
					checkBox_O4.Checked,
					textBox_T_RezeptNR.Text,
					textBox_signatur.Text,
					textBox_KKostentraeger.Text,
					textBox_NVVVersicherter.Text,
					textBox3_KassenNr.Text,
					textBox_VersichertenNr.Text,
					textBox_Status.Text,
					textBox_BetriebsstaettenNr.Text,
					textBox_ArztNr.Text,
					textBox_BVG.Text,
					textBox_ApothekenNr.Text,
					textBox_Zuzahlung.Text,
					textBox_GesamtBrutto.Text,
					textBox_1_Pharamazentralnummer.Text,
					textBox_2_Pharamazentralnummer.Text,
					textBox_3_Pharamazentralnummer.Text,
					textBox_1_Faktor.Text,
					textBox_2_Faktor.Text,
					textBox_3_Faktor.Text,
					textBox_1_Taxe.Text,
					textBox_2_Taxe.Text,
					textBox_3_Taxe.Text,
					datum.Value,
					date_from.Value,
					date_to.Value
				));
			}catch(Exception err){
				showError(err.Message);
			}
		}
		
		private void showError(String msg){
			errorInfo.Visible=true;
			errorInfo.Text=msg;
		}
		void TextBox_signaturTextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
