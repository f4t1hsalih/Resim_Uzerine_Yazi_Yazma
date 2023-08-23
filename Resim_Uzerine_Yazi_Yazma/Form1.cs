namespace Resim_Uzerine_Yazi_Yazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string resim = "";
        Color renk;

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;
        }

        private void btnRenkSec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }
    }
}