using System;

namespace eRezeptRCF{
	public class ERezept{
		public Boolean gebuehrenfrei;
		public Boolean gebuehrenpflichtig;
		public Boolean noctu;
		public Boolean sonstige;
		public Boolean autIdem;
		public Boolean O1;
		public Boolean O2;
		public Boolean O3;
		public Boolean O4;
		public String rezeptNR;
		public String signatur;
		public String kKostentraeger;
		public String nVVVersicherter;
		public String kassenNr;
		public String versichertenNr;
		public String status;
		public String betriebsstaettenNr;
		public String arztNr;
		public String BVG;
		public String apothekenNr;
		public String zuzahlung;
		public String gesamtBrutto;
		public String pharamazentralnummer_1;
		public String pharamazentralnummer_2;
		public String pharamazentralnummer_3;
		public String faktor_1;
		public String faktor_2;
		public String faktor_3;
		public String taxe_1;
		public String taxe_2;
		public String taxe_3;
		public DateTime datum;
		public DateTime date_from;
		public DateTime date_to;
		public ERezept(Boolean gebuehrenfrei, Boolean gebuehrenpflichtig, Boolean noctu, Boolean sonstige, Boolean autIdem, 
		               Boolean O1, Boolean O2, Boolean O3, Boolean O4, String rezeptNR, 
		               String signatur, String kKostentraeger, String nVVVersicherter, String kassenNr, String versichertenNr, 
		               String status, String betriebsstaettenNr, String arztNr, String BVG, String apothekenNr, 
		               String zuzahlung, String gesamtBrutto, String pharamazentralnummer_1, String pharamazentralnummer_2, String pharamazentralnummer_3, 
		               String faktor_1, String faktor_2, String faktor_3, String taxe_1, String taxe_2, 
		               String taxe_3, DateTime datum, DateTime datum_from, DateTime datum_to){
			this.gebuehrenfrei=gebuehrenfrei;
			this.gebuehrenpflichtig=gebuehrenpflichtig;
			this.noctu=noctu;
			this.sonstige=sonstige;
			this.autIdem=autIdem;
			this.O1=O1;
			this.O2=O2;
			this.O3=O3;
			this.O4=O4;
			this.rezeptNR=rezeptNR;
			this.signatur=signatur;
			this.kKostentraeger=kKostentraeger;
			this.nVVVersicherter=nVVVersicherter;
			this.kassenNr=kassenNr;
			this.versichertenNr=versichertenNr;
			this.status=status;
			this.betriebsstaettenNr=betriebsstaettenNr;
			this.arztNr=arztNr;
			this.BVG=BVG;
			this.apothekenNr=apothekenNr;
			this.zuzahlung=zuzahlung;
			this.gesamtBrutto=gesamtBrutto;
			this.pharamazentralnummer_1=pharamazentralnummer_1;
			this.pharamazentralnummer_2=pharamazentralnummer_2;
			this.pharamazentralnummer_3=pharamazentralnummer_3;
			this.faktor_1=faktor_1;
			this.faktor_2=faktor_2;
			this.faktor_3=faktor_3;
			this.taxe_1=taxe_1;
			this.taxe_2=taxe_2;
			this.taxe_3=taxe_3;
			this.datum=datum;
			this.date_from=datum_from;
			this.date_to=datum_to;
		}
		public String getListFormat(){
			return rezeptNR+": "+datum;
		}
		
		public String getExportFormat(){
			String puffer= gebuehrenfrei+"<LB>"
					+gebuehrenpflichtig+"<LB>"
					+noctu+"<LB>"
					+sonstige+"<LB>"
					+autIdem+"<LB>"
					+O1+"<LB>"
					+O2+"<LB>"
					+O3+"<LB>"
					+O4+"<LB>"
					+rezeptNR+"<LB>"
					+signatur+"<LB>"
					+kKostentraeger+"<LB>"
					+nVVVersicherter+"<LB>"
					+kassenNr+"<LB>"
					+versichertenNr+"<LB>"
					+status+"<LB>"
					+betriebsstaettenNr+"<LB>"
					+arztNr+"<LB>"
					+BVG+"<LB>"
					+apothekenNr+"<LB>"
					+zuzahlung+"<LB>"
					+gesamtBrutto+"<LB>"
					+pharamazentralnummer_1+"<LB>"
					+pharamazentralnummer_2+"<LB>"
					+pharamazentralnummer_3+"<LB>"
					+faktor_1+"<LB>"
					+faktor_2+"<LB>"
					+faktor_3+"<LB>"
					+taxe_1+"<LB>"
					+taxe_2+"<LB>"
					+taxe_3+"<LB>"
					+datum+"<LB>"
					+date_from+"<LB>"
					+date_to+"<LB>";
			puffer=puffer.Replace(System.Environment.NewLine, "<NEWLINE>");
			return puffer;
		}
	}
}
