using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream readImage = 
                new FileStream("../../../copyMe.png", FileMode.Open);
            using FileStream copyImage = 
                new FileStream("../../../copyImage.png", FileMode.Create);

            while (true)
            {
                byte[] buffer = new byte[4096];
                int read = readImage.Read(buffer, 0, buffer.Length);

                if (read == 0)
                {
                    break;
                }

                copyImage.Write(buffer);
            }
        }
    }
}
