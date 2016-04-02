using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCorrectPad
{
    public partial class Form1 : Form
    {
        public Form1 ( )
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged ( object sender , EventArgs e )
        {
            if(Char.IsWhiteSpace(textBox1.Text.Last()))
            {
                string[] words = textBox1.Text.Split(new char[] { ' ' , '\r' , '\t' , '\n' } , StringSplitOptions.RemoveEmptyEntries);
                string lastWord = Find(words[words.Length - 1]);
                textBox1.Text = textBox1.Text.Replace(words[words.Length - 1] , lastWord);
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        private string Find ( string word )
        {
            string path = @"C:\Users\User\Documents\Visual Studio 2015\Projects\HackBulgaria-09.02.16\AutoCorrectPad\Dictionary\wordsEn.txt";
            int counter = 0;
            string line;
            string searchedLine = string.Empty;

            using(StreamReader sr = new StreamReader(path))
            {
                while((line = sr.ReadLine()) != null)
                {
                    if(word.Equals(line))
                    {
                        return line;
                    }
                }
            }

            using(StreamReader sr = new StreamReader(path))
            {
                while((line = sr.ReadLine()) != null)
                {
                    if(line.Contains(word))
                    {
                        return line;
                    }
                    else
                    {
                        int wordCounter = 0;
                        for(int i = 0 ; i < (line.Length < word.Length ? line.Length : word.Length) ; i++)
                        {
                            //||(line.Contains(word[i])&&line[0]==word[0])
                            if(word[i] == line[i])
                            {
                                wordCounter++;
                            }
                        }
                        if(wordCounter == word.Length)
                        {
                            return line;
                        }
                        if(wordCounter > counter)
                        {
                            counter = wordCounter;
                            searchedLine = line;
                        }
                    }
                }
                return searchedLine;
            }
        }
    }
}
