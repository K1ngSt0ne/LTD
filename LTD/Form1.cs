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
using System.Collections;

namespace LTD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("HAHA");
        }
        string choosen_path;
        ArrayList imglist = new ArrayList();
        private void find_directoty_path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(FBD.SelectedPath);
                DirectoryInfo dir = new DirectoryInfo(FBD.SelectedPath);
                choosen_path=dir.ToString();
                FileInfo[] files = dir.GetFiles("*.jpg");
                foreach (FileInfo fi in files)
                {
                    list_of_files.Items.Add(fi.ToString());
                    imglist.Add(fi.ToString());
                }
                if (imglist.Count>0)
                    image_rename.Image=LoadImg(choosen_path + "\\" + imglist[0].ToString());
            }
        }

        private void list_of_files_SelectedIndexChanged(object sender, EventArgs e)
        {
            //у выбранного элепмента будет индекс. По нему можно узнать куда переключаться. По умолчанию индекс будет 0
            string selectedImage = choosen_path+ "\\" + list_of_files.SelectedItem.ToString();
            image_rename.Image = LoadImg(selectedImage);
        }
        private Image LoadImg(string image_name)
        {
            Image res = new Bitmap(1, 1);
            // если файл существует
            if (File.Exists(image_name))
            {
                // то загружаем из него картинку
                res = Image.FromFile(image_name);
            }
            return res;
        }
    }
}
