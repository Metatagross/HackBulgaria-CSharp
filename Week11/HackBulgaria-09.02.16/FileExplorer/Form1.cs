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

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        public Form1 ( )
        {
            InitializeComponent();
            tview1.Nodes.Add(new TreeNode(@"D:\"));
            foreach(string dir in Directory.GetDirectories(@"D:\"))
            {
                tview1.Nodes[0].Nodes.Add(dir);
            }
        }

        private void tview1_AfterSelect ( object sender , TreeViewEventArgs e )
        {
            lview1.Items.Clear();
            lview1.Items.Add(e.Node.Text);
            foreach(string dir in Directory.GetDirectories(e.Node.Text))
            {
                lview1.Items.Add(dir);
            }
            foreach(string file in Directory.GetFiles(e.Node.Text))
            {
                lview1.Items.Add(file);
            }
        }

        private void lview1_SelectedIndexChanged ( object sender , EventArgs e )
        {

        }

        private void lview1_DoubleClickItem(object  sender, MouseEventArgs e)
        {
            if(e.Clicks==2)
            {
                
            }
        }
        private void Form1_Load ( object sender , EventArgs e )
        {

        }
    }
}
