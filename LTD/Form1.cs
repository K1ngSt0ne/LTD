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
    public partial class MainClass : Form
    {
        public MainClass()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("HAHA");
            initCombobox();
        }


        string choosen_path; //выбранный путь до файла, без него не сможем загузрить в pictureBox
        ArrayList imglist = new ArrayList(); //храним названия наших файлов, для переключения по кнопкам
        ArrayList templateslist = new ArrayList();
        int img_index = 0; //индекс картинки, для адекватного переключения по кнопкам
        int x_loop_coordinate; //координата в picturebox по х
        int y_loop_coordinate; //координате в picturebox по y
        int x_scale = 7;
        int y_scale = 11;
        bool loop_flag = false;


        void initCombobox()
        {
            templateslist.Add("5ТЛ.");
            templateslist.Add("8ТЛ.");
            templateslist.Add("ГТЛИ.");
            templateslist.Add("0НГЮК.");
            templateslist.Add("5НГЮК.");
            templateslist.Add("8НГЮК.");
        }

        void loadCombobox()
        {
            foreach (string c in templateslist)//проходим по ключам переданного словаря
                //добавляем ключи из словаря в комбобокс (имена наших объектов )
                templates_combobox.Items.Add(c);
        }

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
                    loadCombobox();

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
        }



        private void zoom_out_Click(object sender, EventArgs e)
        {
            image_rename.Image = LoadImg(choosen_path + "\\" + imglist[img_index].ToString());
        }

        private void image_rename_Click(object sender, EventArgs e)
        {
            if (loop_flag)
            {
                var original_image = Graphics.FromImage(image_rename.Image);
                original_image.TranslateTransform(-x_loop_coordinate, -y_loop_coordinate);
                original_image.ScaleTransform(3.0F, 3.0F);
                Image zoom_img = image_rename.Image;
                Point p0 = new Point(0, 0);
                original_image.DrawImage(zoom_img, p0);
                image_rename.Image = zoom_img;
            }

        }

        private void zoom_coordinate(object sender, MouseEventArgs e)
        {
            x_loop_coordinate = e.X*x_scale;
            y_loop_coordinate = e.Y*y_scale;
        }
        //для 3.0F e.X*7; e.Y*11
        private void loop_enabled_Click(object sender, EventArgs e)
        {
            if (!loop_flag)
            {
                loop_flag = true;
                a4_scale.Enabled = true;
                a3_scale.Enabled = true;
                a2_scale.Enabled = true;
                a1_scale.Enabled = true;
                zoom_out.Enabled = true;
            }
            else
            {
                loop_flag = false;
                a4_scale.Enabled = false;
                a3_scale.Enabled = false;
                a2_scale.Enabled = false;
                a1_scale.Enabled = false;
                zoom_out.Enabled = false;
            }
        }

        private void a4_scale_CheckedChanged(object sender, EventArgs e)
        {
            x_scale = 7;
            y_scale = 11;
        }

        private void a3_scale_CheckedChanged(object sender, EventArgs e)
        {
            x_scale = 16;
            y_scale = 11;
        }

        private void a2_scale_CheckedChanged(object sender, EventArgs e)
        {
            x_scale = 24;
            y_scale = 11;
        }

        private void a1_scale_CheckedChanged(object sender, EventArgs e)
        {
            x_scale = 32;
            y_scale = 21;
        }



        private void added_templates_Click(object sender, EventArgs e)
        {
            string new_templates = templates_combobox.Text;
            if (checkSameTemplates(new_templates))
            {
                templateslist.Add(new_templates);
                MessageBox.Show("Успешно!", "Сообщение");
                templates_combobox.Text = "";
                templates_combobox.Items.Clear();
                loadCombobox();
            }
            else
            {
                MessageBox.Show("Такой шаблон уже существует!", "Предупреждение");
            }

        }

        private void choose_templates_Click(object sender, EventArgs e)
        {
            string selected_templates = Convert.ToString(templates_combobox.SelectedItem);
            rename_file_textbox.Text = selected_templates;
        }

        bool checkSameTemplates(string new_temp)
        {
            foreach (string c in templateslist)
            {
                if (c == new_temp)
                    return false;
            }
            return true;
        }
    }
}
