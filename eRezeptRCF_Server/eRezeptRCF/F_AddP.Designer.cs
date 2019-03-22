/*
 * Created by SharpDevelop.
 * User: steve
 * Date: 22.03.2016
 * Time: 10:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace eRezeptRCF
{
	partial class F_AddP
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox t_hospital;
		private System.Windows.Forms.TextBox t_name;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox t_cityAndCode;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox t_street;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox t_state;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox t_phone;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button b_add;
		private System.Windows.Forms.TextBox t_username;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox t_password;
		private System.Windows.Forms.Label label9;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.t_hospital = new System.Windows.Forms.TextBox();
			this.t_name = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.t_cityAndCode = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.t_street = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.t_state = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.t_phone = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.b_add = new System.Windows.Forms.Button();
			this.t_username = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.t_password = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(14, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hospital";
			// 
			// t_hospital
			// 
			this.t_hospital.Location = new System.Drawing.Point(124, 64);
			this.t_hospital.MaxLength = 50;
			this.t_hospital.Name = "t_hospital";
			this.t_hospital.Size = new System.Drawing.Size(237, 20);
			this.t_hospital.TabIndex = 3;
			// 
			// t_name
			// 
			this.t_name.Location = new System.Drawing.Point(124, 90);
			this.t_name.MaxLength = 120;
			this.t_name.Name = "t_name";
			this.t_name.Size = new System.Drawing.Size(237, 20);
			this.t_name.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(14, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 14);
			this.label2.TabIndex = 2;
			this.label2.Text = "Full name";
			// 
			// t_cityAndCode
			// 
			this.t_cityAndCode.Location = new System.Drawing.Point(124, 142);
			this.t_cityAndCode.MaxLength = 56;
			this.t_cityAndCode.Name = "t_cityAndCode";
			this.t_cityAndCode.Size = new System.Drawing.Size(237, 20);
			this.t_cityAndCode.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(14, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 14);
			this.label3.TabIndex = 4;
			this.label3.Text = "City and code";
			// 
			// t_street
			// 
			this.t_street.Location = new System.Drawing.Point(124, 168);
			this.t_street.MaxLength = 50;
			this.t_street.Name = "t_street";
			this.t_street.Size = new System.Drawing.Size(237, 20);
			this.t_street.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(14, 171);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 14);
			this.label4.TabIndex = 6;
			this.label4.Text = "Street";
			// 
			// t_state
			// 
			this.t_state.Location = new System.Drawing.Point(124, 116);
			this.t_state.MaxLength = 50;
			this.t_state.Name = "t_state";
			this.t_state.Size = new System.Drawing.Size(237, 20);
			this.t_state.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(14, 119);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 14);
			this.label5.TabIndex = 8;
			this.label5.Text = "State";
			// 
			// t_phone
			// 
			this.t_phone.Location = new System.Drawing.Point(124, 194);
			this.t_phone.MaxLength = 16;
			this.t_phone.Name = "t_phone";
			this.t_phone.Size = new System.Drawing.Size(237, 20);
			this.t_phone.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(14, 197);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 14);
			this.label6.TabIndex = 10;
			this.label6.Text = "Phone";
			// 
			// b_add
			// 
			this.b_add.Location = new System.Drawing.Point(14, 220);
			this.b_add.Name = "b_add";
			this.b_add.Size = new System.Drawing.Size(347, 23);
			this.b_add.TabIndex = 9;
			this.b_add.Text = "Add Person";
			this.b_add.UseVisualStyleBackColor = true;
			this.b_add.Click += new System.EventHandler(this.B_addClick);
			// 
			// t_username
			// 
			this.t_username.Location = new System.Drawing.Point(124, 12);
			this.t_username.MaxLength = 25;
			this.t_username.Name = "t_username";
			this.t_username.Size = new System.Drawing.Size(237, 20);
			this.t_username.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(14, 15);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(104, 14);
			this.label8.TabIndex = 15;
			this.label8.Text = "Username";
			// 
			// t_password
			// 
			this.t_password.Location = new System.Drawing.Point(124, 38);
			this.t_password.MaxLength = 25;
			this.t_password.Name = "t_password";
			this.t_password.PasswordChar = '*';
			this.t_password.Size = new System.Drawing.Size(237, 20);
			this.t_password.TabIndex = 2;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(14, 41);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(104, 14);
			this.label9.TabIndex = 17;
			this.label9.Text = "Password";
			// 
			// F_AddP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 256);
			this.Controls.Add(this.t_password);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.t_username);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.b_add);
			this.Controls.Add(this.t_phone);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.t_state);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.t_street);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.t_cityAndCode);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.t_name);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.t_hospital);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "F_AddP";
			this.Text = "Add Person";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
