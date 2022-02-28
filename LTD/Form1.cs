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
using System.Drawing.Drawing2D;//меняем картинку
using System.Drawing.Imaging;//меняем картинку

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


        string choosen_path; //выбранный путь до файла, без него не сможем загузрить в pictureBox
        ArrayList imglist = new ArrayList(); //храним названия наших файлов, для переключения по кнопкам
        int img_index = 0; //индекс картинки, для адекватного переключения по кнопкам
        int x_loop_coordinate; //координата в picturebox по х
        int y_loop_coordinate; //координате в picturebox по y


        private void find_directoty_path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(FBD.SelectedPath);
                DirectoryInfo dir = new DirectoryInfo(FBD.SelectedPath);
                choosen_path=dir.ToString();
                FileInfo[] files = dir.GetFiles("*.jpg");
                foreach (FileInfo fi in files)
                {
                    list_of_files.Items.Add(fi.ToString());
                    imglist.Add(fi.ToString());
                }
                if (imglist.Count > 0)
                {                    
                    image_rename.Image = LoadImg(choosen_path + "\\" + imglist[img_index].ToString());

                }
                   
            }
            
        }

        private void list_of_files_SelectedIndexChanged(object sender, EventArgs e)
        {
            //у выбранного элепмента будет индекс. По нему можно узнать куда переключаться. По умолчанию индекс будет 0
            img_index = list_of_files.SelectedIndex;
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

        private void next_image_Click(object sender, EventArgs e)
        {
            if (img_index + 1 > imglist.Count - 1)
            {
                img_index = 0;
                image_rename.Image = LoadImg(choosen_path + "\\" + imglist[img_index].ToString());
            }
            else
            {
                img_index = img_index + 1;
                image_rename.Image = LoadImg(choosen_path + "\\" + imglist[img_index].ToString());
            }

        }

        private void previous_image_Click(object sender, EventArgs e)
        {
            if (img_index - 1 < 0)
            {
                img_index = imglist.Count-1;
                image_rename.Image = LoadImg(choosen_path + "\\" + imglist[img_index].ToString());
            }
            else
            {
                img_index = img_index - 1;
                image_rename.Image = LoadImg(choosen_path + "\\" + imglist[img_index].ToString());
            }

        }

        private void five_tl_button_Click(object sender, EventArgs e)
        {
            rename_file_textbox.Text = "5ТЛ.";
        }

        private void clear_text_box_Click(object sender, EventArgs e)
        {
            rename_file_textbox.Text = "";
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reverse_button_Click(object sender, EventArgs e)
        {
            Image new_img = image_rename.Image;
            new_img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            image_rename.Image = new_img;
           // image_rename.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
           // image_rename.Save(output, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void zoom_in_Click(object sender, EventArgs e)
        {
            var original_image = Graphics.FromImage(image_rename.Image);
            original_image.TranslateTransform(-4000, -6500);
            original_image.ScaleTransform(3.0F, 3.0F);
            Image zoom_img=image_rename.Image;
            Point p0 = new Point(0,0);
            original_image.DrawImage(zoom_img, p0);
            image_rename.Image = zoom_img;
        }

        private void zoom_out_Click(object sender, EventArgs e)
        {
            image_rename.Image = LoadImg(choosen_path + "\\" + imglist[img_index].ToString());
        }



        private void opennewwindow_Click(object sender, EventArgs e)
        {

        }

        private void image_rename_Click(object sender, EventArgs e)
        {
            var original_image = Graphics.FromImage(image_rename.Image);
            original_image.TranslateTransform(-x_loop_coordinate, -y_loop_coordinate);
            original_image.ScaleTransform(3.0F, 3.0F);
            Image zoom_img = image_rename.Image;
            Point p0 = new Point(0, 0);
            original_image.DrawImage(zoom_img, p0);
            image_rename.Image = zoom_img;
        }

        private void zoom_coordinate(object sender, MouseEventArgs e)
        {
            x_loop_coordinate = e.X*7;
            y_loop_coordinate = e.Y*11;
        }
    }
}
