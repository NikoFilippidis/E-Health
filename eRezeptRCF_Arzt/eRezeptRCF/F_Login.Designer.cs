/*
 * Created by SharpDevelop.
 * User: steve
 * Date: 12.05.2016
 * Time: 10:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace eRezeptRCF
{
	partial class F_Login
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button b_login;
		private System.Windows.Forms.Button b_offline;
		private System.Windows.Forms.TextBox textBox_username;
		private System.Windows.Forms.TextBox textBox_password;
		private System.Windows.Forms.CheckBox auto_login;
		private System.Windows.Forms.Label name;
		private System.Windows.Forms.Label password;
		private System.Windows.Forms.Label label_error;
		
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
			this.b_login = new System.Windows.Forms.Button();
			this.b_offline = new System.Windows.Forms.Button();
			this.textBox_username = new System.Windows.Forms.TextBox();
			this.textBox_password = new System.Windows.Forms.TextBox();
			this.auto_login = new System.Windows.Forms.CheckBox();
			this.name = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.Label();
			this.label_error = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// b_login
			// 
			this.b_login.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.b_login.BackgroundImage = global::eRezeptRCF.Resource.LoginKleiner2;
			this.b_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.b_login.Cursor = System.Windows.Forms.Cursors.Hand;
			this.b_login.FlatAppearance.BorderSize = 0;
			this.b_login.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.b_login.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.b_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.b_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.b_login.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.b_login.Location = new System.Drawing.Point(158, 167);
			this.b_login.Name = "b_login";
			this.b_login.Size = new System.Drawing.Size(112, 41);
			this.b_login.TabIndex = 99;
			this.b_login.TabStop = false;
			this.b_login.UseVisualStyleBackColor = false;
			this.b_login.Click += new System.EventHandler(this.B_loginClick);
			// 
			// b_offline
			// 
			this.b_offline.BackgroundImage = global::eRezeptRCF.Resource.OfflineKleiner;
			this.b_offline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.b_offline.Cursor = System.Windows.Forms.Cursors.Hand;
			this.b_offline.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
			this.b_offline.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.b_offline.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.b_offline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.b_offline.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.b_offline.Location = new System.Drawing.Point(277, 167);
			this.b_offline.Name = "b_offline";
			this.b_offline.Size = new System.Drawing.Size(112, 41);
			this.b_offline.TabIndex = 100;
			this.b_offline.TabStop = false;
			this.b_offline.UseVisualStyleBackColor = true;
			this.b_offline.Click += new System.EventHandler(this.B_offlineClick);
			// 
			// textBox_username
			// 
			this.textBox_username.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_username.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.textBox_username.Location = new System.Drawing.Point(90, 25);
			this.textBox_username.MaxLength = 25;
			this.textBox_username.Name = "textBox_username";
			this.textBox_username.Size = new System.Drawing.Size(300, 24);
			this.textBox_username.TabIndex = 1;
			// 
			// textBox_password
			// 
			this.textBox_password.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.textBox_password.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.textBox_password.Location = new System.Drawing.Point(90, 72);
			this.textBox_password.MaxLength = 25;
			this.textBox_password.Name = "textBox_password";
			this.textBox_password.Size = new System.Drawing.Size(300, 24);
			this.textBox_password.TabIndex = 2;
			// 
			// auto_login
			// 
			this.auto_login.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.auto_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.auto_login.Location = new System.Drawing.Point(91, 100);
			this.auto_login.Name = "auto_login";
			this.auto_login.Size = new System.Drawing.Size(259, 23);
			this.auto_login.TabIndex = 0;
			this.auto_login.Text = "Login merken und automatisch einloggen";
			this.auto_login.UseVisualStyleBackColor = false;
			// 
			// name
			// 
			this.name.ForeColor = System.Drawing.Color.White;
			this.name.Location = new System.Drawing.Point(12, 29);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(78, 23);
			this.name.TabIndex = 101;
			this.name.Text = "Benutzername";
			// 
			// password
			// 
			this.password.ForeColor = System.Drawing.Color.White;
			this.password.Location = new System.Drawing.Point(37, 76);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(53, 23);
			this.password.TabIndex = 102;
			this.password.Text = "Passwort";
			// 
			// label_error
			// 
			this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_error.ForeColor = System.Drawing.Color.Red;
			this.label_error.Location = new System.Drawing.Point(12, 120);
			this.label_error.Name = "label_error";
			this.label_error.Size = new System.Drawing.Size(378, 44);
			this.label_error.TabIndex = 103;
			this.label_error.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// F_Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(404, 211);
			this.Controls.Add(this.b_offline);
			this.Controls.Add(this.b_login);
			this.Controls.Add(this.label_error);
			this.Controls.Add(this.password);
			this.Controls.Add(this.name);
			this.Controls.Add(this.auto_login);
			this.Controls.Add(this.textBox_password);
			this.Controls.Add(this.textBox_username);
			this.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "F_Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "eRezept Login";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
