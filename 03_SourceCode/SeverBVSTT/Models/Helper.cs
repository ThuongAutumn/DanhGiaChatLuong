using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SeverBVSTT.Models
{
    public class Helper
    {
        public static long RandomLong()
        {
            Random rand = new Random();
            long a = rand.Next();
            long b = rand.Next();
            return a * b;
        }

        public static byte[] Hash(string id_chinhanh, string ten)
        {

            return Helper.Hash(id_chinhanh + ten);
        }
        

        public static byte[] Hash(string plaintext)
        {
            //thuật toán băm
            HashAlgorithm algorithm = SHA512.Create();
            return algorithm.ComputeHash(Encoding.ASCII.GetBytes(plaintext));
        }
    }
}
