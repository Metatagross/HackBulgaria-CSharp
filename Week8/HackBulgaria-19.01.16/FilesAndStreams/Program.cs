using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesAndStreams
{
    class Program
    {
        public static void CopyUpperTxt ( string path )
        {
            using(StreamReader sr = File.OpenText(path))
            {
                using(StreamWriter sw = new StreamWriter(path.Insert(path.LastIndexOf('.') , "UpperCopy")))
                {
                    string line = sr.ReadLine();
                    while(line != null)
                    {
                        sw.WriteLine(line.ToUpper());
                        line = sr.ReadLine();
                    }
                }
            }
        }
        public static void CopyDir ( string directory , string destination , bool isRecursive )
        {
            DirectoryInfo dest = new DirectoryInfo(destination);
            DirectoryInfo dir = new DirectoryInfo(directory);
            DirectoryInfo destDir = dest.CreateSubdirectory(dir.Name);
            foreach(var item in dir.GetFiles())
            {
                item.CopyTo(Path.Combine(destDir.FullName , item.Name));
            }
            if(isRecursive)
            {

                foreach(var item in dir.GetDirectories())
                {
                    CopyDir(item.FullName , destDir.FullName , isRecursive);
                }
            }
        }
        public static Dictionary<string , int> GetFileNamesInDirectory ( string path , Dictionary<string , int> archive )
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach(var item in dir.GetFiles())
            {
                if(!archive.Keys.Contains("File: " + item.ToString()))
                {
                    archive.Add("File: " + item.ToString() , 1);
                }
                else
                {
                    archive["File: " + item.ToString()]++;
                }
            }
            foreach(var item in dir.GetDirectories())
            {
                if(!archive.Keys.Contains("Dir: " + item.ToString()))
                {
                    archive.Add("Dir: " + item.ToString() , 1);
                }
                else
                {
                    archive["Dir " + item.ToString()]++;
                }
                GetFileNamesInDirectory(item.FullName , archive);
            }
            return archive;
        }

        public static void FixEncoding ( string path )
        {
            if (File.Exists(path))
            {
                string encoded = Path.Combine(Path.GetDirectoryName(path),
                    Path.GetFileNameWithoutExtension(path) + "Encoded" + Path.GetExtension(path));

                string textToEncode = File.ReadAllText(path, Encoding.GetEncoding(1251));

                File.WriteAllText(encoded, textToEncode, Encoding.UTF8);
            }
            else
            {
                Console.WriteLine("Invalid path!");
            }
        }
        static void Main ( string[] args )
        {
            string pathDirs = Console.ReadLine();
            while(!File.Exists(pathDirs))
            {
                Console.WriteLine("Wrong filename!");
                pathDirs = Console.ReadLine();
            }
            Dictionary<string , int> archive = GetFileNamesInDirectory(pathDirs , new Dictionary<string , int>());
            foreach(var item in archive)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            string encoded = Console.ReadLine();
            while(!File.Exists(encoded))
            {
                Console.WriteLine("Wrong filename!");
                encoded = Console.ReadLine();
            }
            FixEncoding(encoded);
            string pathToCopy = Console.ReadLine();
            while(!Directory.Exists(pathDirs))
            {
                Console.WriteLine("Wrong folder name!");
                pathDirs = Console.ReadLine();
            }
            string dest = Console.ReadLine();
            while(!Directory.Exists(pathDirs))
            {
                Console.WriteLine("Wrong folder name!");
                dest = Console.ReadLine();
            }
            CopyDir(pathToCopy, dest , true);
            CopyUpperTxt(@"D:\Artpop.txt");
            FileManipulator fm= new FileManipulator(@"D:\Artpop.txt");
            fm.Manipulate();
            Console.ReadKey();
        }
    }
}
