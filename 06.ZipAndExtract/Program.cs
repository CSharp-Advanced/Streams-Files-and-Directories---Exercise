using System;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"C:\AMD", @"C:\NewZip\Test.zip");
            ZipFile.ExtractToDirectory(@"C:NewZip\Test.zip", @"C:\Test");
        }
    }
}
