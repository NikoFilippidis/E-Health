using System;

namespace eRezeptRCF{
	public static class LocalDoctor{
		public static Boolean allSet;
		public static int id;
		public static String hospital;
		public static  String name;
		public static String state;
		public static String cityAndCode;
		public static String street;
		private static String phone;
		private static String prKey;
		private static String puKey;
		public static void setValues(int _id, String _hospital, String _name, String _state, String _cityAndCode, String _street, String _phone, String _prKey, String _puKey){
			allSet=false;
			id=_id;
			hospital=_hospital;
			name=_name;
			state=_state;
			cityAndCode=_cityAndCode;
			street=_street;
			phone=_phone;
			prKey=_prKey;
			puKey=_puKey;
			allSet=true;
		}
		
		public static String getExportFormat(){
			return id+"<LB>"
				+hospital+"<LB>"
				+name+"<LB>"
				+state+"<LB>"
				+cityAndCode+"<LB>"
				+street+"<LB>"
				+phone+"<LB>";
		}
	}
}
