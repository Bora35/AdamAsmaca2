using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Proje
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        Dictionary<int, string> Kelimeler = new Dictionary<int, string>()
        {
            {1,"Elma" },
            {2,"Armut" },
            {3,"Çilek" },
            {4,"Masa" },
            {5,"Sandalye" },
            {6,"Koltuk" },
            {7,"Minecraft" },
            {8,"Mario" },
            {9,"Tetris" },
            {10,"Babam ve Oğlum" },
            {11,"Hababam Sınıfı" },
            {12,"Organize İşler" },
            {13,"Leyla ile Mecnun" },
            {14,"Avrupa Yakası" },
            {15,"Öyle Bir Geçer Zaman Ki" },
            {16,"Tarkan" },
            {17,"Hadise" },
            {18,"Haluk Bilginer" },
        };

        Dictionary<int, string> Kategoriler = new Dictionary<int, string>()
        {
            {0,"Hepsi" },
            {1,"Meyve" },
            {2,"Eşya" },
            {3,"Oyun" },
            {4,"Film" },
            {5,"Dizi" },
            {6,"Ünlü" },
        };


        Dictionary<int, int> KelimeKategori = new Dictionary<int, int>()
        {
            {1, 1},
            {2, 1},
            {3, 1},
            {4, 2},
            {5, 2},
            {6, 2},
            {7, 3},
            {8, 3},
            {9, 3},
            {10, 4},
            {11, 4},
            {12, 4},
            {13, 5},
            {14, 5},
            {15, 5},
            {16, 6},
            {17, 6},
            {18, 6},
        };

        ArrayList SecilenKelimeler = new ArrayList();

        ArrayList yanlis = new ArrayList();
        ArrayList dogru = new ArrayList();

        List<KullaniciBilgi> kullaniciBilgileri = new List<KullaniciBilgi>();

        Random random = new Random();

        public string KullaniciAdi;
        public string Kategori;

        int KategoriNo = 1;

        int no;
        string cevap;
        int YAdet;
        string tahmin;
        char[] G;

        int puan;

        int Dakika, Saniye;

        private void Game_Load(object sender, EventArgs e)
        {
            SecilenKelimeler.Clear();
            yanlis.Clear();
            dogru.Clear();
            LblKelime.Text = string.Empty;


            foreach (var item in Kategoriler)
            {
                if (item.Value == Kategori)
                    KategoriNo = item.Key;
            }


            if (KategoriNo == 0)
            {
                KategoriNo = random.Next(1, Kategoriler.Count - 1);

                foreach (var item in KelimeKategori)
                {
                    if (item.Value == KategoriNo)
                    {
                        foreach (var kelime in Kelimeler)
                        {
                            if (item.Key == kelime.Key)
                            {
                                SecilenKelimeler.Add(kelime.Key + "." + kelime.Value);
                            }
                        }
                    }
                }

            }
            else
            {
                foreach (var item in KelimeKategori)
                {

                    if (item.Value == KategoriNo)
                    {
                        foreach (var kelime in Kelimeler)
                        {
                            if (item.Key == kelime.Key)
                            {
                                SecilenKelimeler.Add(kelime.Key + "." + kelime.Value);
                            }
                        }
                    }
                }
            }

            //// kontrol
            //foreach (var kelime in SecilenKelimeler)
            //{
            //    label1.Text += Environment.NewLine + kelime;
            //}


            no = random.Next(0, SecilenKelimeler.Count);
            cevap = SecilenKelimeler[no].ToString().Split('.')[1].ToLower();

            YAdet = 0;

            pictureBox1.Load($"images/{YAdet}.png");


            G = new char[cevap.Length];
            for (int i = 0; i < cevap.Length; i++)
            {
                if (cevap[i] == ' ')
                    G[i] = '-';
                else
                    G[i] = '_';
            }


            for (int i = 0; i < cevap.Length; i++)
            {
                LblKelime.Text += G[i] + " ";
            }


            LblKategori.Text += Kategoriler[KategoriNo];
            LblHak.Text += 7 - YAdet;

            //// kontrol
            //label1.Text += Environment.NewLine + no.ToString() + " " + SecilenKelimeler[no].ToString().Split('.')[0] + "-" + SecilenKelimeler[no].ToString().Split('.')[1];

            Dakika = 2 * cevap.Length;
            //Dakika = 1;
            Saniye = 0;

            LblSure.Text = "Süre : " +
                          String.Format("{0:D2}", Dakika) + ":" +
                          String.Format("{0:D2}", Saniye);

            Zamanlayici.Start();

            this.ActiveControl = LblKelime;
        }

        // BUTONLAR ILE KONTROL

        private void Oyun(object sender, EventArgs e)
        {
            Button BtnSecilen = (Button)sender;
            BtnSecilen.Enabled = false;
            BtnSecilen.BackColor = Color.DarkSeaGreen;

            string Secilen = BtnSecilen.Text.ToLower();
            if (BtnSecilen.Name == "BtnTahmin")
            {
                // TAHMİN
                TxtBoxTahmin.Text = string.Empty;

                TxtBoxTahmin.Visible = true;
                BtnGonder.Visible = true;
            }
            else if (!cevap.Contains(Secilen))
            {
                // YANLIŞ HARF
                YAdet++;
                pictureBox1.Load($"images/{YAdet}.png");
                LblHak.Text = $"Kalan Hak : {7 - YAdet}";
                yanlis.Add(Secilen);
            }
            else
            {
                // DOĞRU HARF
                for (int i = 0; i < cevap.Length; i++)
                {
                    if (cevap[i] == Secilen[0])
                    {
                        dogru.Add(Secilen);
                        G.SetValue(cevap[i], i);
                    }
                }

                LblKelime.Text = string.Empty;
                for (int i = 0; i < cevap.Length; i++)
                {
                    LblKelime.Text += G[i] + " ";
                }
            }

            if (YAdet == 7)
            {
                puan = -10;
                MessageBox.Show($"Hakkın kalmadı, oyun bitti.\nMaalesef bilemedin!\nKelime: {cevap}");
                OyunBitir();
            }

            if (!G.Contains('_'))
            {
                Zamanlayici.Stop();
                Saniye++;

                puan = (10 * cevap.Length) + (Dakika * 60) + Saniye - (YAdet * 20);

                MessageBox.Show($"Tebrikler kelimeyi buldun!\nPuan: {puan}\nKelime: {cevap}\nYanlış Sayın: {YAdet}\nSüre: " + String.Format("{0:D2}", Dakika) + ":" + String.Format("{0:D2}", Saniye));
                OyunBitir();
            }

            this.ActiveControl = LblKelime;
        }

        // TUSLAR ILE KONTROL

        private void Game_KeyPress(object sender, KeyPressEventArgs e)
        {

            char keyPressed = char.ToUpper(e.KeyChar);
            string Tus = keyPressed.ToString().ToLower();

            //// kontrol
            //label1.Text = keyPressed.ToString();

            if (Tus.Length < 2)
            {
                if (dogru.Contains(Tus) || yanlis.Contains(Tus))
                {
                    foreach (var Eleman in Controls)
                    {
                        if (Eleman.GetType() == typeof(Button))
                        {
                            Button SecilenButton = (Button)Eleman;

                            if (SecilenButton.Text == keyPressed.ToString())
                            {
                                SystemSounds.Hand.Play();
                            }
                        }
                    }
                }
                else
                {

                    foreach (var Eleman in Controls)
                    {
                        if (Eleman.GetType() == typeof(Button))
                        {
                            Button SecilenButton = (Button)Eleman;

                            if (SecilenButton.Text == keyPressed.ToString())
                            {
                                SecilenButton.Enabled = false; 
                                SecilenButton.BackColor = Color.DarkSeaGreen;
                            }
                        }
                    }

                    if (!cevap.Contains(Tus))
                    {
                        // YANLIŞ HARF
                        YAdet++;
                        pictureBox1.Load($"images/{YAdet}.png");
                        LblHak.Text = $"Kalan Hak : {7 - YAdet}";
                        yanlis.Add(Tus);
                    }
                    else
                    {
                        // DOĞRU HARF
                        for (int i = 0; i < cevap.Length; i++)
                        {
                            if (cevap[i] == Tus[0])
                            {
                                dogru.Add(Tus);
                                G.SetValue(cevap[i], i);
                            }
                        }

                        LblKelime.Text = string.Empty;
                        for (int i = 0; i < cevap.Length; i++)
                        {
                            LblKelime.Text += G[i] + " ";
                        }
                    }

                    if (YAdet == 7)
                    {
                        puan = -10;
                        MessageBox.Show($"Hakkın kalmadı, oyun bitti.\nMaalesef bilemedin!\nKelime: {cevap}");
                        OyunBitir();
                    }

                    if (!G.Contains('_'))
                    {
                        Zamanlayici.Stop();
                        Saniye++;

                        puan = (10 * cevap.Length) + (Dakika * 60) + Saniye - (YAdet * 20);

                        MessageBox.Show($"Tebrikler kelimeyi buldun!\nPuan: {puan}\nKelime: {cevap}\nYanlış Sayın: {YAdet}\nSüre: " + String.Format("{0:D2}", Dakika) + ":" + String.Format("{0:D2}", Saniye));
                        OyunBitir();
                    }

                    foreach (var Eleman in Controls)
                    {
                        if (Eleman.GetType() == typeof(Button))
                        {
                            Button SecilenButton = (Button)Eleman;

                            if (SecilenButton.Text == keyPressed.ToString())
                            {
                                SecilenButton.Enabled = false;
                            }
                        }
                    }
                }

            }

            this.ActiveControl = LblKelime;

        }

        // TAHMIN GONDER TUSU

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            // TAHMİN

            tahmin = TxtBoxTahmin.Text.ToLower();

            if (tahmin == cevap)
            {
                LblKelime.Text = string.Empty;
                for (int i = 0; i < cevap.Length; i++)
                {
                    LblKelime.Text += cevap[i] + " ";
                }

                Zamanlayici.Stop();
                Saniye++;

                puan = (10 * cevap.Length) + (Dakika * 60) + Saniye - (YAdet * 20);

                MessageBox.Show($"Tebrikler kelimeyi buldun!\nPuan: {puan}\nKelime: {cevap}\nYanlış Sayın: {YAdet}\nSüre: " + String.Format("{0:D2}", Dakika) + ":" + String.Format("{0:D2}", Saniye));
                OyunBitir();
            }
            else
            {
                TxtBoxTahmin.Visible = false;
                BtnGonder.Visible = false;

                YAdet++;
                pictureBox1.Load($"images/{YAdet}.png");
                LblHak.Text = $"Kalan Hak : {7 - YAdet}";

                BtnTahmin.Enabled = true;

            }
        }

        // ZAMANLAYICI

        private void Zamanlayici_Tick(object sender, EventArgs e)
        {
            if (Saniye == 0)
            {
                Saniye = 59;
                Dakika--;
            }

            if (Dakika == -1)
            {
                Zamanlayici.Stop();
                puan = dogru.Count * 2;
                MessageBox.Show($"Süren doldu, oyun bitti.\nMaalesef bilemedin!\nPuan: {puan}\nKelime: {cevap}");
                OyunBitir();
            }

            LblSure.Text = "Süre : " +
                          String.Format("{0:D2}", Dakika) + ":" +
                          String.Format("{0:D2}", Saniye);

            Saniye--;

        }

        // OYUN BITIR

        private void OyunBitir()
        {
            // JSON verilerini oku
            string json = File.ReadAllText("kullanicibilgi.json");
            if (!string.IsNullOrEmpty(json))
            {
                kullaniciBilgileri = JsonConvert.DeserializeObject<List<KullaniciBilgi>>(json);
            }

            KullaniciBilgi kullanici = new KullaniciBilgi
            {
                Id = kullaniciBilgileri.Count,
                Ad = KullaniciAdi,
                Kategori = Kategoriler[KategoriNo],
                Kelime = cevap,
                YanlisSayisi = YAdet,
                Sure = (Dakika * 60) + Saniye,
                Puan = puan
            };

            kullaniciBilgileri.Add(kullanici);

            string jsonData = JsonConvert.SerializeObject(kullaniciBilgileri);

            // JSON verilerini dosyaya yaz
            File.WriteAllText("kullanicibilgi.json", jsonData);

            //// kontrol
            //MessageBox.Show("YAZILDI.");

            Menu FrmMenu = new Menu();
            FrmMenu.Show();
            this.Hide();
        }

        private void LblKategori_Click(object sender, EventArgs e)
        {

        }

        private void LblHak_Click(object sender, EventArgs e)
        {

        }

        private void LblSure_Click(object sender, EventArgs e)
        {

        }

        // OYUN KAPAT

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Istek = MessageBox.Show("Oyundan çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (Istek != DialogResult.OK)
                e.Cancel = true;
            else
            {
                Zamanlayici.Stop();
                Menu FrmMenu = new Menu();
                FrmMenu.Show();
                this.Hide();
            }

        }
    }
}
