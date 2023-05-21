using System.Security.Cryptography;
using System.Text;

namespace TSIAlghorithms.Alghorithms
{
    class DesAesAlgorithms
    {
        public static string Encrypt(string original, byte[] key, string algorithm)
        {
            byte[] encryptedBytes;
            using (SymmetricAlgorithm symAlgo = algorithm == "AES" ? (SymmetricAlgorithm)Aes.Create() : (SymmetricAlgorithm)DES.Create())
            {
                symAlgo.Key = key;
                symAlgo.Mode = CipherMode.ECB;
                ICryptoTransform encryptor = symAlgo.CreateEncryptor(symAlgo.Key, symAlgo.IV);
                byte[] originalBytes = Encoding.UTF8.GetBytes(original);
                encryptedBytes = encryptor.TransformFinalBlock(originalBytes, 0, originalBytes.Length);
            }
            return Convert.ToBase64String(encryptedBytes);
        }

        public static string Decrypt(string encrypted, byte[] key, string algorithm)
        {
            // byte[] encryptedBytes = Convert.FromBase64String(encrypted);
            if (!TryDecodeBase64String(encrypted, out byte[] encryptedBytes))
                return "Error: Input isn't a base64 string";

            string decrypted;
            using (SymmetricAlgorithm symAlgo = algorithm == "AES" ? (SymmetricAlgorithm)Aes.Create() : (SymmetricAlgorithm)DES.Create())
            {
                symAlgo.Key = key;
                symAlgo.Mode = CipherMode.ECB;
                ICryptoTransform decryptor = symAlgo.CreateDecryptor(symAlgo.Key, symAlgo.IV);
                // byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length); // error-incorect key ?
                byte[] decryptedBytes;
                try
                {
                    decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                }
                catch (Exception)
                {
                    return "Error: Incorect key";
                }
                decrypted = Encoding.UTF8.GetString(decryptedBytes);
            }
            return decrypted;
        }

        public static byte[] GenerateCompatibleKey(string key, string algorithmType)
        {
            // Alghorithm specific code (DES need a 8 long keys, AES - 16)
            int length = 16;
            if (algorithmType == "DES")
                length = 8;

            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(keyBytes);
                byte[] aesKey = new byte[length];
                Array.Copy(hashBytes, aesKey, length);
                return aesKey;
            }
        }

        // *facepalm.png* , error handling(if it's not a base64 string) ...
        public static bool TryDecodeBase64String(string input, out byte[] output)
        {
            // Check if the length of the input string is a multiple of 4
            if (input.Length % 4 != 0)
            {
                output = null;
                return false;
            }

            // Try decoding the input string with padding characters
            try
            {
                output = Convert.FromBase64String(input);
                return true;
            }
            catch (FormatException)
            {
                // The input string contained invalid Base64 characters
            }

            // Try decoding the input string with one padding character
            try
            {
                output = Convert.FromBase64String(input + "=");
                return true;
            }
            catch (FormatException)
            {
                // The input string contained invalid Base64 characters
            }

            // Try decoding the input string with two padding characters
            try
            {
                output = Convert.FromBase64String(input + "==");
                return true;
            }
            catch (FormatException)
            {
                // The input string contained invalid Base64 characters
            }

            // The input string was not a valid Base64 string
            output = null;
            return false;
        }
    }
}