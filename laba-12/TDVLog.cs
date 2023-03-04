using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12
{
    public class TDVLog
    {
        FileStream? fstream = null;
        string FileName = "TDVlogfile.txt";
        public TDVLog()
        {
            try
            {
                fstream = new FileStream("TDVlogfile.txt", FileMode.OpenOrCreate);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fstream?.Close();
            }
        }
        public async void FileInput(string input)
        {
            string str = "\nDate: " + DateTime.Now + "\n";
            str += "Path: " + Path.GetFullPath(FileName) + "\n";
            str += "File Name: " + FileName + "\n";
            str += input + "\nLog End\n";
            using (fstream = new FileStream(FileName, FileMode.Append))
            {
                byte[] buffer = Encoding.Default.GetBytes(str);
                await fstream.WriteAsync(buffer, 0, buffer.Length);
            }
        }
        public async void ReadFile()
        {
            using (fstream = File.OpenRead(FileName))
            {
                byte[] buffer = new byte[fstream.Length];
                await fstream.ReadAsync(buffer, 0, buffer.Length);
                string textFromFile = Encoding.Default.GetString(buffer);
                Console.WriteLine($"Текст из файла: {textFromFile}");
            }
        }
        public async void FindInfo(string substr, bool delet = false)
        {
            using (fstream = File.OpenRead(FileName))
            {
                byte[] buffer = new byte[fstream.Length];
                await fstream.ReadAsync(buffer, 0, buffer.Length);
                string textFromFile = Encoding.Default.GetString(buffer);
                string[] lines = textFromFile.Split(new char[] { '\n' });

                bool checker = false;
                int counter = 0;
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].IndexOf("Log End") < 0 & checker == true)
                    {
                        Console.WriteLine(lines[i]);
                        continue;
                    }
                    else
                    {
                        checker = false;
                        if (delet == true)
                            lines[i] = null;
                    }
                    if (lines[i].IndexOf(substr) >= 0)
                    {
                        checker = true;
                        counter++;
                        Console.WriteLine(lines[i]);
                    }
                }

            }
        }
    }
    public class TDVDiskInfo
    {
        DriveInfo[] allDrives = null;
        public TDVDiskInfo()
        {
            allDrives = DriveInfo.GetDrives();
        }
        public string DiskInfo()
        {
            string str = "";
            foreach (DriveInfo d in allDrives)
            {
                str += "\nDisk Name: " + d?.Name +
                    "\nDrive type: " + d?.DriveType;
                if (d.IsReady)
                {
                    str += "\nVolume label: " + d?.VolumeLabel +
                    "\nFile system: " + d?.DriveFormat +
                    "\nAvailable space to current user: " + d?.AvailableFreeSpace + " byte" +
                    "\nTotal available space: " + d?.TotalFreeSpace + " byte" +
                    "\nTotal size of drive: " + d?.TotalSize + " byte";
                }
            }

            return str;
        }
    }
    public class TDVFileInfo
    {
        public string Adress(string FileName)
        {
            return "\n\n" + Path.GetFullPath(FileName);
        }
        public string FileInfo(string FileName)
        {
            FileInfo fileInf = new FileInfo(FileName);
            return
                "\nFile Name: " + FileName + "\n" +
                "File Lenght: " + fileInf.Length + "\n" +
                "File Extension: " + fileInf.Extension + "\n";
        }
        public string FileDate(string FileName)
        {
            FileInfo fileInf = new FileInfo(FileName);
            return
                "\nCreate Time: " + fileInf.CreationTime + "\n" +
                "Edit Time: " + fileInf.LastWriteTime + "\n";
        }
    }
    public class TDVDirInfo
    {
        string dirName;
        string[] FileMassive;
        public TDVDirInfo(string input)
        {
            dirName = input;
        }
        public string Amount()
        {
            int counter = 0;
            if (Directory.Exists(dirName))
            {
                FileMassive = Directory.GetFiles(dirName);
                foreach (var elem in FileMassive)
                {
                    Console.WriteLine("File: " + elem);
                    counter++;
                }
                return "\nFile Amount: " + counter.ToString() + "\n";
            }
            return Directory.Exists(dirName).ToString();
        }
        public string CreateTime()
        {
            string result = "\n";
            if (Directory.Exists(dirName))
            {
                FileMassive = Directory.GetFiles(dirName);
                foreach (var elem in FileMassive)
                {
                    FileInfo fileInf = new FileInfo(elem);
                    result += "\nFile Name: " + fileInf.Name +
                        "\nCreate Time: " + fileInf.CreationTime;
                }


                return result + "\n";
            }
            return Directory.Exists(dirName).ToString();
        }
        public string FileSubdir()
        {
            string result = "\n";
            if (Directory.Exists(dirName))
            {
                FileMassive = Directory.GetDirectories(dirName);
                foreach (var elem in FileMassive)
                {
                    result += "\nFolder Name: " + elem;
                }
                return result + "\n";
            }
            return Directory.Exists(dirName).ToString();
        }
        public string ParentDir()
        {
            if (Directory.Exists(dirName))
            {
                return "\n" + dirName;
            }
            return Directory.Exists(dirName).ToString();
        }
    }
    public class TDVFileManager
    {
        string catalog;
        public TDVFileManager(string input)
        {
            catalog = input;
        }
        public async void FileControll(string dirName)
        {
            string[] FileMassive;
            string result = "\n";
            if (Directory.Exists(dirName))
            {
                FileMassive = Directory.GetFiles(dirName);
                foreach (var elem in FileMassive)
                {
                    result += "\nFile: " + elem;
                }
                FileMassive = Directory.GetDirectories(dirName);
                foreach (var elem in FileMassive)
                {
                    result += "\nFolder Name: " + elem;
                }
                result += "\n";
            }

            string path = dirName + "\\TDVInspect";

            Directory.CreateDirectory(path);

            using (FileStream? fstream = new FileStream(path + "\\TDVdirinfo.txt", FileMode.OpenOrCreate))
            {
                byte[] buffer = Encoding.Default.GetBytes(result);
                await fstream.WriteAsync(buffer, 0, buffer.Length);
            }

            using (FileStream? fstream = File.OpenRead(path + "\\TDVdirinfo.txt"))
            {
                byte[] buffer = new byte[fstream.Length];
                await fstream.ReadAsync(buffer, 0, buffer.Length);
                string textFromFile = Encoding.Default.GetString(buffer);
                Console.WriteLine($"Текст из файла: {textFromFile}");
            }

            FileInfo fileInf = new FileInfo(path + "\\TDVdirinfo.txt");
            try
            {
                fileInf.CopyTo(path + "\\TDVdirinfo2.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nTDVFileManager Ошибка " + ex.Message);
            }

            fileInf.Delete();
        }

        public void CopyToFolder(string frompath, string topath, string format)
        {
            string fp = frompath + "\\TDVFilesCopyed\\";
            string tp = topath + "TDVFilesMoved";
            try
            {
                Directory.CreateDirectory(fp);

                if (Directory.Exists(frompath))
                {
                    foreach (var elem in Directory.GetFiles(frompath))
                    {
                        FileInfo FI = new FileInfo(elem);
                        if (FI.Extension == format)
                            try
                            {
                                FI.CopyTo(fp + FI.Name);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("\nCopyToFolder CopyTo Ошибка " + ex.Message);
                            }

                    }
                    Directory.Move(fp, tp);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nCopyToFolder Ошибка " + ex.Message);
            }
        }
        public async void Raring(string sourceFolder, string zipFile, string targetFolder)
        {
            Directory.CreateDirectory(targetFolder);
            try
            {
                ZipFile.CreateFromDirectory(sourceFolder, zipFile);
                Console.WriteLine($"Папка {sourceFolder} архивирована в файл {zipFile}");
                ZipFile.ExtractToDirectory(zipFile, targetFolder);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nRaring Ошибка " + ex.Message);
            }
        }
    }
}
