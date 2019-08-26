using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace BufferTest_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = File.Create(@"D:\test.txt");
            BufferedStream buf = new BufferedStream(file);
            StreamWriter writer = new StreamWriter(buf);

            writer.WriteLine("Some data...");
            writer.Close();

            FileStream sourse = File.OpenRead(@"D:\test.txt");
            FileStream destination = File.Create(@"D:\archive.zip");

            GZipStream compressor = new GZipStream(destination, CompressionMode.Compress);
            int theByte = sourse.ReadByte();
            while(theByte!=-1)
            {
                compressor.WriteByte((byte)theByte);
                theByte = sourse.ReadByte();

            }
            compressor.Close();

            UnZip();
        }

        public static void UnZip()
        {
            FileStream sourse = File.OpenRead(@"D:\archive.zip");
            FileStream destination = File.Create(@"D:\text_zip.txt");

            GZipStream decompressor = new GZipStream(sourse, CompressionMode.Decompress);

            int theByte = decompressor.ReadByte();
            while (theByte != -1)
            {
                destination.WriteByte((byte)theByte);
                theByte = decompressor.ReadByte();

            }
            decompressor.Close();
        }
    }
    }

