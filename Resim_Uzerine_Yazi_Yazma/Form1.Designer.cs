namespace Resim_Uzerine_Yazi_Yazma
{
    partial class Form1
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
            btnRenkSec = new Button();
            btnResimSec = new Button();
            btnYazdir = new Button();
            btnKaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            txtMetin = new TextBox();
            txtBoyut = new TextBox();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRenkSec
            // 
            btnRenkSec.ForeColor = Color.FromArgb(56, 52, 67);
            btnRenkSec.Location = new Point(12, 54);
            btnRenkSec.Name = "btnRenkSec";
            btnRenkSec.Size = new Size(163, 36);
            btnRenkSec.TabIndex = 1;
            btnRenkSec.Text = "Renk Seç";
            btnRenkSec.UseVisualStyleBackColor = true;
            // 
            // btnResimSec
            // 
            btnResimSec.ForeColor = Color.FromArgb(56, 52, 67);
            btnResimSec.Location = new Point(12, 12);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Size = new Size(163, 36);
            btnResimSec.TabIndex = 0;
            btnResimSec.Text = "Resim Seç";
            btnResimSec.UseVisualStyleBackColor = true;
            btnResimSec.Click += btnResimSec_Click;
            // 
            // btnYazdir
            // 
            btnYazdir.ForeColor = Color.FromArgb(56, 52, 67);
            btnYazdir.Location = new Point(12, 96);
            btnYazdir.Name = "btnYazdir";
            btnYazdir.Size = new Size(163, 36);
            btnYazdir.TabIndex = 2;
            btnYazdir.Text = "Yazır";
            btnYazdir.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.ForeColor = Color.FromArgb(56, 52, 67);
            btnKaydet.Location = new Point(12, 138);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(163, 36);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(180, 214, 202);
            label1.Location = new Point(12, 187);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 4;
            label1.Text = "Metin: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(180, 214, 202);
            label2.Location = new Point(12, 222);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 5;
            label2.Text = "Boyut: ";
            // 
            // txtMetin
            // 
            txtMetin.Location = new Point(75, 184);
            txtMetin.Name = "txtMetin";
            txtMetin.Size = new Size(100, 29);
            txtMetin.TabIndex = 6;
            // 
            // txtBoyut
            // 
            txtBoyut.Location = new Point(75, 219);
            txtBoyut.Name = "txtBoyut";
            txtBoyut.Size = new Size(100, 29);
            txtBoyut.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(199, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(339, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AcceptButton = btnKaydet;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 75, 89);
            ClientSize = new Size(560, 270);
            Controls.Add(pictureBox1);
            Controls.Add(txtBoyut);
            Controls.Add(txtMetin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Controls.Add(btnYazdir);
            Controls.Add(btnResimSec);
            Controls.Add(btnRenkSec);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(56, 52, 67);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resmin Üzerine Yazı Yazma";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRenkSec;
        private Button btnResimSec;
        private Button btnYazdir;
        private Button btnKaydet;
        private Label label1;
        private Label label2;
        private TextBox txtMetin;
        private TextBox txtBoyut;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ColorDialog colorDialog1;
    }
}