using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FilesAndStreams
{
    public class FileManipulator
    {
        public FileManipulator ( string path )
        {
            Path = path;
        }
        public string Path { get; set; }
        public void Manipulate ( )
        {
            FileStream fs;
            while(true)
            {
                Console.WriteLine("Welcome to File Manipulator!");
                Console.WriteLine("Please enter one of these commands:");
                Console.WriteLine(" list\n clear\n appendline\n append <text>\n linecount");
                string command = Console.ReadLine();
                List<string> lines;
                switch(command)
                {
                    case "list":
                        lines = File.ReadLines(Path).ToList<string>();
                        foreach (var line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Press Any key");
                        Console.ReadKey();
                        break;
                    case "clear":
                        if(File.Exists(Path))
                        {
                            File.Delete(Path);
                        }
                        fs = File.Create(Path);
                        break;
                    case "appendline":
                        lines = File.ReadLines(Path).ToList<string>();
                        lines.Add("\n");
                        File.WriteAllLines(Path , lines.ToArray());
                        Console.WriteLine("Added an empty line...");
                        Console.ReadKey();
                        break;
                    case "linecount":
                        Console.WriteLine(File.ReadAllLines(Path).Length);
                        Console.WriteLine("Press any key to continue manipulating...");
                        Console.ReadKey();
                        break;
                    case "exit":
                        return;
                    default:
                        if(command.Contains("append "))
                        {
                            lines = File.ReadLines(Path).ToList<string>();
                            lines.Add(command.Substring(command.IndexOf(" ")));
                            File.WriteAllLines(Path , lines.ToArray());
                            Console.WriteLine("Added text \nPress any key to continue manipulating...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid operation!");
                            Console.ReadKey();
                        }
                        break;
                }
                Console.Clear();
            }
        }
    }
}
