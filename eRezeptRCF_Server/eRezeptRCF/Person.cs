/*
 * Created by SharpDevelop.
 * User: steve
 * Date: 22.03.2016
 * Time: 10:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Security.Cryptography;

namespace eRezeptRCF{
	public class Person{
		public int id;
		public String username;
		public String password;
		public String hospital;
		public String name;
		public String state;
		public String cityAndCode;
		public String street;
		public String phone;		
		public String prKey;
		public String puKey;
		
		public Person(String username, String password, String hospital, String name, String state, String cityAndCode, String street, String phone){
			id=SecurityHelper.IDGet();
			this.username=username;
			this.password=SecurityHelper.MD5HashText(password);
			this.hospital=hospital;
			this.name=name;
			this.state=state;
			this.cityAndCode=cityAndCode;
			this.street=street;
			this.phone=phone;
			String []keys=SecurityHelper.RSACreateKey();
			puKey = keys[0];
			prKey = keys[1];
		}

		public string getResponseText(){
			return id+"#"+hospital+"#"+name+"#"+state+"#"+cityAndCode+"#"+street+"#"+phone+"#"+prKey+"#"+puKey;
		}
	}
}
