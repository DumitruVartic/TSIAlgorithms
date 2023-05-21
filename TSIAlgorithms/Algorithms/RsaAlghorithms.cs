using System.Security.Cryptography;
using System.Text;

namespace TSIAlghorithms.Alghorithms
{
    class RsaAlghorithms
    {
        /// <summary>
        ///  Returns a tuple with the structure : (signedData, publicKey)
        /// </summary>
        public static (string, string) RsaSign(string dataToSign)
        {
            // Generate RSA key pair
            using (RSA rsa = RSA.Create())
            {
                byte[] publicKey = rsa.ExportSubjectPublicKeyInfo();
                byte[] signature = null;
                byte[] data = Encoding.UTF8.GetBytes(dataToSign);
                using (SHA256 sha256 = SHA256.Create())
                {
                    signature = rsa.SignData(data, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                }

                string signedData = Convert.ToBase64String(signature);
                string publicKeyString = Convert.ToBase64String(publicKey);

                return (signedData, publicKeyString);
            }
        }

        public static bool VerifyRsaSignature(byte[] data, byte[] signature, byte[] publicKey)
        {
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportSubjectPublicKeyInfo(publicKey, out int bytesRead);

                using (SHA256 sha256 = SHA256.Create())
                {
                    return rsa.VerifyData(data, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                }
            }
        }
    }
}