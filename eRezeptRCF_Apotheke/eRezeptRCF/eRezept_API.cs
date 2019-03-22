using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using eRezeptRCF;

namespace eRezeptRCF{
	public static class eRezept_API{
		private static ERezept printRezeptTmp;
		public static void saveERezeptLocal(ERezept er){ 
			float margin = Utilities.MillimetersToPoints(Convert.ToSingle(20));
			Document doc = new Document(iTextSharp.text.PageSize.A4, margin, margin, margin, margin);
			if(!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)+"\\Kopie"))
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)+"\\Kopie");
			String path= Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)+"\\Kopie"+"\\"+er.datum.ToString("yyyy-MM-dd")+"-"+er.versichertenNr+".pdf";
			PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
			writer.SetFullCompression();
			writer.CloseStream = true;			 
			doc.Open();
			doc.Add(new Paragraph("eRezept"));
			doc.Add(new Paragraph("Gebuehrenfrei:"+er.gebuehrenfrei));
			doc.Add(new Paragraph("noctu:"+er.noctu));
			doc.Add(new Paragraph("sonstige:"+er.sonstige));
			doc.Add(new Paragraph("autIdem:"+er.autIdem));
			doc.Add(new Paragraph("O1:"+er.O1));
			doc.Add(new Paragraph("O2:"+er.O2));
			doc.Add(new Paragraph("O3:"+er.O3));
			doc.Add(new Paragraph("O4:"+er.O4));
			doc.Add(new Paragraph("rezeptNR:"+er.rezeptNR));
			doc.Add(new Paragraph("signatur:"+er.signatur));
			doc.Add(new Paragraph("kKostentraeger:"+er.kKostentraeger));
			doc.Add(new Paragraph("nVVVersicherter:"+er.nVVVersicherter));
			doc.Add(new Paragraph("kassenNr:"+er.kassenNr));
			doc.Add(new Paragraph("status:"+er.status));
			doc.Add(new Paragraph("betriebsstaettenNr:"+er.betriebsstaettenNr));
			doc.Add(new Paragraph("arztNr:"+er.arztNr));
			doc.Add(new Paragraph("versichertenNr:"+er.versichertenNr));
			doc.Add(new Paragraph("BVG:"+er.BVG));
			doc.Add(new Paragraph("apothekenNr:"+er.apothekenNr));
			doc.Add(new Paragraph("zuzahlung:"+er.zuzahlung));
			doc.Add(new Paragraph("gesamtBrutto:"+er.gesamtBrutto));
			doc.Add(new Paragraph("pharamazentralnummer_1:"+er.pharamazentralnummer_1));
			doc.Add(new Paragraph("pharamazentralnummer_2:"+er.pharamazentralnummer_2));
			doc.Add(new Paragraph("pharamazentralnummer_3:"+er.pharamazentralnummer_3));
			doc.Add(new Paragraph("faktor_1:"+er.faktor_1));
			doc.Add(new Paragraph("faktor_2:"+er.faktor_2));
			doc.Add(new Paragraph("faktor_3:"+er.faktor_3));
			doc.Add(new Paragraph("taxe_1:"+er.taxe_1));
			doc.Add(new Paragraph("taxe_2:"+er.taxe_2));
			doc.Add(new Paragraph("taxe_3:"+er.taxe_3));
			doc.Add(new Paragraph("datum:"+er.datum));
			doc.Add(new Paragraph("date_from:"+er.date_from));
			doc.Add(new Paragraph("date_to:"+er.date_to));
			doc.Close();
			MessageBox.Show("Speicherung abgeschlossen!",
				    "Erfolgreich", 
				    MessageBoxButtons.OK, 
				    MessageBoxIcon.Information
				   );
		}
		
		public static void printERezept(ERezept er){
			printRezeptTmp=er;
			PrintDocument pd = new PrintDocument();
			pd.DefaultPageSettings.PaperSize=new PaperSize("A4",827,1170);
			pd.PrintPage+= new PrintPageEventHandler(print);
			pd.Print();
		}
		private static void print(object sender, PrintPageEventArgs e){
			e.Graphics.DrawString("eRezept",new System.Drawing.Font("Times New Roman",14,FontStyle.Bold),Brushes.Black, 20, 100);
			e.Graphics.DrawString("gebuehrenfrei:"+printRezeptTmp.gebuehrenfrei,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);
			e.Graphics.DrawString("noctu:"+printRezeptTmp.noctu,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);
			e.Graphics.DrawString("sonstige:"+printRezeptTmp.sonstige,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);
			e.Graphics.DrawString("autIdem:"+printRezeptTmp.autIdem,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);
			e.Graphics.DrawString("O1:"+printRezeptTmp.O1,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);
			e.Graphics.DrawString("O2:"+printRezeptTmp.O2,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);
			e.Graphics.DrawString("O3:"+printRezeptTmp.O3,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);
			e.Graphics.DrawString("O4:"+printRezeptTmp.O4,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);
			e.Graphics.DrawString("rezeptNR:"+printRezeptTmp.rezeptNR,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);
			e.Graphics.DrawString("signatur:"+printRezeptTmp.signatur,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);
			e.Graphics.DrawString("kKostentraeger:"+printRezeptTmp.kKostentraeger,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);
			e.Graphics.DrawString("nVVVersicherter:"+printRezeptTmp.nVVVersicherter,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);
			e.Graphics.DrawString("kassenNr:"+printRezeptTmp.kassenNr,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);
			e.Graphics.DrawString("status:"+printRezeptTmp.status,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);		
			e.Graphics.DrawString("betriebsstaettenNr:"+printRezeptTmp.betriebsstaettenNr,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);		
			e.Graphics.DrawString("arztNr:"+printRezeptTmp.arztNr,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);		
			e.Graphics.DrawString("versichertenNr:",new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);		
			e.Graphics.DrawString("BVG:"+printRezeptTmp.BVG,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);				
			e.Graphics.DrawString("apothekenNr:"+printRezeptTmp.apothekenNr,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);				
			e.Graphics.DrawString("zuzahlung:"+printRezeptTmp.zuzahlung,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);				
			e.Graphics.DrawString("gesamtBrutto:"+printRezeptTmp.gesamtBrutto,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);				
			e.Graphics.DrawString("pharamazentralnummer_1:"+printRezeptTmp.pharamazentralnummer_1,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);				
			e.Graphics.DrawString("pharamazentralnummer_2:"+printRezeptTmp.pharamazentralnummer_2,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);		
			e.Graphics.DrawString("pharamazentralnummer_3:"+printRezeptTmp.pharamazentralnummer_3,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);		
			e.Graphics.DrawString("faktor_1:"+printRezeptTmp.faktor_1,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);		
			e.Graphics.DrawString("faktor_2:"+printRezeptTmp.faktor_2,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);		
			e.Graphics.DrawString("faktor_3:"+printRezeptTmp.faktor_3,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);		
			e.Graphics.DrawString("taxe_1:"+printRezeptTmp.taxe_1,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);			
			e.Graphics.DrawString("taxe_2:"+printRezeptTmp.taxe_2,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);			
			e.Graphics.DrawString("taxe_3:"+printRezeptTmp.taxe_3,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);			
			e.Graphics.DrawString("datum:"+printRezeptTmp.datum,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);		
			e.Graphics.DrawString("date_from:"+printRezeptTmp.date_from,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);		
			e.Graphics.DrawString("date_to:"+printRezeptTmp.date_to,new System.Drawing.Font("Times New Roman",12,FontStyle.Italic),Brushes.Black, 20, 100);			
		}
		
		public static List<ERezept> getAllRezeptFromDoc(int docNr){
			String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			path+="\\Karte";
			List<ERezept> export= new List<ERezept>();
			if(Directory.Exists(path)){
				foreach(String f in Directory.GetFiles(path)){
					String []lines=File.ReadAllLines(f);
					String puffer="";
					for(int i=0;i<=lines[1].Length;i++){
						if(Char.IsNumber(lines[1][i])){
							puffer+=lines[1][i];
						}else{
							break;
						}
					}
					int rDocNR=Convert.ToInt32(puffer);
					if(rDocNR==docNr){
						ERezept r=parsERezept(lines);
						if(r!=null)
							export.Add(r);
					}
				}
			}
			return export;
		}
		
		public static List<ERezept> getAllRezept(){
			String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			path+="\\Karte";
			List<ERezept> export= new List<ERezept>();
			if(Directory.Exists(path)){
				foreach(String f in Directory.GetFiles(path)){
					String []lines=File.ReadAllLines(f);
					ERezept r=parsERezept(lines);
					if(r!=null)
						export.Add(r);			
				}
			}
			return export;
		}

		private static ERezept parsERezept(String[] lines){
			ERezept eRezept=null;		
			lines[3]=lines[3].Replace("<NEWLINE>",System.Environment.NewLine);
			String []info=Regex.Split(lines[3], "<LB>");
			eRezept=new ERezept(
					convertToBool(info[0]),
					convertToBool(info[1]),
					convertToBool(info[2]),
					convertToBool(info[3]),
					convertToBool(info[4]),
					convertToBool(info[5]),
					convertToBool(info[6]),
					convertToBool(info[7]),
					convertToBool(info[8]),
					info[9],
					info[10],
					info[11],
					info[12],
					info[13],
					info[14],
					info[15],
					info[16],
					info[17],
					info[18],
					info[19],
					info[20],
					info[21],
					info[22],
					info[23],
					info[24],
					info[25],
					info[26],
					info[27],
					info[28],
					info[29],
					info[30],
					DateTime.Parse(info[31]),
					DateTime.Parse(info[32]),
					DateTime.Parse(info[33]));
			if(SecurityHelper.MD5HashCheck(lines[3],lines[5])){
				return eRezept;
			}else {
				MessageBox.Show("Ein eRezept wurde manipuliert und wird anschließend gelöscht !",
					    "Achtung!",
					    MessageBoxButtons.OK,
					    MessageBoxIcon.Warning,
					    MessageBoxDefaultButton.Button1);
				deleteERezept(eRezept);
				return null;
			}
		}
		
		public static void deleteERezept(ERezept er){
			String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			path+="\\Karte";
			if(Directory.Exists(path)){
				foreach(String f in Directory.GetFiles(path)){
					String []lines=File.ReadAllLines(f);
					String abgleich = er.getExportFormat();
					if(lines[3].Equals(abgleich)){
						File.Delete(f);
						break;
					}
				}
			}
		}

		private static bool convertToBool(String str){
			if(str.ToUpper().Contains("TRUE"))
				return true;
			else 
				return false;
		}
	}
}
