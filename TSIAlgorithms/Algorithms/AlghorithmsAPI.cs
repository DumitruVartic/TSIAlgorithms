using System.Text;

namespace TSIAlghorithms.Alghorithms
{
    class AlgorithmsAPI
    {
        public static string DesAesHandler(string originalKey, string originalText, string algorithm, string mode)
        {
            byte[] key = DesAesAlgorithms.GenerateCompatibleKey(originalKey, algorithm);
            if (mode == "Encrypt")
                return DesAesAlgorithms.Encrypt(originalText, key, algorithm);
            return DesAesAlgorithms.Decrypt(originalText, key, algorithm);
        }

        public static (string, string) RsaHandler(string originalData, string initialPublicKey, string signatureString, string mode)
        {
            if (mode == "Sign")
                return RsaAlghorithms.RsaSign(originalData);

            bool isSignatureValid = false;
            try
            {
                // Prepare all data, can be errors
                byte[] data = Encoding.UTF8.GetBytes(originalData);
                byte[] signature = Convert.FromBase64String(signatureString);
                byte[] publicKey = Convert.FromBase64String(initialPublicKey);
                // Verify the signature
                isSignatureValid = RsaAlghorithms.VerifyRsaSignature(data, signature, publicKey);
                return (signatureString, isSignatureValid.ToString());

            }
            catch (Exception)
            {
                // if the signature and publicKey was modified and is not a base64 string then it gives an error
                // sometimes also can be an error with the publicKey in VerifyRsaSignature method
                return (signatureString, false.ToString());
            }
        }
    }
}