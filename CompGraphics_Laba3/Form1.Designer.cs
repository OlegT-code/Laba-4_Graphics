using System;

namespace CompGraphics_Laba3
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
            this.InFile = new System.Windows.Forms.Button();
            this.ShowText = new System.Windows.Forms.Button();
            this.ClearFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1157, 483);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // InFile
            // 
            this.InFile.Location = new System.Drawing.Point(110, 529);
            this.InFile.Name = "InFile";
            this.InFile.Size = new System.Drawing.Size(138, 50);
            this.InFile.TabIndex = 1;
            this.InFile.Text = "Записать в файл";
            this.InFile.UseVisualStyleBackColor = true;
            this.InFile.Click += new System.EventHandler(this.InFile_Click_1);
            // 
            // ShowText
            // 
            this.ShowText.Location = new System.Drawing.Point(532, 529);
            this.ShowText.Name = "ShowText";
            this.ShowText.Size = new System.Drawing.Size(112, 50);
            this.ShowText.TabIndex = 2;
            this.ShowText.Text = "Отображение";
            this.ShowText.UseVisualStyleBackColor = true;
            this.ShowText.Click += new System.EventHandler(this.ShowText_Click_1);
            // 
            // ClearFile
            // 
            this.ClearFile.Location = new System.Drawing.Point(968, 529);
            this.ClearFile.Name = "ClearFile";
            this.ClearFile.Size = new System.Drawing.Size(100, 50);
            this.ClearFile.TabIndex = 3;
            this.ClearFile.Text = "Очистка";
            this.ClearFile.UseVisualStyleBackColor = true;
            this.ClearFile.Click += new System.EventHandler(this.ClearFile_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.ClearFile);
            this.Controls.Add(this.ShowText);
            this.Controls.Add(this.InFile);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button InFile;
        private System.Windows.Forms.Button ShowText;
        private System.Windows.Forms.Button ClearFile;
    }
}

