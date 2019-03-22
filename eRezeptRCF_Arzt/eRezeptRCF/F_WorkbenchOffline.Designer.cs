/*
 * Created by SharpDevelop.
 * User: steve
 * Date: 11.05.2016
 * Time: 19:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace eRezeptRCF
{
	partial class F_WorkbenchOffline
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton_Speichern;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButton_GoOut;
		private System.Windows.Forms.ToolStripButton toolStripButton_Drucken;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripButton toolStripButton_New;
		private System.Windows.Forms.CheckBox checkBox_AutIdem;
		private System.Windows.Forms.CheckBox checkBox_sonstige;
		private System.Windows.Forms.CheckBox checkBox_noctu;
		private System.Windows.Forms.CheckBox checkBox_gebuehrenpflichtig;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_KKostentraeger;
		private System.Windows.Forms.TextBox textBox_Status;
		private System.Windows.Forms.TextBox textBox_VersichertenNr;
		private System.Windows.Forms.TextBox textBox3_KassenNr;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_NVVVersicherter;
		private System.Windows.Forms.DateTimePicker datum;
		private System.Windows.Forms.TextBox textBox_ApothekenNr;
		private System.Windows.Forms.TextBox textBox_ArztNr;
		private System.Windows.Forms.TextBox textBox_BetriebsstaettenNr;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox textBox_3_Taxe;
		private System.Windows.Forms.TextBox textBox_3_Faktor;
		private System.Windows.Forms.TextBox textBox_3_Pharamazentralnummer;
		private System.Windows.Forms.TextBox textBox_2_Taxe;
		private System.Windows.Forms.TextBox textBox_2_Faktor;
		private System.Windows.Forms.TextBox textBox_2_Pharamazentralnummer;
		private System.Windows.Forms.TextBox textBox_1_Taxe;
		private System.Windows.Forms.TextBox textBox_1_Faktor;
		private System.Windows.Forms.TextBox textBox_1_Pharamazentralnummer;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox_GesamtBrutto;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox_Zuzahlung;
		private System.Windows.Forms.TextBox textBox_BVG;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox_signatur;
		private System.Windows.Forms.DateTimePicker date_to;
		private System.Windows.Forms.TextBox textBox_T_RezeptNR;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.DateTimePicker date_from;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.CheckBox checkBox_O4;
		private System.Windows.Forms.CheckBox checkBox_O2;
		private System.Windows.Forms.CheckBox checkBox_O3;
		private System.Windows.Forms.CheckBox checkBox_O1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.CheckBox checkBox_gebuehrenfrei;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.ToolStripLabel errorInfo;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_WorkbenchOffline));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton_Drucken = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_Speichern = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton_New = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_GoOut = new System.Windows.Forms.ToolStripButton();
			this.errorInfo = new System.Windows.Forms.ToolStripLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox_signatur = new System.Windows.Forms.TextBox();
			this.date_to = new System.Windows.Forms.DateTimePicker();
			this.textBox_T_RezeptNR = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.date_from = new System.Windows.Forms.DateTimePicker();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.checkBox_O4 = new System.Windows.Forms.CheckBox();
			this.checkBox_O2 = new System.Windows.Forms.CheckBox();
			this.checkBox_O3 = new System.Windows.Forms.CheckBox();
			this.checkBox_O1 = new System.Windows.Forms.CheckBox();
			this.label17 = new System.Windows.Forms.Label();
			this.textBox_3_Taxe = new System.Windows.Forms.TextBox();
			this.textBox_3_Faktor = new System.Windows.Forms.TextBox();
			this.textBox_3_Pharamazentralnummer = new System.Windows.Forms.TextBox();
			this.textBox_2_Taxe = new System.Windows.Forms.TextBox();
			this.textBox_2_Faktor = new System.Windows.Forms.TextBox();
			this.textBox_2_Pharamazentralnummer = new System.Windows.Forms.TextBox();
			this.textBox_1_Taxe = new System.Windows.Forms.TextBox();
			this.textBox_1_Faktor = new System.Windows.Forms.TextBox();
			this.textBox_1_Pharamazentralnummer = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox_GesamtBrutto = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox_Zuzahlung = new System.Windows.Forms.TextBox();
			this.textBox_BVG = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox_ApothekenNr = new System.Windows.Forms.TextBox();
			this.datum = new System.Windows.Forms.DateTimePicker();
			this.textBox_ArztNr = new System.Windows.Forms.TextBox();
			this.textBox_BetriebsstaettenNr = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox_Status = new System.Windows.Forms.TextBox();
			this.textBox_VersichertenNr = new System.Windows.Forms.TextBox();
			this.textBox3_KassenNr = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_NVVVersicherter = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox_AutIdem = new System.Windows.Forms.CheckBox();
			this.textBox_KKostentraeger = new System.Windows.Forms.TextBox();
			this.checkBox_sonstige = new System.Windows.Forms.CheckBox();
			this.checkBox_noctu = new System.Windows.Forms.CheckBox();
			this.checkBox_gebuehrenpflichtig = new System.Windows.Forms.CheckBox();
			this.checkBox_gebuehrenfrei = new System.Windows.Forms.CheckBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label21 = new System.Windows.Forms.Label();
			this.toolStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripButton_Drucken,
			this.toolStripButton_Speichern,
			this.toolStripSeparator1,
			this.toolStripButton_New,
			this.toolStripButton_GoOut,
			this.errorInfo});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(872, 44);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton_Drucken
			// 
			this.toolStripButton_Drucken.BackColor = System.Drawing.Color.Transparent;
			this.toolStripButton_Drucken.BackgroundImage = global::eRezeptRCF.Resource.Drucken;
			this.toolStripButton_Drucken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.toolStripButton_Drucken.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.toolStripButton_Drucken.ForeColor = System.Drawing.SystemColors.ControlText;
			this.toolStripButton_Drucken.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButton_Drucken.Margin = new System.Windows.Forms.Padding(10);
			this.toolStripButton_Drucken.Name = "toolStripButton_Drucken";
			this.toolStripButton_Drucken.Padding = new System.Windows.Forms.Padding(10, 10, 80, 10);
			this.toolStripButton_Drucken.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.toolStripButton_Drucken.Size = new System.Drawing.Size(94, 24);
			this.toolStripButton_Drucken.Click += new System.EventHandler(this.ToolStripButton_DruckenClick);
			// 
			// toolStripButton_Speichern
			// 
			this.toolStripButton_Speichern.BackColor = System.Drawing.Color.Transparent;
			this.toolStripButton_Speichern.BackgroundImage = global::eRezeptRCF.Resource.Speichern;
			this.toolStripButton_Speichern.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.toolStripButton_Speichern.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButton_Speichern.Name = "toolStripButton_Speichern";
			this.toolStripButton_Speichern.Padding = new System.Windows.Forms.Padding(10, 10, 100, 10);
			this.toolStripButton_Speichern.Size = new System.Drawing.Size(114, 41);
			this.toolStripButton_Speichern.Click += new System.EventHandler(this.ToolStripButton_SpeichernClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
			// 
			// toolStripButton_New
			// 
			this.toolStripButton_New.BackgroundImage = global::eRezeptRCF.Resource.Neu1;
			this.toolStripButton_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.toolStripButton_New.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_New.Name = "toolStripButton_New";
			this.toolStripButton_New.Padding = new System.Windows.Forms.Padding(10, 10, 100, 10);
			this.toolStripButton_New.Size = new System.Drawing.Size(114, 41);
			this.toolStripButton_New.Click += new System.EventHandler(this.ToolStripButton_NewClick);
			// 
			// toolStripButton_GoOut
			// 
			this.toolStripButton_GoOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButton_GoOut.BackgroundImage = global::eRezeptRCF.Resource.zurück3;
			this.toolStripButton_GoOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.toolStripButton_GoOut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_GoOut.Name = "toolStripButton_GoOut";
			this.toolStripButton_GoOut.Padding = new System.Windows.Forms.Padding(10, 10, 130, 10);
			this.toolStripButton_GoOut.Size = new System.Drawing.Size(144, 41);
			this.toolStripButton_GoOut.Click += new System.EventHandler(this.ToolStripButton_GoOutClick);
			// 
			// errorInfo
			// 
			this.errorInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorInfo.ForeColor = System.Drawing.Color.Red;
			this.errorInfo.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
			this.errorInfo.Name = "errorInfo";
			this.errorInfo.Size = new System.Drawing.Size(0, 41);
			this.errorInfo.Visible = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.textBox_signatur);
			this.panel1.Controls.Add(this.date_to);
			this.panel1.Controls.Add(this.textBox_T_RezeptNR);
			this.panel1.Controls.Add(this.label20);
			this.panel1.Controls.Add(this.date_from);
			this.panel1.Controls.Add(this.label19);
			this.panel1.Controls.Add(this.label18);
			this.panel1.Controls.Add(this.checkBox_O4);
			this.panel1.Controls.Add(this.checkBox_O2);
			this.panel1.Controls.Add(this.checkBox_O3);
			this.panel1.Controls.Add(this.checkBox_O1);
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.textBox_3_Taxe);
			this.panel1.Controls.Add(this.textBox_3_Faktor);
			this.panel1.Controls.Add(this.textBox_3_Pharamazentralnummer);
			this.panel1.Controls.Add(this.textBox_2_Taxe);
			this.panel1.Controls.Add(this.textBox_2_Faktor);
			this.panel1.Controls.Add(this.textBox_2_Pharamazentralnummer);
			this.panel1.Controls.Add(this.textBox_1_Taxe);
			this.panel1.Controls.Add(this.textBox_1_Faktor);
			this.panel1.Controls.Add(this.textBox_1_Pharamazentralnummer);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.textBox_GesamtBrutto);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.textBox_Zuzahlung);
			this.panel1.Controls.Add(this.textBox_BVG);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.textBox_ApothekenNr);
			this.panel1.Controls.Add(this.datum);
			this.panel1.Controls.Add(this.textBox_ArztNr);
			this.panel1.Controls.Add(this.textBox_BetriebsstaettenNr);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.textBox_Status);
			this.panel1.Controls.Add(this.textBox_VersichertenNr);
			this.panel1.Controls.Add(this.textBox3_KassenNr);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBox_NVVVersicherter);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.checkBox_AutIdem);
			this.panel1.Controls.Add(this.textBox_KKostentraeger);
			this.panel1.Controls.Add(this.checkBox_sonstige);
			this.panel1.Controls.Add(this.checkBox_noctu);
			this.panel1.Controls.Add(this.checkBox_gebuehrenpflichtig);
			this.panel1.Controls.Add(this.checkBox_gebuehrenfrei);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label21);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 44);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(872, 716);
			this.panel1.TabIndex = 1;
			// 
			// textBox_signatur
			// 
			this.textBox_signatur.Location = new System.Drawing.Point(166, 401);
			this.textBox_signatur.Multiline = true;
			this.textBox_signatur.Name = "textBox_signatur";
			this.textBox_signatur.Size = new System.Drawing.Size(649, 79);
			this.textBox_signatur.TabIndex = 59;
			this.textBox_signatur.TextChanged += new System.EventHandler(this.TextBox_signaturTextChanged);
			// 
			// date_to
			// 
			this.date_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.date_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.date_to.Location = new System.Drawing.Point(717, 656);
			this.date_to.Margin = new System.Windows.Forms.Padding(10);
			this.date_to.Name = "date_to";
			this.date_to.Size = new System.Drawing.Size(101, 23);
			this.date_to.TabIndex = 58;
			// 
			// textBox_T_RezeptNR
			// 
			this.textBox_T_RezeptNR.Location = new System.Drawing.Point(607, 619);
			this.textBox_T_RezeptNR.Multiline = true;
			this.textBox_T_RezeptNR.Name = "textBox_T_RezeptNR";
			this.textBox_T_RezeptNR.Size = new System.Drawing.Size(210, 24);
			this.textBox_T_RezeptNR.TabIndex = 53;
			// 
			// label20
			// 
			this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label20.Location = new System.Drawing.Point(501, 617);
			this.label20.Name = "label20";
			this.label20.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
			this.label20.Size = new System.Drawing.Size(100, 25);
			this.label20.TabIndex = 56;
			this.label20.Text = "T-Rezeptnummer:";
			// 
			// date_from
			// 
			this.date_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.date_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.date_from.Location = new System.Drawing.Point(607, 657);
			this.date_from.Margin = new System.Windows.Forms.Padding(10);
			this.date_from.Name = "date_from";
			this.date_from.Size = new System.Drawing.Size(99, 23);
			this.date_from.TabIndex = 55;
			// 
			// label19
			// 
			this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label19.Location = new System.Drawing.Point(501, 657);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(100, 41);
			this.label19.TabIndex = 54;
			this.label19.Text = "Abgabedatum\r\nin der Apotheke\r\n";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label18.Location = new System.Drawing.Point(166, 651);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(100, 23);
			this.label18.TabIndex = 53;
			this.label18.Text = "444rl";
			// 
			// checkBox_O4
			// 
			this.checkBox_O4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox_O4.Location = new System.Drawing.Point(500, 525);
			this.checkBox_O4.Name = "checkBox_O4";
			this.checkBox_O4.Size = new System.Drawing.Size(272, 49);
			this.checkBox_O4.TabIndex = 52;
			this.checkBox_O4.Text = "Behandlung erfolgt außerhalb der \r\nzugelassenen Anwendungsgebiete (Off-Label)\r\n";
			this.checkBox_O4.UseVisualStyleBackColor = true;
			// 
			// checkBox_O2
			// 
			this.checkBox_O2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox_O2.Location = new System.Drawing.Point(500, 486);
			this.checkBox_O2.Name = "checkBox_O2";
			this.checkBox_O2.Size = new System.Drawing.Size(272, 49);
			this.checkBox_O2.TabIndex = 51;
			this.checkBox_O2.Text = "Behandlung erfolgt innerhalb der \r\nzugelassenen Anwendungsgebiete (In-Label)\r\n";
			this.checkBox_O2.UseVisualStyleBackColor = true;
			// 
			// checkBox_O3
			// 
			this.checkBox_O3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox_O3.Location = new System.Drawing.Point(167, 525);
			this.checkBox_O3.Name = "checkBox_O3";
			this.checkBox_O3.Size = new System.Drawing.Size(300, 92);
			this.checkBox_O3.TabIndex = 50;
			this.checkBox_O3.Text = resources.GetString("checkBox_O3.Text");
			this.checkBox_O3.UseVisualStyleBackColor = true;
			// 
			// checkBox_O1
			// 
			this.checkBox_O1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox_O1.Location = new System.Drawing.Point(167, 486);
			this.checkBox_O1.Name = "checkBox_O1";
			this.checkBox_O1.Size = new System.Drawing.Size(402, 49);
			this.checkBox_O1.TabIndex = 49;
			this.checkBox_O1.Text = "Alle Sicherheitsbestimmungen gemäß der Fachinformation\r\nentsprechnder Fertigarzne" +
	"imittel werden eingehalten\r\n";
			this.checkBox_O1.UseVisualStyleBackColor = true;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label17.Location = new System.Drawing.Point(500, 33);
			this.label17.Name = "label17";
			this.label17.Padding = new System.Windows.Forms.Padding(0, 10, 10, 5);
			this.label17.Size = new System.Drawing.Size(363, 52);
			this.label17.TabIndex = 48;
			this.label17.Text = "TEIL 1 für die Apotheke zur Verrechnung";
			// 
			// textBox_3_Taxe
			// 
			this.textBox_3_Taxe.Location = new System.Drawing.Point(727, 351);
			this.textBox_3_Taxe.Multiline = true;
			this.textBox_3_Taxe.Name = "textBox_3_Taxe";
			this.textBox_3_Taxe.Size = new System.Drawing.Size(89, 24);
			this.textBox_3_Taxe.TabIndex = 47;
			// 
			// textBox_3_Faktor
			// 
			this.textBox_3_Faktor.Location = new System.Drawing.Point(670, 351);
			this.textBox_3_Faktor.Multiline = true;
			this.textBox_3_Faktor.Name = "textBox_3_Faktor";
			this.textBox_3_Faktor.Size = new System.Drawing.Size(51, 24);
			this.textBox_3_Faktor.TabIndex = 46;
			// 
			// textBox_3_Pharamazentralnummer
			// 
			this.textBox_3_Pharamazentralnummer.Location = new System.Drawing.Point(500, 351);
			this.textBox_3_Pharamazentralnummer.Multiline = true;
			this.textBox_3_Pharamazentralnummer.Name = "textBox_3_Pharamazentralnummer";
			this.textBox_3_Pharamazentralnummer.Size = new System.Drawing.Size(164, 24);
			this.textBox_3_Pharamazentralnummer.TabIndex = 45;
			// 
			// textBox_2_Taxe
			// 
			this.textBox_2_Taxe.Location = new System.Drawing.Point(727, 320);
			this.textBox_2_Taxe.Multiline = true;
			this.textBox_2_Taxe.Name = "textBox_2_Taxe";
			this.textBox_2_Taxe.Size = new System.Drawing.Size(89, 24);
			this.textBox_2_Taxe.TabIndex = 44;
			// 
			// textBox_2_Faktor
			// 
			this.textBox_2_Faktor.Location = new System.Drawing.Point(670, 320);
			this.textBox_2_Faktor.Multiline = true;
			this.textBox_2_Faktor.Name = "textBox_2_Faktor";
			this.textBox_2_Faktor.Size = new System.Drawing.Size(51, 24);
			this.textBox_2_Faktor.TabIndex = 43;
			// 
			// textBox_2_Pharamazentralnummer
			// 
			this.textBox_2_Pharamazentralnummer.Location = new System.Drawing.Point(500, 320);
			this.textBox_2_Pharamazentralnummer.Multiline = true;
			this.textBox_2_Pharamazentralnummer.Name = "textBox_2_Pharamazentralnummer";
			this.textBox_2_Pharamazentralnummer.Size = new System.Drawing.Size(164, 24);
			this.textBox_2_Pharamazentralnummer.TabIndex = 42;
			// 
			// textBox_1_Taxe
			// 
			this.textBox_1_Taxe.Location = new System.Drawing.Point(727, 288);
			this.textBox_1_Taxe.Multiline = true;
			this.textBox_1_Taxe.Name = "textBox_1_Taxe";
			this.textBox_1_Taxe.Size = new System.Drawing.Size(89, 24);
			this.textBox_1_Taxe.TabIndex = 41;
			// 
			// textBox_1_Faktor
			// 
			this.textBox_1_Faktor.Location = new System.Drawing.Point(670, 288);
			this.textBox_1_Faktor.Multiline = true;
			this.textBox_1_Faktor.Name = "textBox_1_Faktor";
			this.textBox_1_Faktor.Size = new System.Drawing.Size(51, 24);
			this.textBox_1_Faktor.TabIndex = 40;
			// 
			// textBox_1_Pharamazentralnummer
			// 
			this.textBox_1_Pharamazentralnummer.Location = new System.Drawing.Point(500, 288);
			this.textBox_1_Pharamazentralnummer.Multiline = true;
			this.textBox_1_Pharamazentralnummer.Name = "textBox_1_Pharamazentralnummer";
			this.textBox_1_Pharamazentralnummer.Size = new System.Drawing.Size(164, 24);
			this.textBox_1_Pharamazentralnummer.TabIndex = 39;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label16.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label16.Location = new System.Drawing.Point(500, 259);
			this.label16.Name = "label16";
			this.label16.Padding = new System.Windows.Forms.Padding(0, 10, 10, 5);
			this.label16.Size = new System.Drawing.Size(146, 28);
			this.label16.TabIndex = 35;
			this.label16.Text = "Verordnung";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label15.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label15.Location = new System.Drawing.Point(727, 236);
			this.label15.Name = "label15";
			this.label15.Padding = new System.Windows.Forms.Padding(0, 10, 10, 5);
			this.label15.Size = new System.Drawing.Size(146, 28);
			this.label15.TabIndex = 34;
			this.label15.Text = "Taxe";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label14.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label14.Location = new System.Drawing.Point(670, 236);
			this.label14.Name = "label14";
			this.label14.Padding = new System.Windows.Forms.Padding(0, 10, 10, 5);
			this.label14.Size = new System.Drawing.Size(146, 28);
			this.label14.TabIndex = 33;
			this.label14.Text = "Faktor";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label13.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label13.Location = new System.Drawing.Point(500, 236);
			this.label13.Name = "label13";
			this.label13.Padding = new System.Windows.Forms.Padding(0, 10, 10, 5);
			this.label13.Size = new System.Drawing.Size(146, 28);
			this.label13.TabIndex = 32;
			this.label13.Text = "Pharmazentralnummer";
			// 
			// textBox_GesamtBrutto
			// 
			this.textBox_GesamtBrutto.Location = new System.Drawing.Point(661, 202);
			this.textBox_GesamtBrutto.Multiline = true;
			this.textBox_GesamtBrutto.Name = "textBox_GesamtBrutto";
			this.textBox_GesamtBrutto.Size = new System.Drawing.Size(157, 33);
			this.textBox_GesamtBrutto.TabIndex = 16;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label12.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label12.Location = new System.Drawing.Point(661, 174);
			this.label12.Name = "label12";
			this.label12.Padding = new System.Windows.Forms.Padding(0, 10, 10, 5);
			this.label12.Size = new System.Drawing.Size(146, 27);
			this.label12.TabIndex = 30;
			this.label12.Text = "Gesamt-Brutto";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label11.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label11.Location = new System.Drawing.Point(500, 174);
			this.label11.Name = "label11";
			this.label11.Padding = new System.Windows.Forms.Padding(0, 10, 10, 5);
			this.label11.Size = new System.Drawing.Size(146, 28);
			this.label11.TabIndex = 29;
			this.label11.Text = "Zuzahlung";
			// 
			// textBox_Zuzahlung
			// 
			this.textBox_Zuzahlung.Location = new System.Drawing.Point(500, 202);
			this.textBox_Zuzahlung.Multiline = true;
			this.textBox_Zuzahlung.Name = "textBox_Zuzahlung";
			this.textBox_Zuzahlung.Size = new System.Drawing.Size(155, 33);
			this.textBox_Zuzahlung.TabIndex = 15;
			// 
			// textBox_BVG
			// 
			this.textBox_BVG.Location = new System.Drawing.Point(500, 130);
			this.textBox_BVG.Multiline = true;
			this.textBox_BVG.Name = "textBox_BVG";
			this.textBox_BVG.Size = new System.Drawing.Size(155, 33);
			this.textBox_BVG.TabIndex = 13;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label10.Location = new System.Drawing.Point(500, 97);
			this.label10.Name = "label10";
			this.label10.Padding = new System.Windows.Forms.Padding(0, 10, 10, 5);
			this.label10.Size = new System.Drawing.Size(146, 28);
			this.label10.TabIndex = 26;
			this.label10.Text = "BVG";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label9.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label9.Location = new System.Drawing.Point(661, 97);
			this.label9.Name = "label9";
			this.label9.Padding = new System.Windows.Forms.Padding(0, 10, 10, 5);
			this.label9.Size = new System.Drawing.Size(146, 28);
			this.label9.TabIndex = 25;
			this.label9.Text = "Apotheken-Nummer / IK";
			// 
			// textBox_ApothekenNr
			// 
			this.textBox_ApothekenNr.Location = new System.Drawing.Point(661, 130);
			this.textBox_ApothekenNr.Multiline = true;
			this.textBox_ApothekenNr.Name = "textBox_ApothekenNr";
			this.textBox_ApothekenNr.Size = new System.Drawing.Size(157, 33);
			this.textBox_ApothekenNr.TabIndex = 14;
			// 
			// datum
			// 
			this.datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datum.Location = new System.Drawing.Point(377, 353);
			this.datum.Margin = new System.Windows.Forms.Padding(10);
			this.datum.Name = "datum";
			this.datum.Size = new System.Drawing.Size(101, 23);
			this.datum.TabIndex = 12;
			// 
			// textBox_ArztNr
			// 
			this.textBox_ArztNr.Location = new System.Drawing.Point(272, 352);
			this.textBox_ArztNr.Multiline = true;
			this.textBox_ArztNr.Name = "textBox_ArztNr";
			this.textBox_ArztNr.Size = new System.Drawing.Size(100, 24);
			this.textBox_ArztNr.TabIndex = 11;
			// 
			// textBox_BetriebsstaettenNr
			// 
			this.textBox_BetriebsstaettenNr.Location = new System.Drawing.Point(168, 352);
			this.textBox_BetriebsstaettenNr.Multiline = true;
			this.textBox_BetriebsstaettenNr.Name = "textBox_BetriebsstaettenNr";
			this.textBox_BetriebsstaettenNr.Size = new System.Drawing.Size(100, 24);
			this.textBox_BetriebsstaettenNr.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label6.Location = new System.Drawing.Point(378, 325);
			this.label6.Name = "label6";
			this.label6.Padding = new System.Windows.Forms.Padding(0, 10, 10, 5);
			this.label6.Size = new System.Drawing.Size(94, 28);
			this.label6.TabIndex = 19;
			this.label6.Text = "Datum";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label7.Location = new System.Drawing.Point(272, 324);
			this.label7.Name = "label7";
			this.label7.Padding = new System.Windows.Forms.Padding(0, 10, 10, 5);
			this.label7.Size = new System.Drawing.Size(94, 29);
			this.label7.TabIndex = 18;
			this.label7.Text = "Arzt-Nr.";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label8.Location = new System.Drawing.Point(168, 324);
			this.label8.Name = "label8";
			this.label8.Padding = new System.Windows.Forms.Padding(0, 10, 10, 5);
			this.label8.Size = new System.Drawing.Size(108, 28);
			this.label8.TabIndex = 17;
			this.label8.Text = "Betriebsstätten-Nr.";
			// 
			// textBox_Status
			// 
			this.textBox_Status.Location = new System.Drawing.Point(378, 297);
			this.textBox_Status.Multiline = true;
			this.textBox_Status.Name = "textBox_Status";
			this.textBox_Status.Size = new System.Drawing.Size(100, 24);
			this.textBox_Status.TabIndex = 9;
			// 
			// textBox_VersichertenNr
			// 
			this.textBox_VersichertenNr.Location = new System.Drawing.Point(272, 297);
			this.textBox_VersichertenNr.Multiline = true;
			this.textBox_VersichertenNr.Name = "textBox_VersichertenNr";
			this.textBox_VersichertenNr.Size = new System.Drawing.Size(100, 24);
			this.textBox_VersichertenNr.TabIndex = 8;
			// 
			// textBox3_KassenNr
			// 
			this.textBox3_KassenNr.Location = new System.Drawing.Point(168, 297);
			this.textBox3_KassenNr.Multiline = true;
			this.textBox3_KassenNr.Name = "textBox3_KassenNr";
			this.textBox3_KassenNr.Size = new System.Drawing.Size(100, 24);
			this.textBox3_KassenNr.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label5.Location = new System.Drawing.Point(378, 270);
			this.label5.Name = "label5";
			this.label5.Padding = new System.Windows.Forms.Padding(0, 10, 10, 5);
			this.label5.Size = new System.Drawing.Size(94, 28);
			this.label5.TabIndex = 13;
			this.label5.Text = "Status";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label4.Location = new System.Drawing.Point(272, 269);
			this.label4.Name = "label4";
			this.label4.Padding = new System.Windows.Forms.Padding(0, 10, 10, 5);
			this.label4.Size = new System.Drawing.Size(94, 29);
			this.label4.TabIndex = 12;
			this.label4.Text = "Versicherten-Nr.";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label3.Location = new System.Drawing.Point(168, 269);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(0, 10, 10, 5);
			this.label3.Size = new System.Drawing.Size(72, 28);
			this.label3.TabIndex = 11;
			this.label3.Text = "Kassen-Nr.";
			// 
			// textBox_NVVVersicherter
			// 
			this.textBox_NVVVersicherter.Location = new System.Drawing.Point(168, 203);
			this.textBox_NVVVersicherter.Multiline = true;
			this.textBox_NVVVersicherter.Name = "textBox_NVVVersicherter";
			this.textBox_NVVVersicherter.Size = new System.Drawing.Size(310, 55);
			this.textBox_NVVVersicherter.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label2.Location = new System.Drawing.Point(168, 174);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
			this.label2.Size = new System.Drawing.Size(300, 26);
			this.label2.TabIndex = 9;
			this.label2.Text = "Name, Vorname des Versicherten";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label1.Location = new System.Drawing.Point(168, 15);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 10, 5);
			this.label1.Size = new System.Drawing.Size(300, 28);
			this.label1.TabIndex = 8;
			this.label1.Text = "Krankenkasse bzw. Kostenträger";
			// 
			// checkBox_AutIdem
			// 
			this.checkBox_AutIdem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox_AutIdem.Location = new System.Drawing.Point(35, 388);
			this.checkBox_AutIdem.Name = "checkBox_AutIdem";
			this.checkBox_AutIdem.Size = new System.Drawing.Size(117, 24);
			this.checkBox_AutIdem.TabIndex = 4;
			this.checkBox_AutIdem.Text = "aut idem";
			this.checkBox_AutIdem.UseVisualStyleBackColor = true;
			// 
			// textBox_KKostentraeger
			// 
			this.textBox_KKostentraeger.Location = new System.Drawing.Point(168, 46);
			this.textBox_KKostentraeger.Multiline = true;
			this.textBox_KKostentraeger.Name = "textBox_KKostentraeger";
			this.textBox_KKostentraeger.Size = new System.Drawing.Size(310, 118);
			this.textBox_KKostentraeger.TabIndex = 5;
			// 
			// checkBox_sonstige
			// 
			this.checkBox_sonstige.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox_sonstige.Location = new System.Drawing.Point(35, 133);
			this.checkBox_sonstige.Name = "checkBox_sonstige";
			this.checkBox_sonstige.Size = new System.Drawing.Size(83, 24);
			this.checkBox_sonstige.TabIndex = 3;
			this.checkBox_sonstige.Text = "Sonstige";
			this.checkBox_sonstige.UseVisualStyleBackColor = true;
			// 
			// checkBox_noctu
			// 
			this.checkBox_noctu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox_noctu.Location = new System.Drawing.Point(35, 106);
			this.checkBox_noctu.Name = "checkBox_noctu";
			this.checkBox_noctu.Size = new System.Drawing.Size(117, 24);
			this.checkBox_noctu.TabIndex = 2;
			this.checkBox_noctu.Text = "noctu";
			this.checkBox_noctu.UseVisualStyleBackColor = true;
			// 
			// checkBox_gebuehrenpflichtig
			// 
			this.checkBox_gebuehrenpflichtig.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox_gebuehrenpflichtig.Location = new System.Drawing.Point(35, 76);
			this.checkBox_gebuehrenpflichtig.Name = "checkBox_gebuehrenpflichtig";
			this.checkBox_gebuehrenpflichtig.Size = new System.Drawing.Size(117, 24);
			this.checkBox_gebuehrenpflichtig.TabIndex = 1;
			this.checkBox_gebuehrenpflichtig.Text = "Gebührenpflichtig";
			this.checkBox_gebuehrenpflichtig.UseVisualStyleBackColor = true;
			// 
			// checkBox_gebuehrenfrei
			// 
			this.checkBox_gebuehrenfrei.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox_gebuehrenfrei.Location = new System.Drawing.Point(35, 46);
			this.checkBox_gebuehrenfrei.Name = "checkBox_gebuehrenfrei";
			this.checkBox_gebuehrenfrei.Size = new System.Drawing.Size(104, 24);
			this.checkBox_gebuehrenfrei.TabIndex = 0;
			this.checkBox_gebuehrenfrei.Text = "Gebührenfrei";
			this.checkBox_gebuehrenfrei.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(149, 523);
			this.panel2.TabIndex = 60;
			// 
			// label21
			// 
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label21.Location = new System.Drawing.Point(480, 566);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(29, 27);
			this.label21.TabIndex = 61;
			this.label21.Text = "-";
			// 
			// F_WorkbenchOffline
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(872, 760);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MinimumSize = new System.Drawing.Size(888, 597);
			this.Name = "F_WorkbenchOffline";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "eRezept Offline-Modus";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
