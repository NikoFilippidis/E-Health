/*
 * Created by SharpDevelop.
 * User: steve
 * Date: 11.05.2016
 * Time: 18:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace eRezeptRCF
{
	partial class F_Quittierung
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button_quittieren;
		private System.Windows.Forms.Button button_drucken;
		private System.Windows.Forms.Button button_speichern;
		private System.Windows.Forms.Button button_zuruek;
		
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
			this.button_quittieren = new System.Windows.Forms.Button();
			this.button_drucken = new System.Windows.Forms.Button();
			this.button_speichern = new System.Windows.Forms.Button();
			this.button_zuruek = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button_quittieren
			// 
			this.button_quittieren.BackgroundImage = global::eRezeptRCF.Resource.Quittieren;
			this.button_quittieren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button_quittieren.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_quittieren.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button_quittieren.FlatAppearance.BorderSize = 0;
			this.button_quittieren.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button_quittieren.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button_quittieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_quittieren.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button_quittieren.Location = new System.Drawing.Point(23, 13);
			this.button_quittieren.Margin = new System.Windows.Forms.Padding(4);
			this.button_quittieren.Name = "button_quittieren";
			this.button_quittieren.Size = new System.Drawing.Size(147, 36);
			this.button_quittieren.TabIndex = 0;
			this.button_quittieren.UseVisualStyleBackColor = true;
			this.button_quittieren.Click += new System.EventHandler(this.Button_quittierenClick);
			// 
			// button_drucken
			// 
			this.button_drucken.BackgroundImage = global::eRezeptRCF.Resource.Drucken;
			this.button_drucken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button_drucken.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_drucken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_drucken.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button_drucken.Location = new System.Drawing.Point(23, 57);
			this.button_drucken.Margin = new System.Windows.Forms.Padding(4);
			this.button_drucken.Name = "button_drucken";
			this.button_drucken.Size = new System.Drawing.Size(147, 36);
			this.button_drucken.TabIndex = 2;
			this.button_drucken.UseVisualStyleBackColor = true;
			this.button_drucken.Click += new System.EventHandler(this.Button_druckenClick);
			// 
			// button_speichern
			// 
			this.button_speichern.BackgroundImage = global::eRezeptRCF.Resource.Speichern;
			this.button_speichern.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button_speichern.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_speichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_speichern.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button_speichern.Location = new System.Drawing.Point(23, 101);
			this.button_speichern.Margin = new System.Windows.Forms.Padding(4);
			this.button_speichern.Name = "button_speichern";
			this.button_speichern.Size = new System.Drawing.Size(147, 36);
			this.button_speichern.TabIndex = 3;
			this.button_speichern.UseVisualStyleBackColor = true;
			this.button_speichern.Click += new System.EventHandler(this.Button_speichernClick);
			// 
			// button_zuruek
			// 
			this.button_zuruek.BackgroundImage = global::eRezeptRCF.Resource.ZHurück;
			this.button_zuruek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button_zuruek.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_zuruek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_zuruek.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button_zuruek.Location = new System.Drawing.Point(23, 145);
			this.button_zuruek.Margin = new System.Windows.Forms.Padding(4);
			this.button_zuruek.Name = "button_zuruek";
			this.button_zuruek.Size = new System.Drawing.Size(147, 36);
			this.button_zuruek.TabIndex = 4;
			this.button_zuruek.UseVisualStyleBackColor = true;
			this.button_zuruek.Click += new System.EventHandler(this.Button_zuruekClick);
			// 
			// F_Quittierung
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(192, 197);
			this.Controls.Add(this.button_zuruek);
			this.Controls.Add(this.button_speichern);
			this.Controls.Add(this.button_drucken);
			this.Controls.Add(this.button_quittieren);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "F_Quittierung";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Quittierung";
			this.TopMost = true;
			this.ResumeLayout(false);

		}
	}
}
