/*
 * Created by SharpDevelop.
 * User: steve
 * Date: 22.03.2016
 * Time: 10:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eRezeptRCF{
	public partial class F_AddP : Form{
	private List<Person> persons;
		public F_AddP(List<Person> persons){
			InitializeComponent();
			this.persons=persons;
		}
	
		void B_addClick(object sender, EventArgs e){
			//Check correkt inputs
			Person p=new Person(
				t_username.Text,
				t_password.Text,
				t_hospital.Text,
				t_name.Text,
				t_state.Text,
				t_cityAndCode.Text,
				t_street.Text,
				t_phone.Text
			);
			persons.Add(p);
			this.Close();
		}
	}
}
