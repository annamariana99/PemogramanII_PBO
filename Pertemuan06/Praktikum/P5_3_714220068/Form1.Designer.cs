﻿namespace P5_3_714220068
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMerkHP = new System.Windows.Forms.TextBox();
            this.rb_Android = new System.Windows.Forms.RadioButton();
            this.rb_iOS = new System.Windows.Forms.RadioButton();
            this.cbYa = new System.Windows.Forms.CheckBox();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "MERK HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "OS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sudah Diperbaiki?";
            // 
            // txtMerkHP
            // 
            this.txtMerkHP.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMerkHP.Location = new System.Drawing.Point(151, 35);
            this.txtMerkHP.Name = "txtMerkHP";
            this.txtMerkHP.Size = new System.Drawing.Size(239, 27);
            this.txtMerkHP.TabIndex = 3;
            // 
            // rb_Android
            // 
            this.rb_Android.AutoSize = true;
            this.rb_Android.Location = new System.Drawing.Point(151, 97);
            this.rb_Android.Name = "rb_Android";
            this.rb_Android.Size = new System.Drawing.Size(75, 20);
            this.rb_Android.TabIndex = 4;
            this.rb_Android.TabStop = true;
            this.rb_Android.Text = "Android";
            this.rb_Android.UseVisualStyleBackColor = true;
            // 
            // rb_iOS
            // 
            this.rb_iOS.AutoSize = true;
            this.rb_iOS.Location = new System.Drawing.Point(287, 97);
            this.rb_iOS.Name = "rb_iOS";
            this.rb_iOS.Size = new System.Drawing.Size(50, 20);
            this.rb_iOS.TabIndex = 5;
            this.rb_iOS.TabStop = true;
            this.rb_iOS.Text = "iOS";
            this.rb_iOS.UseVisualStyleBackColor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbYa
            // 
            this.cbYa.AutoSize = true;
            this.cbYa.Location = new System.Drawing.Point(190, 165);
            this.cbYa.Name = "cbYa";
            this.cbYa.Size = new System.Drawing.Size(46, 20);
            this.cbYa.TabIndex = 6;
            this.cbYa.Text = "Ya";
            this.cbYa.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(74, 217);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(89, 23);
            this.btnTampilkan.TabIndex = 7;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(274, 217);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 0;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(448, 268);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.cbYa);
            this.Controls.Add(this.rb_iOS);
            this.Controls.Add(this.rb_Android);
            this.Controls.Add(this.txtMerkHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SERVICE HP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMerkHP;
        private System.Windows.Forms.RadioButton rb_Android;
        private System.Windows.Forms.RadioButton rb_iOS;
        private System.Windows.Forms.CheckBox cbYa;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnKeluar;
    }
}

