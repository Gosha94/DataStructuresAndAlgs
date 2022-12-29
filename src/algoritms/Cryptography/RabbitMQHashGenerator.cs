using System.Text;
using System.Security.Cryptography;

namespace CustomCryptography
{
    public class RabbitMQHashGenerator
    {
       public static string GenerateHashFrom(string inputData)
        {

            var plainPasskey = inputData;
            var plainPassKeyInBytes = Encoding.UTF8.GetBytes(plainPasskey);
            
            var salt = GetSalt(32);
            var saltedPassKey = Concatenate(salt, plainPassKeyInBytes);
            var saltedPassKeyHash = SHA256.HashData(saltedPassKey);
            var result = Convert.ToBase64String(Concatenate(salt, saltedPassKeyHash));
            return result;

            //using (RandomNumberGenerator rand = RandomNumberGenerator.Create())
            //using (var sha256 = SHA256.Create())
            //{
            //    byte[] salt = new byte[4];

            //    rand.GetBytes(salt);

            //    byte[] saltedPassword = MergeByteArray(salt, Encoding.UTF8.GetBytes(inputData));
            //    byte[] saltedPasswordHash = sha256.ComputeHash(saltedPassword);

            //    return Convert.ToBase64String(MergeByteArray(salt, saltedPasswordHash));
            //}
        }

        private static byte[] GetSalt(int maximumSaltLength)
        {
            return RandomNumberGenerator.GetBytes(maximumSaltLength);
        }

        private static byte[] Concatenate(params byte[][] arrays)
        {
            byte[] result = new byte[arrays.Sum(a => a.Length)];
            int offset = 0;
            foreach (byte[] array in arrays)
            {
                System.Buffer.BlockCopy(array, 0, result, offset, array.Length);
                offset += array.Length;
            }
            return result;
        }

        //private static byte[] MergeByteArray(byte[] array1, byte[] array2)
        //{
        //    byte[] merge = new byte[array1.Length + array2.Length];
        //    array1.CopyTo(merge, 0);
        //    array2.CopyTo(merge, array1.Length);

        //    return merge;
        //}

    }
}