using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSA
{
    class EncriptRSA
    {
        public byte[] cheiePublica;
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                //Create a new instance of RSACryptoServiceProvider.
               

                    //Import the RSA Key information. This only needs
                    //toinclude the public key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Encrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                
                return encryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }

        }
        //public byte[] ReturnPublicKey(RSAParameters RSAKeyInfo)
        //{

        //    cheiePublica = RSA.ImportParameters(RSAKeyInfo);
        //    return cheiePublica;
        //}
        public RSAParameters getCheiePublica(RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            RSA.ImportParameters(RSAKeyInfo);
            return RSAKeyInfo;
        }
    }
}
