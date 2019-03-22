using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eRezeptRCF{
	public partial class F_Workbench : Form{
		private List<ERezept> eRezepte;
		public F_Workbench(){
			InitializeComponent();
			eRezepte=new List<ERezept>();
			this.Shown+=shown;
		}
		
		void Button_quittierenClick(object sender, EventArgs e){
			try{
				String selected = listBox_rezept.GetItemText(listBox_rezept.SelectedItem);
				ERezept puffer=null;
				foreach(ERezept er in eRezepte)
					if(er.getListFormat().Equals(selected))
						puffer=er;
				if(puffer==null)
					throw new Exception("Bitte wählen Sie ein Rezept aus!");
				F_Quittierung f = new F_Quittierung(puffer);
				f.ShowDialog();
				drawList();
			}catch(Exception err){
				MessageBox.Show(err.Message,
					"Quittierung Fehler!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning,
					MessageBoxDefaultButton.Button1);
			}
		}

		private void shown(object sender, EventArgs e){
			drawList();
		}

		private void drawList(){
			panel1.Visible=false;
			listBox_rezept.Items.Clear();
			eRezepte.Clear();
			foreach(ERezept er in eRezept_API.getAllRezept()){
				eRezepte.Add(er);
			}
			foreach(ERezept er in eRezepte){
				listBox_rezept.Items.Add(er.getListFormat());
			}
		}
		
		private void ListBox_rezeptSelectedIndexChanged(object sender, EventArgs e){
			panel1.Visible=true;
			getSelectedRezeptAndSetView();
		}
		
		private void getSelectedRezeptAndSetView(){
			String selected = listBox_rezept.GetItemText(listBox_rezept.SelectedItem);
			foreach(ERezept e in eRezepte){
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
	}
}
