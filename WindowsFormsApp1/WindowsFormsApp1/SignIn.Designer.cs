﻿namespace WindowsFormsApp1
{
    partial class Home
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userControl31 = new WindowsFormsApp1.LoginStud();
            this.loginComp1 = new WindowsFormsApp1.LoginComp();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(140, 134);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.button1.Size = new System.Drawing.Size(140, 140);
            this.button1.TabIndex = 0;
            this.button1.Text = "Студент";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(326, 134);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.button2.Size = new System.Drawing.Size(140, 140);
            this.button2.TabIndex = 0;
            this.button2.Text = "Компания";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(217, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кто Вы?";
            // 
            // userControl31
            // 
            this.userControl31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userControl31.Location = new System.Drawing.Point(140, 121);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(336, 192);
            this.userControl31.TabIndex = 2;
            this.userControl31.Load += new System.EventHandler(this.userControl31_Load);
            // 
            // loginComp1
            // 
            this.loginComp1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loginComp1.Location = new System.Drawing.Point(140, 121);
            this.loginComp1.Name = "loginComp1";
            this.loginComp1.Size = new System.Drawing.Size(336, 192);
            this.loginComp1.TabIndex = 3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.loginComp1);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "Home";
            this.Size = new System.Drawing.Size(600, 411);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private LoginStud userControl31;
        private LoginComp loginComp1;
    }
}
