/*
 * Created by SharpDevelop.
 * User: steve
 * Date: 22.03.2016
 * Time: 22:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace eRezeptRCF{
	public static class SecurityHelper{
		private static int idCounter;
		
		//####################### ID Creator ########################
		//###########################################################	
		public static System.Security.Cryptography.X509Certificates.X509Certificate GenerateCertificate(String subjectName, String alias, String pwd){
           var kpgen = new RsaKeyPairGenerator();
        kpgen.Init( new KeyGenerationParameters( 
              new SecureRandom( new CryptoApiRandomGenerator() ), 2048 ) );  
        AsymmetricCipherKeyPair kp = kpgen.GenerateKeyPair();
        var gen = new X509V3CertificateGenerator();
        var certName = new X509Name( "CN=" + subjectName );
        var serialNo = BigInteger.ProbablePrime( 120, new Random() );
        gen.SetSerialNumber( serialNo );
        gen.SetSubjectDN( certName );
        gen.SetIssuerDN( certName );
        gen.SetNotAfter( DateTime.Now.AddYears( 100 ) );
        gen.SetNotBefore( DateTime.Now.Subtract( new TimeSpan( 7, 0, 0, 0 ) ) );
        gen.SetSignatureAlgorithm( "SHA1withRSA" );
        gen.SetPublicKey( kp.Public ); 
        gen.AddExtension(
            X509Extensions.AuthorityKeyIdentifier.Id,
            false,
            new AuthorityKeyIdentifier(
                SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo( kp.Public ),
                new GeneralNames( new GeneralName( certName ) ),
                serialNo ) );
			gen.AddExtension(
            X509Extensions.ExtendedKeyUsage.Id,
            false,
            new ExtendedKeyUsage( new [] { KeyPurposeID.IdKPServerAuth } ) );
 			var newCert = gen.Generate( kp.Private );   
			var newStore = new Pkcs12Store(); 
	        var certEntry = new X509CertificateEntry( newCert );	 
	        newStore.SetCertificateEntry(alias, certEntry);
	 		newStore.SetKeyEntry( alias, new AsymmetricKeyEntry( kp.Private ),new[] { certEntry }); 
	        using ( var certFile = File.Create( "cert.pfx" ) ) {
	            newStore.Save(certFile,pwd.ToCharArray(),new SecureRandom( new CryptoApiRandomGenerator() ));
	        }
        	return new System.Security.Cryptography.X509Certificates.X509Certificate2( "cert.pfx", pwd );
        }
		public static bool ValidateServerCertificate(object sender,System.Security.Cryptography.X509Certificates.X509Certificate certificate,X509Chain chain,SslPolicyErrors sslPolicyErrors){
           if (sslPolicyErrors == SslPolicyErrors.None)
                return true;

            // Do not allow this client to communicate with unauthenticated servers.
            return true;
        }
		//####################### Certificate #######################
		//###########################################################		
		
		//###########################################################
		//####################### ID Creator ########################
		public static void IDinit(){
			idCounter=0;
		}
		public static int IDGet(){
			idCounter++;
			return idCounter;
		}
		//####################### ID Creator ########################
		//###########################################################
		
		//###########################################################
		//########################### RSA ###########################
		public static String[] RSACreateKey(){
			try{
				RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
				return new string[]{RSA.ToXmlString(false),RSA.ToXmlString(true)};//Public, Private
			// disable once EmptyGeneralCatchClause
			}catch{}
			return null;
		}
		public static String RSAEncrypt(String cryptedData, String privateKey){
			RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
			RSA.FromXmlString(privateKey);
			byte []data=ValueStringToBytes(cryptedData);
			byte []encryptedData = RSA.Encrypt(data, false);
			return ValueStringFromBytes(encryptedData);
		}
		public static String RSADecrypt(String cryptedData, String publicKey){
			RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
			RSA.FromXmlString(publicKey);
			byte []data=ValueStringToBytes(cryptedData);
			byte []encryptedData = RSA.Decrypt(data, false);
			return ValueStringFromBytes(encryptedData);
		}			
		//########################### RSA ###########################
		//###########################################################
		
		//###########################################################
		//###################### RSA_Signatur #######################
		public static String RSACreateSignature(String text, String privateKey){
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(privateKey);
            Byte []encryptedSymmetricKey = rsa.SignData(
                Encoding.Unicode.GetBytes(text), 
                new SHA1CryptoServiceProvider());
            return ValueBytesToHex(encryptedSymmetricKey);
        }

        public static bool RSAValidateSignature(String text, String sig, String publicKey){
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(publicKey);
            byte[] signText = ValueStringToByteArray(sig);
            byte[] originalText = Encoding.Unicode.GetBytes(text);
            return rsa.VerifyData(originalText, new SHA1CryptoServiceProvider(), signText);
        }
		//###################### RSA_Signatur #######################
		//###########################################################
		
		//###########################################################
		//########################### MD5 ###########################
		public static String MD5HashText(String text){
			try{
				using (MD5 md5Hash = MD5.Create()){
					return GetMd5Hash(md5Hash, text);
				}
			// disable once EmptyGeneralCatchClause
			}catch{}
			return null;
		}
		private static string GetMd5Hash(MD5 md5Hash, string input){
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++){
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public static bool MD5HashCheck(String input, string hash){
			try{
				using (MD5 md5Hash = MD5.Create()){
		            String hashOfInput = GetMd5Hash(md5Hash, input);
		            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
		            if (0 == comparer.Compare(hashOfInput, hash)) {
		                return true;
		            }
		            else{
		                return false;
		            }
				}
            // disable once EmptyGeneralCatchClause
			}catch{}
			return false;
        }
		//########################### MD5 ###########################
		//###########################################################
		
		//###########################################################
		//########################### AES ###########################
		private static byte[] _salt = Encoding.ASCII.GetBytes("o68213642kbM7c5a21");
		public static String AESEncryptText(String text){
			String puffer = AESEncrypt(text,"o6806642kbM7c5fdsASfdswec43fdF");
			puffer = AESEncrypt(puffer,System.Security.Principal.WindowsIdentity.GetCurrent().Name);
			return puffer;
		}
		public static String AESDecriptText(String text){
			String puffer = AESDecript(text,System.Security.Principal.WindowsIdentity.GetCurrent().Name);
			puffer = AESDecript(puffer,"o6806642kbM7c5fdsASfdswec43fdF");
			return puffer;
		}
		private static string AESEncrypt(string plainText, string sharedSecret){
			if (string.IsNullOrEmpty(plainText))
				return "";
			if (string.IsNullOrEmpty(sharedSecret))
				return "";
			string outStr = null;                       
			RijndaelManaged aesAlg = null;              
			try {
				Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);
				aesAlg = new RijndaelManaged();
				aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
				ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
				using (MemoryStream msEncrypt = new MemoryStream()) {
					msEncrypt.Write(BitConverter.GetBytes(aesAlg.IV.Length), 0, sizeof(int));
					msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);
					using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)) {
						using (StreamWriter swEncrypt = new StreamWriter(csEncrypt)) {
							swEncrypt.Write(plainText);
						}
					}
					outStr = Convert.ToBase64String(msEncrypt.ToArray());
				}
			} finally {
				if (aesAlg != null)
					aesAlg.Clear();
			}
			return outStr;
		}
		private static string AESDecript(string cipherText, string sharedSecret){
			if (string.IsNullOrEmpty(cipherText))
				throw new ArgumentNullException("cipherText");
			if (string.IsNullOrEmpty(sharedSecret))
				throw new ArgumentNullException("sharedSecret");
			RijndaelManaged aesAlg = null;
			string plaintext = null;
			try {
				Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);            
				byte[] bytes = Convert.FromBase64String(cipherText);
				using (MemoryStream msDecrypt = new MemoryStream(bytes)) {
					aesAlg = new RijndaelManaged();
					aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
					aesAlg.IV = ReadByteArray(msDecrypt);
					ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
					using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)) {
						using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        plaintext = srDecrypt.ReadToEnd();
					}
				}
			} finally {
				if (aesAlg != null)
					aesAlg.Clear();
			}
			return plaintext;
		}
		private static byte[] ReadByteArray(Stream s){
			byte[] rawLength = new byte[sizeof(int)];
			if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length) {
				throw new SystemException("Stream did not contain properly formatted byte array");
			}
			byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
			if (s.Read(buffer, 0, buffer.Length) != buffer.Length) {
				throw new SystemException("Did not read byte array properly");
			}

			return buffer;
		}		
		//########################### AES ###########################
		//###########################################################
		
		//###########################################################
		//########################## Value ##########################
		public static Boolean ValueStringUsable(String text){
			return !String.IsNullOrEmpty(text)&&!String.IsNullOrWhiteSpace(text);
		}	
		public static byte[] ValueStringToBytes(String str){
		    byte[] bytes = new byte[str.Length * sizeof(char)];
		    System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
		    return bytes;
		}
		public static String ValueStringFromBytes(byte[] bytes){
		    char[] chars = new char[bytes.Length / sizeof(char)];
		    System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
		    return new String(chars);
		}
		
		public static String ValueBytesToHex(byte[] bytes){
            var hexString = new StringBuilder(bytes.Length);
            for (int i = 0; i < bytes.Length; i++){
                hexString.Append(bytes[i].ToString("X2"));
            }
            return hexString.ToString();
        }
		
		public static byte[] ValueStringToByteArray(String hex){
            int numberChars = hex.Length;
            var bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
		//########################## Value ##########################
		//###########################################################
	}
}
