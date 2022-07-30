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
using SystemIO;

namespace SystemIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDriverInfo_Click(object sender, EventArgs e)
        {
            //Sürücü bilgilerini sunan class'tır
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo item in drives)
            {
                MessageBox.Show(item.TotalSize.ToString());
                MessageBox.Show($"{item.VolumeLabel}");
                MessageBox.Show(item.RootDirectory.FullName);

                //Örn: Kurulum esnasında x.xGb alana ihtiyacınız var diskinizde y.yGb kadar alan bulunuyor.
            }

        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            //Directory
            if (Directory.Exists(@"C:\\Hs6Ornek"))
            {
                Directory.Delete(@"C:\\Hs6Ornek");//---> Klasör boş ise siler
            }
            else
            {
                Directory.CreateDirectory(@"C:\\Hs6Ornek");
            }

            
        }

        private void btnGetDirectories_Click(object sender, EventArgs e)
        {
            string[] directories = Directory.GetDirectories(@"C:\\Hs6Ornek");
            foreach (string item in directories)
            {
                MessageBox.Show($"{item}");
            }
        }

        private void btnGetFiles_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(@"C:\\Hs6Ornek");
            foreach (string file in files)
            {
                MessageBox.Show(file);
            }
        }

        private void btnMoveDir_Click(object sender, EventArgs e)
        {
            string sourcePath = @"C:\\Hs6Ornek";
            string defPath = @"C:\\newPath";
            Directory.Move(sourcePath, defPath);
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            FileStream fs = File.Create(@"C:\\Hs6Ornek\\OrnekMetin.txt");

            string name = fs.Name;
            //MessageBox.Show(name);
            Byte[] yazdirilacakMetin = new UTF8Encoding(true).GetBytes("Dosyanın içine metin yazdırdım");
            fs.Write(yazdirilacakMetin, 0, yazdirilacakMetin.Length);
            fs.Close();

        }
    }
}
