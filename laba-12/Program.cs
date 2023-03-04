using System;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Text;
using System.Reflection;
using System.Collections.Specialized;
using System.Diagnostics.Metrics;
using System.IO.Compression;
using System.Data.SqlTypes;

namespace laba12
{    public static class Program
    {
        static void Main()
        {
            string fn = "TDVlogfile.txt";
            TDVLog Log = new TDVLog();
            TDVDiskInfo DF = new TDVDiskInfo();
            TDVFileInfo FI = new TDVFileInfo();
            TDVDirInfo DI = new TDVDirInfo(Directory.GetCurrentDirectory());
            Log.FileInput(
                DF.DiskInfo() + FI.Adress(fn) +
                FI.FileInfo(fn) + FI.FileDate(fn) +
                DI.Amount() + DI.CreateTime() +
                DI.FileSubdir() + DI.ParentDir()
                );
            TDVFileManager FM = new TDVFileManager(Directory.GetCurrentDirectory());
            FM.FileControll(Directory.GetCurrentDirectory());

            string path1 = Directory.GetCurrentDirectory();
            string path2 = Directory.GetCurrentDirectory() + "\\Inspect\\";

            FM.CopyToFolder(path1, path2, ".txt");

            Log.FindInfo("Date: 14.11.2022 12:08:12");

            FM.Raring("TDVInspect", "TDV.zip", "UnraringFiles");
        }
    }
}