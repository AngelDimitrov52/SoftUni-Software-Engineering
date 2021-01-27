using System;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            using ZipArchive zip = ZipFile.Open("../../../zip.zip", ZipArchiveMode.Create);
            ZipArchiveEntry zipEntry = zip.CreateEntryFromFile("../../../copyMe.png",
                "pic.png");
        }

    }
}
