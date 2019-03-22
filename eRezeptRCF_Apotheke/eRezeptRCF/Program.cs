/*
 * Created by SharpDevelop.
 * User: steve
 * Date: 24.03.2016
 * Time: 13:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace eRezeptRCF{
	internal sealed class Program{
		[STAThread]
		private static void Main(string[] args){
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new F_Workbench());
		}
		
	}
}
