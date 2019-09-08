using System;
using System.Diagnostics;
using System.Text;
using RGR_securitySystem.Crypt.AES;
using RGR_securitySystem.Crypt.ThresholdDecoder;

namespace RGR_securitySystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*AES aes = new AES();

            byte[] result = new byte[128];
            byte[] resultDecrypt = new byte[128];
            
            aes.Encrypt("Hello", ref result);
            aes.Decrypt(result, ref resultDecrypt);
            
            Console.WriteLine(Encoding.UTF8.GetString(result));
            Console.WriteLine(Encoding.UTF8.GetString(resultDecrypt));*/
            
            ThresholdDecoder thresholdDecoder = new ThresholdDecoder();

            foreach (var node in thresholdDecoder.Encode(new byte[]{0,1,1,1,0,1,1,0,1,1,0,1,1}))
            {
                Console.Write(node);
            }
        }
    }
}