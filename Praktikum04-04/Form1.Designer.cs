
namespace Praktikum04_04
{
    partial class FormQuizPanda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelInput = new System.Windows.Forms.Label();
            this.labelHuruf = new System.Windows.Forms.Label();
            this.labelTulisanHasil = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelMenjadi = new System.Windows.Forms.Label();
            this.buttonKonversi = new System.Windows.Forms.Button();
            this.tBoxInput = new System.Windows.Forms.TextBox();
            this.tBoxHurufAwal = new System.Windows.Forms.TextBox();
            this.tBoxHurufKonversi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(40, 40);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(129, 20);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Masukkan Kalimat";
            // 
            // labelHuruf
            // 
            this.labelHuruf.AutoSize = true;
            this.labelHuruf.Location = new System.Drawing.Point(37, 108);
            this.labelHuruf.Name = "labelHuruf";
            this.labelHuruf.Size = new System.Drawing.Size(115, 20);
            this.labelHuruf.TabIndex = 1;
            this.labelHuruf.Text = "Masukkan Huruf";
            // 
            // labelTulisanHasil
            // 
            this.labelTulisanHasil.AutoSize = true;
            this.labelTulisanHasil.Location = new System.Drawing.Point(40, 218);
            this.labelTulisanHasil.Name = "labelTulisanHasil";
            this.labelTulisanHasil.Size = new System.Drawing.Size(49, 20);
            this.labelTulisanHasil.TabIndex = 2;
            this.labelTulisanHasil.Text = "Hasil :";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(175, 218);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(42, 20);
            this.labelOutput.TabIndex = 3;
            this.labelOutput.Text = "Hasil";
            // 
            // labelMenjadi
            // 
            this.labelMenjadi.AutoSize = true;
            this.labelMenjadi.Location = new System.Drawing.Point(302, 104);
            this.labelMenjadi.Name = "labelMenjadi";
            this.labelMenjadi.Size = new System.Drawing.Size(63, 20);
            this.labelMenjadi.TabIndex = 4;
            this.labelMenjadi.Text = "Menjadi";
            // 
            // buttonKonversi
            // 
            this.buttonKonversi.Location = new System.Drawing.Point(174, 166);
            this.buttonKonversi.Name = "buttonKonversi";
            this.buttonKonversi.Size = new System.Drawing.Size(320, 29);
            this.buttonKonversi.TabIndex = 5;
            this.buttonKonversi.Text = "Konversi!";
            this.buttonKonversi.UseVisualStyleBackColor = true;
            this.buttonKonversi.Click += new System.EventHandler(this.buttonKonversi_Click);
            // 
            // tBoxInput
            // 
            this.tBoxInput.Location = new System.Drawing.Point(175, 37);
            this.tBoxInput.Name = "tBoxInput";
            this.tBoxInput.Size = new System.Drawing.Size(319, 27);
            this.tBoxInput.TabIndex = 6;
            // 
            // tBoxHurufAwal
            // 
            this.tBoxHurufAwal.Location = new System.Drawing.Point(174, 101);
            this.tBoxHurufAwal.MaxLength = 1;
            this.tBoxHurufAwal.Name = "tBoxHurufAwal";
            this.tBoxHurufAwal.Size = new System.Drawing.Size(65, 27);
            this.tBoxHurufAwal.TabIndex = 7;
            // 
            // tBoxHurufKonversi
            // 
            this.tBoxHurufKonversi.Location = new System.Drawing.Point(429, 101);
            this.tBoxHurufKonversi.MaxLength = 1;
            this.tBoxHurufKonversi.Name = "tBoxHurufKonversi";
            this.tBoxHurufKonversi.Size = new System.Drawing.Size(65, 27);
            this.tBoxHurufKonversi.TabIndex = 8;
            // 
            // FormQuizPanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBoxHurufKonversi);
            this.Controls.Add(this.tBoxHurufAwal);
            this.Controls.Add(this.tBoxInput);
            this.Controls.Add(this.buttonKonversi);
            this.Controls.Add(this.labelMenjadi);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelTulisanHasil);
            this.Controls.Add(this.labelHuruf);
            this.Controls.Add(this.labelInput);
            this.Name = "FormQuizPanda";
            this.Text = "Quiz Panda";
            this.Load += new System.EventHandler(this.FormQuizPanda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelHuruf;
        private System.Windows.Forms.Label labelTulisanHasil;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelMenjadi;
        private System.Windows.Forms.Button buttonKonversi;
        private System.Windows.Forms.TextBox tBoxInput;
        private System.Windows.Forms.TextBox tBoxHurufAwal;
        private System.Windows.Forms.TextBox tBoxHurufKonversi;
    }
}

