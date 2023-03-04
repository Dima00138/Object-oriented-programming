using System.Security.Cryptography;
using System.Text;

namespace CRYPTO
{
    public class Crypting
    {
        public static void Main()
        {
            byte[] key;
            byte[] iv;
            string file = "CText.txt";

            Console.Write("Input crypting text: ");
            string cryp = Console.ReadLine();
            Console.WriteLine($"Crypting text: {cryp}");
            using (TripleDES tripleDes = TripleDES.Create())
            {
                key = tripleDes.Key;
                iv = tripleDes.IV;
            }

            EncryptTextToFile(cryp, file, key, iv);
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] hash = sha256Hash.ComputeHash(File.ReadAllBytes(file));
                File.WriteAllBytes("hash.txt", hash);
            }
                string decrypted = DecryptTextFromFile(file, key, iv);
            Console.WriteLine($"\nDecrypted: {decrypted}");
        }

        public static void EncryptTextToFile(string text, string path, byte[] key, byte[] iv)
        {
            try
            {
                // Create or open the specified file.
                using (FileStream fStream = File.Open(path, FileMode.Create))
                // Create a new TripleDES object.
                using (TripleDES tripleDes = TripleDES.Create())
                // Create a TripleDES encryptor from the key and IV
                using (ICryptoTransform encryptor = tripleDes.CreateEncryptor(key, iv))
                // Create a CryptoStream using the FileStream and encryptor
                using (var cStream = new CryptoStream(fStream, encryptor, CryptoStreamMode.Write))
                {
                    // Convert the provided string to a byte array.
                    byte[] toEncrypt = Encoding.UTF8.GetBytes(text);
                    Console.Write("Encrypted: ");
                    for (int i = 0; i < toEncrypt.Length; i++)
                    {
                        Console.Write(toEncrypt[i]);
                    }

                    // Write the byte array to the crypto stream.
                    cStream.Write(toEncrypt, 0, toEncrypt.Length);
                }
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                throw;
            }
        }

        public static string DecryptTextFromFile(string path, byte[] key, byte[] iv)
        {
            try
            {
                // Open the specified file
                using (FileStream fStream = File.OpenRead(path))
                // Create a new TripleDES object.
                using (TripleDES tripleDes = TripleDES.Create())
                // Create a TripleDES decryptor from the key and IV
                using (ICryptoTransform decryptor = tripleDes.CreateDecryptor(key, iv))
                // Create a CryptoStream using the FileStream and decryptor
                using (var cStream = new CryptoStream(fStream, decryptor, CryptoStreamMode.Read))
                // Create a StreamReader to turn the bytes back into text
                using (StreamReader reader = new StreamReader(cStream, Encoding.UTF8))
                {
                    // Read back all of the text from the StreamReader, which receives
                    // the decrypted bytes from the CryptoStream, which receives the
                    // encrypted bytes from the FileStream.
                    return reader.ReadToEnd();
                }
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                throw;
            }
        }
    }
}