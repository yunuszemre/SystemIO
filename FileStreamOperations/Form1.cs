using System;
using System.IO;
using System.Windows.Forms;

namespace FileStreamOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string filePath;
        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            ChooseFile();
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            WriteFile();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            ReadFile();
        }
        private void WriteFile()
        {
            try
            {
                if (filePath != null)
                {
                    StreamReader sr = new StreamReader(filePath);
                    string incomingText = sr.ReadToEnd();
                    sr.Close();

                    StreamWriter sw = new StreamWriter(filePath);
                    sw.WriteLine(incomingText += txtMetin.Text, filePath);
                    txtMetin.Text = "";
                    sw.Close();
                }
                else
                {
                    throw new Exception("Dosya seçilmedi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
        private void ChooseFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Metin dosyaları |*.txt";

            var dialogResult = ofd.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                filePath = ofd.FileName;
                txtFileName.Text = ofd.FileName;
            }
        }

        private void ReadFile()
        {
            try
            {
                if (filePath != null)
                {
                    StreamReader sr = new StreamReader(filePath);
                    //sr.ReadToEnd();
                    txtMetin.Text = sr.ReadToEnd();
                    sr.Close();
                }
                else
                {
                    throw new Exception("Dosya seçilmedi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
