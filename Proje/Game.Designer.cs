namespace Proje
{
    partial class Game
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.BtnTahmin = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.LblKelime = new System.Windows.Forms.Label();
            this.LblKategori = new System.Windows.Forms.Label();
            this.LblHak = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtBoxTahmin = new System.Windows.Forms.TextBox();
            this.BtnGonder = new System.Windows.Forms.Button();
            this.Zamanlayici = new System.Windows.Forms.Timer(this.components);
            this.LblSure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(97, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "Q";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Oyun);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(203, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 2;
            this.button2.Text = "W";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Oyun);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(309, 485);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 3;
            this.button3.Text = "E";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Oyun);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LimeGreen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(415, 485);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 100);
            this.button4.TabIndex = 4;
            this.button4.Text = "R";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Oyun);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LimeGreen;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Location = new System.Drawing.Point(521, 485);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 100);
            this.button5.TabIndex = 5;
            this.button5.Text = "T";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Oyun);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LimeGreen;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button6.Location = new System.Drawing.Point(627, 485);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 100);
            this.button6.TabIndex = 6;
            this.button6.Text = "Y";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Oyun);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LimeGreen;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button7.Location = new System.Drawing.Point(733, 485);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 100);
            this.button7.TabIndex = 7;
            this.button7.Text = "U";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Oyun);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LimeGreen;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button8.Location = new System.Drawing.Point(839, 485);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 100);
            this.button8.TabIndex = 8;
            this.button8.Text = "I";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Oyun);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LimeGreen;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button9.Location = new System.Drawing.Point(945, 485);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 100);
            this.button9.TabIndex = 9;
            this.button9.Text = "O";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Oyun);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LimeGreen;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button10.Location = new System.Drawing.Point(1051, 485);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 100);
            this.button10.TabIndex = 10;
            this.button10.Text = "P";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Oyun);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LimeGreen;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button11.Location = new System.Drawing.Point(1157, 485);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 100);
            this.button11.TabIndex = 11;
            this.button11.Text = "Ğ";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Oyun);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LimeGreen;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button12.Location = new System.Drawing.Point(1263, 485);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 100);
            this.button12.TabIndex = 12;
            this.button12.Text = "Ü";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Oyun);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.LimeGreen;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button13.Location = new System.Drawing.Point(1208, 591);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 100);
            this.button13.TabIndex = 23;
            this.button13.Text = "İ";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.Oyun);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.LimeGreen;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button14.Location = new System.Drawing.Point(1101, 591);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(100, 100);
            this.button14.TabIndex = 22;
            this.button14.Text = "Ş";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.Oyun);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.LimeGreen;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button15.Location = new System.Drawing.Point(996, 591);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(100, 100);
            this.button15.TabIndex = 21;
            this.button15.Text = "L";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.Oyun);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.LimeGreen;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button16.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button16.Location = new System.Drawing.Point(891, 591);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(100, 100);
            this.button16.TabIndex = 20;
            this.button16.Text = "K";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.Oyun);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.LimeGreen;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button17.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button17.Location = new System.Drawing.Point(784, 591);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(100, 100);
            this.button17.TabIndex = 19;
            this.button17.Text = "J";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.Oyun);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.LimeGreen;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button18.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button18.Location = new System.Drawing.Point(677, 591);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(100, 100);
            this.button18.TabIndex = 18;
            this.button18.Text = "H";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.Oyun);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.LimeGreen;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button19.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button19.Location = new System.Drawing.Point(572, 591);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(100, 100);
            this.button19.TabIndex = 17;
            this.button19.Text = "G";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.Oyun);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.LimeGreen;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button20.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button20.Location = new System.Drawing.Point(467, 591);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(100, 100);
            this.button20.TabIndex = 16;
            this.button20.Text = "F";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.Oyun);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.LimeGreen;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button21.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button21.Location = new System.Drawing.Point(360, 591);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(100, 100);
            this.button21.TabIndex = 15;
            this.button21.Text = "D";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.Oyun);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.LimeGreen;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button22.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button22.Location = new System.Drawing.Point(253, 591);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(100, 100);
            this.button22.TabIndex = 14;
            this.button22.Text = "S";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.Oyun);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.LimeGreen;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button23.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button23.Location = new System.Drawing.Point(148, 591);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(100, 100);
            this.button23.TabIndex = 13;
            this.button23.Text = "A";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.Oyun);
            // 
            // BtnTahmin
            // 
            this.BtnTahmin.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTahmin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnTahmin.Location = new System.Drawing.Point(1157, 697);
            this.BtnTahmin.Name = "BtnTahmin";
            this.BtnTahmin.Size = new System.Drawing.Size(100, 100);
            this.BtnTahmin.TabIndex = 33;
            this.BtnTahmin.Text = "TAHMİN ET";
            this.BtnTahmin.UseVisualStyleBackColor = false;
            this.BtnTahmin.Click += new System.EventHandler(this.Oyun);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.LimeGreen;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button25.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button25.Location = new System.Drawing.Point(1051, 697);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(100, 100);
            this.button25.TabIndex = 32;
            this.button25.Text = "Ç";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.Oyun);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.LimeGreen;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button26.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button26.Location = new System.Drawing.Point(945, 697);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(100, 100);
            this.button26.TabIndex = 31;
            this.button26.Text = "Ö";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.Oyun);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.LimeGreen;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button27.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button27.Location = new System.Drawing.Point(839, 697);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(100, 100);
            this.button27.TabIndex = 30;
            this.button27.Text = "M";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.Oyun);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.LimeGreen;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button28.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button28.Location = new System.Drawing.Point(733, 697);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(100, 100);
            this.button28.TabIndex = 29;
            this.button28.Text = "N";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.Oyun);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.LimeGreen;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button29.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button29.Location = new System.Drawing.Point(627, 697);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(100, 100);
            this.button29.TabIndex = 28;
            this.button29.Text = "B";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.Oyun);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.LimeGreen;
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button30.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button30.Location = new System.Drawing.Point(521, 697);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(100, 100);
            this.button30.TabIndex = 27;
            this.button30.Text = "V";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.Oyun);
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.LimeGreen;
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button31.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button31.Location = new System.Drawing.Point(415, 697);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(100, 100);
            this.button31.TabIndex = 26;
            this.button31.Text = "C";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.Oyun);
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.LimeGreen;
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button32.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button32.Location = new System.Drawing.Point(309, 697);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(100, 100);
            this.button32.TabIndex = 25;
            this.button32.Text = "X";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.Oyun);
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.LimeGreen;
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button33.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button33.Location = new System.Drawing.Point(203, 697);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(100, 100);
            this.button33.TabIndex = 24;
            this.button33.Text = "Z";
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.Oyun);
            // 
            // LblKelime
            // 
            this.LblKelime.AutoSize = true;
            this.LblKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKelime.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LblKelime.Location = new System.Drawing.Point(575, 56);
            this.LblKelime.Name = "LblKelime";
            this.LblKelime.Size = new System.Drawing.Size(268, 69);
            this.LblKelime.TabIndex = 34;
            this.LblKelime.Text = "_ _ _ _ _";
            // 
            // LblKategori
            // 
            this.LblKategori.AutoSize = true;
            this.LblKategori.Font = new System.Drawing.Font("Milyone", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKategori.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LblKategori.Location = new System.Drawing.Point(575, 144);
            this.LblKategori.Name = "LblKategori";
            this.LblKategori.Size = new System.Drawing.Size(228, 65);
            this.LblKategori.TabIndex = 35;
            this.LblKategori.Text = "Kategori :  ";
            // 
            // LblHak
            // 
            this.LblHak.AutoSize = true;
            this.LblHak.Font = new System.Drawing.Font("Milyone", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHak.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LblHak.Location = new System.Drawing.Point(575, 207);
            this.LblHak.Name = "LblHak";
            this.LblHak.Size = new System.Drawing.Size(246, 65);
            this.LblHak.TabIndex = 36;
            this.LblHak.Text = "Kalan Hak : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(97, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 422);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // TxtBoxTahmin
            // 
            this.TxtBoxTahmin.BackColor = System.Drawing.Color.LimeGreen;
            this.TxtBoxTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBoxTahmin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TxtBoxTahmin.Location = new System.Drawing.Point(587, 373);
            this.TxtBoxTahmin.Name = "TxtBoxTahmin";
            this.TxtBoxTahmin.Size = new System.Drawing.Size(461, 61);
            this.TxtBoxTahmin.TabIndex = 38;
            this.TxtBoxTahmin.Visible = false;
            // 
            // BtnGonder
            // 
            this.BtnGonder.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGonder.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnGonder.Location = new System.Drawing.Point(1053, 373);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(119, 61);
            this.BtnGonder.TabIndex = 39;
            this.BtnGonder.Text = "Gönder";
            this.BtnGonder.UseVisualStyleBackColor = false;
            this.BtnGonder.Visible = false;
            this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // Zamanlayici
            // 
            this.Zamanlayici.Interval = 1000;
            this.Zamanlayici.Tick += new System.EventHandler(this.Zamanlayici_Tick);
            // 
            // LblSure
            // 
            this.LblSure.AutoSize = true;
            this.LblSure.Font = new System.Drawing.Font("Milyone", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSure.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LblSure.Location = new System.Drawing.Point(577, 271);
            this.LblSure.Name = "LblSure";
            this.LblSure.Size = new System.Drawing.Size(132, 65);
            this.LblSure.TabIndex = 40;
            this.LblSure.Text = "Süre :";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1701, 859);
            this.Controls.Add(this.LblSure);
            this.Controls.Add(this.BtnGonder);
            this.Controls.Add(this.TxtBoxTahmin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblHak);
            this.Controls.Add(this.LblKategori);
            this.Controls.Add(this.LblKelime);
            this.Controls.Add(this.BtnTahmin);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Game";
            this.Text = "Adam Asmaca - Oyun";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button BtnTahmin;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Label LblKelime;
        private System.Windows.Forms.Label LblKategori;
        private System.Windows.Forms.Label LblHak;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtBoxTahmin;
        private System.Windows.Forms.Button BtnGonder;
        private System.Windows.Forms.Timer Zamanlayici;
        private System.Windows.Forms.Label LblSure;
    }
}

