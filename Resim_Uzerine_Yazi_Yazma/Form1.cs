namespace Resim_Uzerine_Yazi_Yazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string resim = "";
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;
        }

        Color renk = Color.Black;
        private void btnRenkSec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }

        Bitmap bmp;
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (resim == "")
            {
                MessageBox.Show("Lütfen Bir Resim Seçin");
            }
            else if (txtMetin.Text == "")
            {
                MessageBox.Show("Lütfen Bir Metin Giriniz");
            }
            else if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Lütfen Bir Boyut Giriniz");
            }
            else
            {
                bmp = new Bitmap(resim);
                Graphics gr = Graphics.FromImage(bmp);
                gr.DrawString(txtMetin.Text, new Font("Segoe UI", Convert.ToInt16(numericUpDown1.Value), FontStyle.Bold), new SolidBrush(renk), 20, 20);
                pictureBox1.Image = bmp;
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Resim|.jpg";
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
        }
    }
}