
namespace LTD
{
    partial class Form1
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
            this.image_rename = new System.Windows.Forms.PictureBox();
            this.previous_image = new System.Windows.Forms.Button();
            this.opennewwindow = new System.Windows.Forms.Button();
            this.next_image = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.list_of_files = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.find_directoty_path = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image_rename)).BeginInit();
            this.SuspendLayout();
            // 
            // image_rename
            // 
            this.image_rename.Location = new System.Drawing.Point(46, 23);
            this.image_rename.Name = "image_rename";
            this.image_rename.Size = new System.Drawing.Size(658, 749);
            this.image_rename.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_rename.TabIndex = 0;
            this.image_rename.TabStop = false;
            // 
            // previous_image
            // 
            this.previous_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previous_image.Location = new System.Drawing.Point(79, 796);
            this.previous_image.Name = "previous_image";
            this.previous_image.Size = new System.Drawing.Size(156, 68);
            this.previous_image.TabIndex = 1;
            this.previous_image.Text = "Предущее изображение";
            this.previous_image.UseVisualStyleBackColor = true;
            this.previous_image.Click += new System.EventHandler(this.previous_image_Click);
            // 
            // opennewwindow
            // 
            this.opennewwindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opennewwindow.Location = new System.Drawing.Point(304, 796);
            this.opennewwindow.Name = "opennewwindow";
            this.opennewwindow.Size = new System.Drawing.Size(158, 68);
            this.opennewwindow.TabIndex = 2;
            this.opennewwindow.Text = "Открыть в новом окне";
            this.opennewwindow.UseVisualStyleBackColor = true;
            // 
            // next_image
            // 
            this.next_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next_image.Location = new System.Drawing.Point(525, 796);
            this.next_image.Name = "next_image";
            this.next_image.Size = new System.Drawing.Size(151, 68);
            this.next_image.TabIndex = 3;
            this.next_image.Text = "Следующее изображение";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 885);
            this.Controls.Add(this.find_directoty_path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_of_files);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.next_image);
            this.Controls.Add(this.opennewwindow);
            this.Controls.Add(this.previous_image);
            this.Controls.Add(this.image_rename);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_rename)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image_rename;
        private System.Windows.Forms.Button previous_image;
        private System.Windows.Forms.Button opennewwindow;
        private System.Windows.Forms.Button next_image;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.ListBox list_of_files;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button find_directoty_path;
    }
}

