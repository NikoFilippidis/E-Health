using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eRezeptRCF{
	public partial class F_Workbench : Form{
		private List<ERezept> eR;
		public Boolean isLogut;		
		public F_Workbench(){
			InitializeComponent();
			isLogut=false;
			this.Shown+=shown;
		}

		void shown(object sender, EventArgs e){
			this.Text="eRezept Online-Modus ("+LocalDoctor.name+")";
			eR=new List<ERezept>();
			eR=eRezept_API.getAllRezeptFromDoc(LocalDoctor.id);
			List<ERezept> eRTMP=eRezept_API.getAllRezeptFromDoc(LocalDoctor.id);
			if(eRTMP!=null)
			   eR=eRTMP;
			button_save.Visible=false;
			panel1.Visible=false;
			updateList();
		}
		
		void ToolStripButton_GoOutClick(object sender, EventArgs e){
			isLogut=true;
			this.Close();
		}
		void ToolStripButton_newClick(object sender, EventArgs e){
			errorInfo.Visible=false;
			panel1.Visible=true;
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
			
			button_save.Visible=true;
		}
		void ToolStripButton_deleteClick(object sender, EventArgs e){
			errorInfo.Visible=false;
			try{
				eRezept_API.deleteERezept(getSelectedRezept());
				eR.Remove(getSelectedRezept());
				updateList();
				panel1.Visible=false;
			}catch(Exception err){
				showError(err.Message);
			}
		}

		private void getSelectedRezeptAndSetView(){
			String selected = listBox_eRezepte.GetItemText(listBox_eRezepte.SelectedItem);
			foreach(ERezept e in eR){
				if(e.getListFormat().Equals(selected)){
					checkBox_gebuehrenfrei.Checked=e.gebuehrenfrei;
					checkBox_gebuehrenpflichtig.Checked=e.gebuehrenpflichtig;
					checkBox_noctu.Checked=e.noctu;
					checkBox_sonstige.Checked=e.sonstige;
					checkBox_AutIdem.Checked=e.autIdem;
					checkBox_O1.Checked=e.O1;
					checkBox_O2.Checked=e.O2;
					checkBox_O3.Checked=e.O3;
					checkBox_O4.Checked=e.O4;
					textBox_T_RezeptNR.Text=e.rezeptNR;
					textBox_signatur.Text=e.signatur;
					textBox_KKostentraeger.Text=e.kKostentraeger;
					textBox_NVVVersicherter.Text=e.nVVVersicherter;
					textBox3_KassenNr.Text=e.kassenNr;
					textBox_VersichertenNr.Text=e.versichertenNr;
					textBox_Status.Text=e.status;
					textBox_BetriebsstaettenNr.Text=e.betriebsstaettenNr;
					textBox_ArztNr.Text=e.arztNr;
					textBox_BVG.Text=e.BVG;
					textBox_ApothekenNr.Text=e.apothekenNr;
					textBox_Zuzahlung.Text=e.zuzahlung;
					textBox_GesamtBrutto.Text=e.gesamtBrutto;
					textBox_1_Pharamazentralnummer.Text=e.pharamazentralnummer_1;
					textBox_2_Pharamazentralnummer.Text=e.pharamazentralnummer_2;
					textBox_3_Pharamazentralnummer.Text=e.pharamazentralnummer_3;
					textBox_1_Faktor.Text=e.faktor_1;
					textBox_2_Faktor.Text=e.faktor_2;
					textBox_3_Faktor.Text=e.faktor_3;
					textBox_1_Taxe.Text=e.taxe_1;
					textBox_2_Taxe.Text=e.taxe_2;
					textBox_3_Taxe.Text=e.taxe_3;
					datum.Value=e.datum;
					date_from.Value=e.date_from;
					date_to.Value=e.date_to;
				}
			}
		}
		
		private ERezept getSelectedRezept(){
			String selected = listBox_eRezepte.GetItemText(listBox_eRezepte.SelectedItem);
			foreach(ERezept e in eR){
				if(e.getListFormat().Equals(selected)){
					return e;
				}
			}
			return null;
		}
		
		private void updateList(){
			listBox_eRezepte.Items.Clear();
			foreach(ERezept e in eR){
				listBox_eRezepte.Items.Add(e.getListFormat());
			}
		}
		
		void ListBox_eRezepteSelectedIndexChanged(object sender, EventArgs e){
			errorInfo.Visible=false;
			panel1.Visible=true;
			button_save.Visible=false;
			getSelectedRezeptAndSetView();
		}
		
		void Button_saveClick(object sender, EventArgs e){
			errorInfo.Visible=false;
			//Prüfen ob alles ok
			try{
				ERezept ee= new ERezept(
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
				);
				eRezept_API.saveERezeptLocal(ee);
				eRezept_API.saveERezeptOnCard(ee);
				eR.Add(ee);
				updateList();
				button_save.Visible=false;
			}catch(Exception err){
				showError(err.Message);
			}
		}
		
		private void showError(String msg){
			errorInfo.Visible=true;
			errorInfo.Text=msg;
		}
		
		
	}
}
