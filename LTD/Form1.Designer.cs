
namespace LTD
{
    partial class MainClass
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.previous_image = new System.Windows.Forms.Button();
            this.next_image = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.list_of_files = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.find_directoty_path = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rename_file_textbox = new System.Windows.Forms.TextBox();
            this.rename_file = new System.Windows.Forms.Button();
            this.clear_text_box = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.zoom_out = new System.Windows.Forms.Button();
            this.reverse_button = new System.Windows.Forms.Button();
            this.image_rename = new System.Windows.Forms.PictureBox();
            this.loop_enabled = new System.Windows.Forms.Button();
            this.a4_scale = new System.Windows.Forms.RadioButton();
            this.a3_scale = new System.Windows.Forms.RadioButton();
            this.a2_scale = new System.Windows.Forms.RadioButton();
            this.a1_scale = new System.Windows.Forms.RadioButton();
            this.added_templates = new System.Windows.Forms.Button();
            this.templates_combobox = new System.Windows.Forms.ComboBox();
            this.choose_templates = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image_rename)).BeginInit();
            this.SuspendLayout();
            // 
            // previous_image
            // 
            this.previous_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previous_image.Location = new System.Drawing.Point(46, 788);
            this.previous_image.Name = "previous_image";
            this.previous_image.Size = new System.Drawing.Size(69, 68);
            this.previous_image.TabIndex = 1;
            this.previous_image.Text = "<";
            this.previous_image.UseVisualStyleBackColor = true;
            this.previous_image.Click += new System.EventHandler(this.previous_image_Click);
            // 
            // next_image
            // 
            this.next_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next_image.Location = new System.Drawing.Point(635, 789);
            this.next_image.Name = "next_image";
            this.next_image.Size = new System.Drawing.Size(69, 68);
            this.next_image.TabIndex = 3;
            this.next_image.Text = ">";
            this.next_image.UseVisualStyleBackColor = true;
            this.next_image.Click += new System.EventHandler(this.next_image_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_button.Location = new System.Drawing.Point(1183, 796);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(140, 68);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // list_of_files
            // 
            this.list_of_files.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_of_files.FormattingEnabled = true;
            this.list_of_files.ItemHeight = 24;
            this.list_of_files.Location = new System.Drawing.Point(735, 23);
            this.list_of_files.Name = "list_of_files";
            this.list_of_files.Size = new System.Drawing.Size(382, 196);
            this.list_of_files.TabIndex = 5;
            this.list_of_files.SelectedIndexChanged += new System.EventHandler(this.list_of_files_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1126, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите директорию";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1179, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "для работы";
            // 
            // find_directoty_path
            // 
            this.find_directoty_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_directoty_path.Location = new System.Drawing.Point(1166, 114);
            this.find_directoty_path.Name = "find_directoty_path";
            this.find_directoty_path.Size = new System.Drawing.Size(150, 37);
            this.find_directoty_path.TabIndex = 8;
            this.find_directoty_path.Text = "Обзор...";
            this.find_directoty_path.UseVisualStyleBackColor = true;
            this.find_directoty_path.Click += new System.EventHandler(this.find_directoty_path_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(906, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Введите новое имя файла...";
            // 
            // rename_file_textbox
            // 
            this.rename_file_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rename_file_textbox.Location = new System.Drawing.Point(735, 365);
            this.rename_file_textbox.Name = "rename_file_textbox";
            this.rename_file_textbox.Size = new System.Drawing.Size(607, 29);
            this.rename_file_textbox.TabIndex = 10;
            // 
            // rename_file
            // 
            this.rename_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rename_file.Location = new System.Drawing.Point(1166, 411);
            this.rename_file.Name = "rename_file";
            this.rename_file.Size = new System.Drawing.Size(176, 54);
            this.rename_file.TabIndex = 11;
            this.rename_file.Text = "Переименовать";
            this.rename_file.UseVisualStyleBackColor = true;
            // 
            // clear_text_box
            // 
            this.clear_text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_text_box.Location = new System.Drawing.Point(1000, 411);
            this.clear_text_box.Name = "clear_text_box";
            this.clear_text_box.Size = new System.Drawing.Size(143, 54);
            this.clear_text_box.TabIndex = 12;
            this.clear_text_box.Text = "Очистить";
            this.clear_text_box.UseVisualStyleBackColor = true;
            this.clear_text_box.Click += new System.EventHandler(this.clear_text_box_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(748, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Шаблоны";
            // 
            // zoom_out
            // 
            this.zoom_out.Enabled = false;
            this.zoom_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zoom_out.Location = new System.Drawing.Point(560, 788);
            this.zoom_out.Name = "zoom_out";
            this.zoom_out.Size = new System.Drawing.Size(69, 68);
            this.zoom_out.TabIndex = 17;
            this.zoom_out.Text = "-";
            this.zoom_out.UseVisualStyleBackColor = true;
            this.zoom_out.Click += new System.EventHandler(this.zoom_out_Click);
            // 
            // reverse_button
            // 
            this.reverse_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reverse_button.Location = new System.Drawing.Point(121, 789);
            this.reverse_button.Name = "reverse_button";
            this.reverse_button.Size = new System.Drawing.Size(70, 68);
            this.reverse_button.TabIndex = 15;
            this.reverse_button.Text = "↺";
            this.reverse_button.UseVisualStyleBackColor = true;
            this.reverse_button.Click += new System.EventHandler(this.reverse_button_Click);
            // 
            // image_rename
            // 
            this.image_rename.Location = new System.Drawing.Point(46, 23);
            this.image_rename.Name = "image_rename";
            this.image_rename.Size = new System.Drawing.Size(658, 749);
            this.image_rename.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_rename.TabIndex = 0;
            this.image_rename.TabStop = false;
            this.image_rename.Click += new System.EventHandler(this.image_rename_Click);
            this.image_rename.MouseMove += new System.Windows.Forms.MouseEventHandler(this.zoom_coordinate);
            // 
            // loop_enabled
            // 
            this.loop_enabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loop_enabled.Location = new System.Drawing.Point(197, 790);
            this.loop_enabled.Name = "loop_enabled";
            this.loop_enabled.Size = new System.Drawing.Size(70, 66);
            this.loop_enabled.TabIndex = 19;
            this.loop_enabled.Text = "🔍";
            this.loop_enabled.UseVisualStyleBackColor = true;
            this.loop_enabled.Click += new System.EventHandler(this.loop_enabled_Click);
            // 
            // a4_scale
            // 
            this.a4_scale.AutoSize = true;
            this.a4_scale.Enabled = false;
            this.a4_scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a4_scale.Location = new System.Drawing.Point(290, 788);
            this.a4_scale.Name = "a4_scale";
            this.a4_scale.Size = new System.Drawing.Size(82, 46);
            this.a4_scale.TabIndex = 20;
            this.a4_scale.TabStop = true;
            this.a4_scale.Text = "А4";
            this.a4_scale.UseVisualStyleBackColor = true;
            this.a4_scale.CheckedChanged += new System.EventHandler(this.a4_scale_CheckedChanged);
            // 
            // a3_scale
            // 
            this.a3_scale.AutoSize = true;
            this.a3_scale.Enabled = false;
            this.a3_scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a3_scale.Location = new System.Drawing.Point(378, 790);
            this.a3_scale.Name = "a3_scale";
            this.a3_scale.Size = new System.Drawing.Size(82, 46);
            this.a3_scale.TabIndex = 21;
            this.a3_scale.TabStop = true;
            this.a3_scale.Text = "А3";
            this.a3_scale.UseVisualStyleBackColor = true;
            this.a3_scale.CheckedChanged += new System.EventHandler(this.a3_scale_CheckedChanged);
            // 
            // a2_scale
            // 
            this.a2_scale.AutoSize = true;
            this.a2_scale.Enabled = false;
            this.a2_scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2_scale.Location = new System.Drawing.Point(290, 840);
            this.a2_scale.Name = "a2_scale";
            this.a2_scale.Size = new System.Drawing.Size(82, 46);
            this.a2_scale.TabIndex = 22;
            this.a2_scale.TabStop = true;
            this.a2_scale.Text = "А2";
            this.a2_scale.UseVisualStyleBackColor = true;
            this.a2_scale.CheckedChanged += new System.EventHandler(this.a2_scale_CheckedChanged);
            // 
            // a1_scale
            // 
            this.a1_scale.AutoSize = true;
            this.a1_scale.Enabled = false;
            this.a1_scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1_scale.Location = new System.Drawing.Point(378, 840);
            this.a1_scale.Name = "a1_scale";
            this.a1_scale.Size = new System.Drawing.Size(82, 46);
            this.a1_scale.TabIndex = 23;
            this.a1_scale.TabStop = true;
            this.a1_scale.Text = "А1";
            this.a1_scale.UseVisualStyleBackColor = true;
            this.a1_scale.CheckedChanged += new System.EventHandler(this.a1_scale_CheckedChanged);
            // 
            // added_templates
            // 
            this.added_templates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.added_templates.Location = new System.Drawing.Point(1047, 515);
            this.added_templates.Name = "added_templates";
            this.added_templates.Size = new System.Drawing.Size(245, 33);
            this.added_templates.TabIndex = 24;
            this.added_templates.Text = "Добавить шаблон";
            this.added_templates.UseVisualStyleBackColor = true;
            this.added_templates.Click += new System.EventHandler(this.added_templates_Click);
            // 
            // templates_combobox
            // 
            this.templates_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.templates_combobox.FormattingEnabled = true;
            this.templates_combobox.Location = new System.Drawing.Point(752, 515);
            this.templates_combobox.Name = "templates_combobox";
            this.templates_combobox.Size = new System.Drawing.Size(289, 33);
            this.templates_combobox.TabIndex = 25;
            // 
            // choose_templates
            // 
            this.choose_templates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose_templates.Location = new System.Drawing.Point(1047, 563);
            this.choose_templates.Name = "choose_templates";
            this.choose_templates.Size = new System.Drawing.Size(245, 33);
            this.choose_templates.TabIndex = 26;
            this.choose_templates.Text = "Выбрать шаблон";
            this.choose_templates.UseVisualStyleBackColor = true;
            this.choose_templates.Click += new System.EventHandler(this.choose_templates_Click);
            // 
            // MainClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 885);
            this.Controls.Add(this.choose_templates);
            this.Controls.Add(this.templates_combobox);
            this.Controls.Add(this.added_templates);
            this.Controls.Add(this.a1_scale);
            this.Controls.Add(this.a2_scale);
            this.Controls.Add(this.a3_scale);
            this.Controls.Add(this.a4_scale);
            this.Controls.Add(this.loop_enabled);
            this.Controls.Add(this.zoom_out);
            this.Controls.Add(this.reverse_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clear_text_box);
            this.Controls.Add(this.rename_file);
            this.Controls.Add(this.rename_file_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.find_directoty_path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_of_files);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.next_image);
            this.Controls.Add(this.previous_image);
            this.Controls.Add(this.image_rename);
            this.Name = "MainClass";
            this.Text = "Архив технической документации";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_rename)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image_rename;
        private System.Windows.Forms.Button previous_image;
        private System.Windows.Forms.Button next_image;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.ListBox list_of_files;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button find_directoty_path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rename_file_textbox;
        private System.Windows.Forms.Button rename_file;
        private System.Windows.Forms.Button clear_text_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reverse_button;
        private System.Windows.Forms.Button zoom_out;
        private System.Windows.Forms.Button loop_enabled;
        private System.Windows.Forms.RadioButton a4_scale;
        private System.Windows.Forms.RadioButton a3_scale;
        private System.Windows.Forms.RadioButton a2_scale;
        private System.Windows.Forms.RadioButton a1_scale;
        private System.Windows.Forms.Button added_templates;
        private System.Windows.Forms.ComboBox templates_combobox;
        private System.Windows.Forms.Button choose_templates;
    }
}

