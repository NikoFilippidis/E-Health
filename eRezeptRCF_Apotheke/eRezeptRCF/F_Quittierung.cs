using System;
using System.Windows.Forms;

namespace eRezeptRCF{
	public partial class F_Quittierung : Form{
		private ERezept eRezept;
		private Boolean saved;
		private Boolean printed;
		public F_Quittierung(ERezept eRezept){
			InitializeComponent();
			printed=false;
			saved=false;
			this.eRezept=eRezept;
			this.Text=eRezept.getListFormat();
		}
		
		void Button_zuruekClick(object sender, EventArgs e){
			this.Close(); 
		}
		void Button_druckenClick(object sender, EventArgs e){
			printed=true;
			eRezept_API.printERezept(eRezept);
		}
		void Button_speichernClick(object sender, EventArgs e){
			saved=true;
			eRezept_API.saveERezeptLocal(eRezept);
		}
		void Button_quittierenClick(object sender, EventArgs e){
			String b0="";
			String b1="";
			String b2="";
			if(!saved||!printed)
				b0="Achtung: \n";
			if(!saved)
				b1="Das Rezept wurde nicht gespeichert!";
			if(!printed)
				b2="Das Rezept wurde nicht gedruckt! ";
			
			DialogResult dr = MessageBox.Show("Das eRezept Quittieren?"+"\n"+b0+b1+"\n"+b2, 
                      "Quittieren?", MessageBoxButtons.YesNo);
			switch(dr){
			   case DialogResult.Yes: 
					eRezept_API.deleteERezept(eRezept);
					this.Close();
					break;
			   case DialogResult.No: 
					break;
			}
		}
	}
}
