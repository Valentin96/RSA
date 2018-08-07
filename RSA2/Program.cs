using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RSA2
{
    public class Program
    {
        static Emitator e = new Emitator();
       static Receptor receptor = new Receptor();
       static RSAParameters cheie;
        static RSAParameters ttttt;
        static byte[] decryptedData;
        public static UnicodeEncoding ByteConverter = new UnicodeEncoding();
        public static RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
       
     
        static void Main(string[] args)
        {

            string t = "987";
            string encoded = Base64Encode(t);
            string decoded = Base64Decode(encoded);
            Console.WriteLine(encoded);
            Console.WriteLine(decoded);

            receptor.RSAEncrypt(RSA.ExportParameters(false), false);
            ttttt = receptor.getCheie();
            // cheie.D = HttpServerUtility.UrlTokenDecode(receptor.ReturnD());
            //cheie.DP = HttpServerUtility.UrlTokenDecode(receptor.ReturnDP());
            //cheie.DQ = HttpServerUtility.UrlTokenDecode(receptor.ReturnDQ());
            byte[] exponent = HttpServerUtility.UrlTokenDecode(receptor.ReturnExponent());
            Console.WriteLine("aoleu:  " + HttpServerUtility.UrlTokenEncode(exponent));
            cheie.Exponent = exponent;
            // cheie.InverseQ = HttpServerUtility.UrlTokenDecode(receptor.ReturnInverseQ());
            cheie.Modulus = HttpServerUtility.UrlTokenDecode(receptor.ReturnModulus());
            Console.WriteLine("modul:               " + HttpServerUtility.UrlTokenEncode(cheie.Modulus));
            // cheie.P = HttpServerUtility.UrlTokenDecode(receptor.ReturnP());
            // cheie.Q = HttpServerUtility.UrlTokenDecode(receptor.ReturnQ());

            string input = "anamerge";
            byte[] DataToEncrypt = Encoding.UTF8.GetBytes(t);
            //byte[] DataToEncrypt = HttpServerUtility.UrlTokenDecode("a");
            //string qwe = HttpServerUtility.UrlTokenEncode(DataToEncrypt);
            string qwe = Encoding.UTF8.GetString(DataToEncrypt);
            Console.WriteLine("Din data to Encrypt::::" + qwe);
            Console.WriteLine("/n/n");


            byte[] mesaj = e.RSAEncrypt(cheie, false, DataToEncrypt);
            Console.WriteLine("987:     " + HttpServerUtility.UrlTokenEncode(mesaj));
            string tt = HttpServerUtility.UrlTokenEncode(mesaj);
            decryptedData = receptor.RSADecrypt(HttpServerUtility.UrlTokenDecode(tt), RSA.ExportParameters(true), false);


            Console.WriteLine("Decrypted plaintext: {0}", Encoding.UTF8.GetString(decryptedData));


            Console.ReadLine();

        }
        public static string Base64Encode(String plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return HttpServerUtility.UrlTokenEncode(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            byte[] base64Bytes = HttpServerUtility.UrlTokenDecode(base64EncodedData);
            return Encoding.UTF8.GetString(base64Bytes);
        }

        public static void Method()

        {
            receptor.RSAEncrypt(RSA.ExportParameters(false), false);
            ttttt = receptor.getCheie();
            // cheie.D = HttpServerUtility.UrlTokenDecode(receptor.ReturnD());
            //cheie.DP = HttpServerUtility.UrlTokenDecode(receptor.ReturnDP());
            //cheie.DQ = HttpServerUtility.UrlTokenDecode(receptor.ReturnDQ());
            byte[] exponent = HttpServerUtility.UrlTokenDecode(receptor.ReturnExponent());
            Console.WriteLine("aoleu:  " + HttpServerUtility.UrlTokenEncode(exponent));
            cheie.Exponent = exponent;
            // cheie.InverseQ = HttpServerUtility.UrlTokenDecode(receptor.ReturnInverseQ());
            cheie.Modulus = HttpServerUtility.UrlTokenDecode(receptor.ReturnModulus());
            Console.WriteLine("modul:               " + HttpServerUtility.UrlTokenEncode(cheie.Modulus));
            // cheie.P = HttpServerUtility.UrlTokenDecode(receptor.ReturnP());
            // cheie.Q = HttpServerUtility.UrlTokenDecode(receptor.ReturnQ());

            string input = "anamerge";
            byte[] DataToEncrypt = Encoding.UTF8.GetBytes(input);
            //byte[] DataToEncrypt = HttpServerUtility.UrlTokenDecode("a");
            string qwe = HttpServerUtility.UrlTokenEncode(DataToEncrypt);
            Console.WriteLine("Din data to Encrypt::::" + qwe);
            Console.WriteLine("/n/n");


            byte[] mesaj = e.RSAEncrypt(cheie, false, DataToEncrypt);
            Console.WriteLine("987:     " + HttpServerUtility.UrlTokenEncode(mesaj));
            string tt = HttpServerUtility.UrlTokenEncode(mesaj);
            decryptedData = receptor.RSADecrypt(HttpServerUtility.UrlTokenDecode(tt), RSA.ExportParameters(true), false);
            Console.WriteLine("Decrypted plaintext: {0}", System.Text.Encoding.UTF32.GetString(decryptedData).Trim());
        }
    }
}
