
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.previous_image = new System.Windows.Forms.Button();
            this.opennewwindow = new System.Windows.Forms.Button();
            this.next_image = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LTD.Properties.Resources._0НГЮК_250_009_Данные_электрические_на_ас__двигатель_типа_АОД_630_4У1_;
            this.pictureBox1.Location = new System.Drawing.Point(46, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 690);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // previous_image
            // 
            this.previous_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previous_image.Location = new System.Drawing.Point(46, 729);
            this.previous_image.Name = "previous_image";
            this.previous_image.Size = new System.Drawing.Size(156, 68);
            this.previous_image.TabIndex = 1;
            this.previous_image.Text = "Предущее изображение";
            this.previous_image.UseVisualStyleBackColor = true;
            // 
            // opennewwindow
            // 
            this.opennewwindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opennewwindow.Location = new System.Drawing.Point(257, 729);
            this.opennewwindow.Name = "opennewwindow";
            this.opennewwindow.Size = new System.Drawing.Size(158, 68);
            this.opennewwindow.TabIndex = 2;
            this.opennewwindow.Text = "Открыть в новом окне";
            this.opennewwindow.UseVisualStyleBackColor = true;
            // 
            // next_image
            // 
            this.next_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next_image.Location = new System.Drawing.Point(475, 729);
            this.next_image.Name = "next_image";
            this.next_image.Size = new System.Drawing.Size(151, 68);
            this.next_image.TabIndex = 3;
            this.next_image.Text = "Следующее изображение";
            this.next_image.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 821);
            this.Controls.Add(this.next_image);
            this.Controls.Add(this.opennewwindow);
            this.Controls.Add(this.previous_image);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button previous_image;
        private System.Windows.Forms.Button opennewwindow;
        private System.Windows.Forms.Button next_image;
    }
}

