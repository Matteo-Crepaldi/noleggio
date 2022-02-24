using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace noleggio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string GetDirPath()
        {
            string path, dirPath = "";
            string[] args;

            path = Directory.GetCurrentDirectory();
            args = path.Split('\\');
            
            for (int K = 0; K < args.Length - 3; K++) dirPath += $"{args[K]}\\";
            
            return dirPath + "files\\";
        }
    }
}
