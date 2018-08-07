using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSA
{
    class PublicPrivate
    {
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        public RSAParameters getCheiePublica(RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            RSA.ImportParameters(RSAKeyInfo);
            return RSAKeyInfo;
        }
    }
}
