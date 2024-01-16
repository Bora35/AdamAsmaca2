using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Proje
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        Game FrmGame = new Game();
        Stats FrmStats = new Stats();

        int No = 0;

        private void Menu_Load(object sender, EventArgs e)
        {
            pictureBox1.Load($"images/{No}.png");
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            string Categorie = null;
            foreach (var Eleman in gBoxCategories.Controls)
            {
                if (Eleman.GetType() == typeof(RadioButton))
                {
                    RadioButton Rdb = (RadioButton)Eleman;
                    if (Rdb.Checked)
                        Categorie = Rdb.Text;
                }
            }

            if (TxtBoxName.Text.Length < 2)
            {
                MessageBox.Show("İsminiz 2 harften kısa olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtBoxName.Text.Contains('.'))
            {
                MessageBox.Show("İsminiz nokta (.) içeremez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Categorie == null)
            {
                MessageBox.Show("Lütfen kategori seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmGame.KullaniciAdi = TxtBoxName.Text;
                FrmGame.Kategori = Categorie;
                FrmGame.Show();
                this.Hide();
            }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Istek = MessageBox.Show("Kapatmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (Istek != DialogResult.OK)
                e.Cancel = true;
            else
                Application.ExitThread(); // Uygulamayı tamamen sonlandırır
            //    Environment.Exit(0);

        }

        private void BtnStats_Click(object sender, EventArgs e)
        {
            FrmStats.Show();
            this.Hide();
        }

        private void TxtBoxName_TextChanged(object sender, EventArgs e)
        {
            No++;
            if (No == 8) No = 0;
            pictureBox1.Load($"images/{No}.png");
        }
    }

}
