//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Threading.Tasks;

//namespace RSA
//{
//    public class Program
//    {
//        public byte[] cheiePublica;
//      public static  RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
//        UnicodeEncoding ByteConverter = new UnicodeEncoding();
//       public static RSAParameters cheie;
//        public static byte[] decryptedData;
//        Aoleu a = new Aoleu();
//        static void Main(string[] args)
//        {
//          //  EncriptRSA e = new EncriptRSA();
//         //   DecriptRSA d = new DecriptRSA();
//            cheie = getCheiePublica(RSA.ExportParameters(false), false);
//            decryptedData = RSADecrypt(encryptedData, RSA.ExportParameters(true), false);
//        }
//        public static RSAParameters getCheiePublica(RSAParameters RSAKeyInfo, bool DoOAEPPadding)
//        {
//           // cheie
//            RSA.ImportParameters(RSAKeyInfo);
//            return RSAKeyInfo;
//        }
//        public static RSAParameters getCheiePublica()
//        {
//            return cheie;
//        }

//        static public byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
//        {
//            try
//            {
//                byte[] decryptedData;
//                //Create a new instance of RSACryptoServiceProvider.
               
//                    //Import the RSA Key information. This needs
//                    //to include the private key information.
//                    RSA.ImportParameters(RSAKeyInfo);

//                    //Decrypt the passed byte array and specify OAEP padding.  
//                    //OAEP padding is only available on Microsoft Windows XP or
//                    //later.  
//                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                
//                return decryptedData;
//            }

//    }
//}
