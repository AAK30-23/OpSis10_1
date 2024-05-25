using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;



namespace OpSis10_1
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void OpenFile()
        {
            string filePath = txtFilePath.Text;

            if (System.IO.File.Exists(filePath))
            {
                Process process = new Process();
                //имя исполняемого файла
                process.StartInfo.FileName = "notepad.exe";
                process.StartInfo.Arguments = filePath;
                // процесс должен быть взаимодействующим
                process.StartInfo.UseShellExecute = true;
                process.Start();
            }
            else
            {
                MessageBox.Show("Файл не найден.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

