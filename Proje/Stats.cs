using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proje
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }

        List<KullaniciBilgi> kullaniciBilgileri = new List<KullaniciBilgi>();

        List<KullaniciBilgi> SortedList;

        GroupBox GrpBox1;
        GroupBox GrpBox2;
        GroupBox GrpBox3;
        GroupBox GrpBox4;
        GroupBox GrpBox5;
        GroupBox GrpBox6;

        private void Stats_Load(object sender, EventArgs e)
        {

            // JSON verilerini oku
            string json = File.ReadAllText("kullanicibilgi.json");
            if (!string.IsNullOrEmpty(json))
            {
                kullaniciBilgileri = JsonConvert.DeserializeObject<List<KullaniciBilgi>>(json);
            }

            TreeNode StatsName = new TreeNode("İstatistikler");
            StatsName.Nodes.Add("Genel", "Genel");
            StatsName.Nodes.Add("Kategoriler", "Kategoriler");
            StatsName.Nodes.Add("Kelimeler", "Kelimeler");
            StatsName.Nodes.Add("YanlisSayilari", "Yanlış Sayıları");
            StatsName.Nodes.Add("Sureler", "Süreler");
            StatsName.Nodes.Add("Puanlar", "Puanlar");

            StatsMenu.Nodes.Add(StatsName);

            StatsMenu.HotTracking = true;
            StatsMenu.ExpandAll();
            StatsMenu.NodeMouseClick += StatsMenu_NodeMouseClick;
            Controls.Add(StatsMenu);

            // GENEL LISTE

            SortedList = kullaniciBilgileri.OrderBy(o => o.Id).ToList();

            int X = 20;
            int Y = 20;
            int Sayac = 0;

            GrpBox1 = new GroupBox();
            GrpBox1.Location = new Point(280, 8);
            GrpBox1.Size = new Size(907, 500);
            GrpBox1.Text = "Genel";
            GrpBox1.ForeColor = Color.White;
            GrpBox1.Visible = false;

            TextBox TXTDinamik = new TextBox();
            TXTDinamik.ReadOnly = true;
            TXTDinamik.Width = 800;
            TXTDinamik.Text = $"" +
                $"Id".PadRight(35) +
                $"Ad".PadRight(35) +
                $"Kategori".PadRight(35) +
                $"Kelime".PadRight(35) +
                $"Yanlış Sayısı".PadRight(35) +
                $"Kalan Süre (sn)".PadRight(35) +
                $"Puan".PadRight(35);
            TXTDinamik.Location = new Point(X, Y);
            GrpBox1.Controls.Add(TXTDinamik);

            Y += 30;


            foreach (var Eleman in SortedList)
            {
                if (Sayac == 15) break;

                TXTDinamik = new TextBox();
                TXTDinamik.ReadOnly = true;
                TXTDinamik.Width = 800;
                TXTDinamik.Text = $"" +
                    $"{Eleman.Id.ToString().PadRight(35)}" +
                    $"{Eleman.Ad.PadRight(35)}" +
                    $"{Eleman.Kategori.PadRight(35)}" +
                    $"{Eleman.Kelime.PadRight(35)}" +
                    $"{Eleman.YanlisSayisi.ToString().PadRight(35)}" +
                    $"{Eleman.Sure.ToString().PadRight(35)}" +
                    $"{Eleman.Puan.ToString().PadRight(35)}";
                TXTDinamik.Location = new Point(X, Y);

                GrpBox1.Controls.Add(TXTDinamik);

                Y += 30;
                Sayac++;
            }

            Controls.Add(GrpBox1);


            // KATEGORILER LISTE

            SortedList = kullaniciBilgileri.OrderBy(o => o.Kategori).ToList();

            X = 20;
            Y = 20;
            Sayac = 0;

            GrpBox2 = new GroupBox();
            GrpBox2.Location = new Point(280, 8);
            GrpBox2.Size = new Size(907, 500);
            GrpBox2.Text = "Kategoriler";
            GrpBox2.ForeColor = Color.White;
            GrpBox2.Visible = false;

            TextBox TXTDinamik1 = new TextBox();
            TXTDinamik1.ReadOnly = true;
            TXTDinamik1.Width = 400;
            TXTDinamik1.Text = $"" +
                $"Id".PadRight(35) +
                $"Ad".PadRight(35) +
                $"Kategori".PadRight(35);
            TXTDinamik1.Location = new Point(X, Y);
            GrpBox2.Controls.Add(TXTDinamik1);

            Y += 30;


            foreach (var Eleman in SortedList)
            {

                if (Sayac == 15) break;

                TXTDinamik1 = new TextBox();
                TXTDinamik1.ReadOnly = true;
                TXTDinamik1.Width = 400;
                TXTDinamik1.Text = $"" +
                    $"{Eleman.Id.ToString().PadRight(35)}" +
                    $"{Eleman.Ad.PadRight(35)}" +
                    $"{Eleman.Kategori.PadRight(35)}";
                TXTDinamik1.Location = new Point(X, Y);

                GrpBox2.Controls.Add(TXTDinamik1);

                Y += 30;
                Sayac++;
            }

            Controls.Add(GrpBox2);


            // KELIMELER LISTE

            SortedList = kullaniciBilgileri.OrderBy(o => o.Kelime).ToList();

            X = 20;
            Y = 20;
            Sayac = 0;

            GrpBox3 = new GroupBox();
            GrpBox3.Location = new Point(280, 8);
            GrpBox3.Size = new Size(907, 500);
            GrpBox3.Text = "Kelimeler";
            GrpBox3.ForeColor = Color.White;
            GrpBox3.Visible = false;

            TextBox TXTDinamik2 = new TextBox();
            TXTDinamik2.ReadOnly = true;
            TXTDinamik2.Width = 400;
            TXTDinamik2.Text = $"" +
                $"Id".PadRight(35) +
                $"Ad".PadRight(35) +
                $"Kelime".PadRight(35);
            TXTDinamik2.Location = new Point(X, Y);
            GrpBox3.Controls.Add(TXTDinamik2);

            Y += 30;


            foreach (var Eleman in SortedList)
            {
                if (Sayac == 15) break;

                TXTDinamik2 = new TextBox();
                TXTDinamik2.ReadOnly = true;
                TXTDinamik2.Width = 400;
                TXTDinamik2.Text = $"" +
                    $"{Eleman.Id.ToString().PadRight(35)}" +
                    $"{Eleman.Ad.PadRight(35)}" +
                    $"{Eleman.Kelime.PadRight(35)}";
                TXTDinamik2.Location = new Point(X, Y);

                GrpBox3.Controls.Add(TXTDinamik2);

                Y += 30;
                Sayac++;
            }

            Controls.Add(GrpBox3);


            // YANLIS SAYISI LISTE

            SortedList = kullaniciBilgileri.OrderBy(o => o.YanlisSayisi).ToList();

            X = 20;
            Y = 20;
            Sayac = 0;

            GrpBox4 = new GroupBox();
            GrpBox4.Location = new Point(280, 8);
            GrpBox4.Size = new Size(907, 500);
            GrpBox4.Text = "Yanlış Sayıları";
            GrpBox4.ForeColor = Color.White;
            GrpBox4.Visible = false;

            TextBox TXTDinamik3 = new TextBox();
            TXTDinamik3.ReadOnly = true;
            TXTDinamik3.Width = 400;
            TXTDinamik3.Text = $"" +
                $"Id".PadRight(35) +
                $"Ad".PadRight(35) +
                $"Yanlış Sayısı".PadRight(35);
            TXTDinamik3.Location = new Point(X, Y);
            GrpBox4.Controls.Add(TXTDinamik3);

            Y += 30;


            foreach (var Eleman in SortedList)
            {
                if (Sayac == 15) break;

                TXTDinamik3 = new TextBox();
                TXTDinamik3.ReadOnly = true;
                TXTDinamik3.Width = 400;
                TXTDinamik3.Text = $"" +
                    $"{Eleman.Id.ToString().PadRight(35)}" +
                    $"{Eleman.Ad.PadRight(35)}" +
                    $"{Eleman.YanlisSayisi.ToString().PadRight(35)}";
                TXTDinamik3.Location = new Point(X, Y);

                GrpBox4.Controls.Add(TXTDinamik3);

                Y += 30;
                Sayac++;
            }

            Controls.Add(GrpBox4);


            // SURELER LISTE

            SortedList = kullaniciBilgileri.OrderBy(o => o.Sure).ToList();
            SortedList.Reverse();

            X = 20;
            Y = 20;
            Sayac = 0;

            GrpBox5 = new GroupBox();
            GrpBox5.Location = new Point(280, 8);
            GrpBox5.Size = new Size(907, 500);
            GrpBox5.Text = "Süreler";
            GrpBox5.ForeColor = Color.White;
            GrpBox5.Visible = false;

            TextBox TXTDinamik4 = new TextBox();
            TXTDinamik4.ReadOnly = true;
            TXTDinamik4.Width = 400;
            TXTDinamik4.Text = $"" +
                $"Id".PadRight(35) +
                $"Ad".PadRight(35) +
                $"Kalan Süre (sn)".PadRight(35);
            TXTDinamik4.Location = new Point(X, Y);
            GrpBox5.Controls.Add(TXTDinamik4);

            Y += 30;


            foreach (var Eleman in SortedList)
            {
                if (Sayac == 15) break;

                TXTDinamik4 = new TextBox();
                TXTDinamik4.ReadOnly = true;
                TXTDinamik4.Width = 400;
                TXTDinamik4.Text = $"" +
                    $"{Eleman.Id.ToString().PadRight(35)}" +
                    $"{Eleman.Ad.PadRight(35)}" +
                    $"{Eleman.Sure.ToString().PadRight(35)}";
                TXTDinamik4.Location = new Point(X, Y);

                GrpBox5.Controls.Add(TXTDinamik4);

                Y += 30;
                Sayac++;
            }

            Controls.Add(GrpBox5);


            // PUANLAR LISTE

            SortedList = kullaniciBilgileri.OrderBy(o => o.Puan).ToList();
            SortedList.Reverse();

            X = 20;
            Y = 20;
            Sayac = 0;

            GrpBox6 = new GroupBox();
            GrpBox6.Location = new Point(280, 8);
            GrpBox6.Size = new Size(907, 500);
            GrpBox6.Text = "Puanlar";
            GrpBox6.ForeColor = Color.White;
            GrpBox6.Visible = false;

            TextBox TXTDinamik5 = new TextBox();
            TXTDinamik5.ReadOnly = true;
            TXTDinamik5.Width = 400;
            TXTDinamik5.Text = $"" +
                $"Id".PadRight(35) +
                $"Ad".PadRight(35) +
                $"Puan".PadRight(35);
            TXTDinamik5.Location = new Point(X, Y);
            GrpBox6.Controls.Add(TXTDinamik5);

            Y += 30;


            foreach (var Eleman in SortedList)
            {
                if (Sayac == 15) break;

                TXTDinamik5 = new TextBox();
                TXTDinamik5.ReadOnly = true;
                TXTDinamik5.Width = 400;
                TXTDinamik5.Text = $"" +
                    $"{Eleman.Id.ToString().PadRight(35)}" +
                    $"{Eleman.Ad.PadRight(35)}" +
                    $"{Eleman.Puan.ToString().PadRight(35)}";
                TXTDinamik5.Location = new Point(X, Y);

                GrpBox6.Controls.Add(TXTDinamik5);

                Y += 30;
                Sayac++;
            }

            Controls.Add(GrpBox6);

        }

        private void StatsMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "Genel":
                    GrpBox1.Visible = true;
                    GrpBox2.Visible = false;
                    GrpBox3.Visible = false;
                    GrpBox4.Visible = false;
                    GrpBox5.Visible = false;
                    GrpBox6.Visible = false;
                    break;

                case "Kategoriler":
                    GrpBox1.Visible = false;
                    GrpBox2.Visible = true;
                    GrpBox3.Visible = false;
                    GrpBox4.Visible = false;
                    GrpBox5.Visible = false;
                    GrpBox6.Visible = false;
                    break;

                case "Kelimeler":
                    GrpBox1.Visible = false;
                    GrpBox2.Visible = false;
                    GrpBox3.Visible = true;
                    GrpBox4.Visible = false;
                    GrpBox5.Visible = false;
                    GrpBox6.Visible = false;
                    break;

                case "YanlisSayilari":
                    GrpBox1.Visible = false;
                    GrpBox2.Visible = false;
                    GrpBox3.Visible = false;
                    GrpBox4.Visible = true;
                    GrpBox5.Visible = false;
                    GrpBox6.Visible = false;
                    break;

                case "Sureler":
                    GrpBox1.Visible = false;
                    GrpBox2.Visible = false;
                    GrpBox3.Visible = false;
                    GrpBox4.Visible = false;
                    GrpBox5.Visible = true;
                    GrpBox6.Visible = false;
                    break;

                case "Puanlar":
                    GrpBox1.Visible = false;
                    GrpBox2.Visible = false;
                    GrpBox3.Visible = false;
                    GrpBox4.Visible = false;
                    GrpBox5.Visible = false;
                    GrpBox6.Visible = true;
                    break;
            }
        }

        private void Stats_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Istek = MessageBox.Show("Ana Menüye dönmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (Istek != DialogResult.OK)
                e.Cancel = true;
            else
            {
                Menu FrmMenu = new Menu();
                FrmMenu.Show();
                this.Hide();
            }
        }
    }
}
