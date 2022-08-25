
namespace Kasir_Restaurant
{
    partial class FrmEntriPesanMakanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntriPesanMakanan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbox_cari = new System.Windows.Forms.TextBox();
            this.tbox_hargamenu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.tbox_namamenu = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_hapusitem = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbox_jh = new System.Windows.Forms.TextBox();
            this.btn_hitung = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbox_jp = new System.Windows.Forms.TextBox();
            this.cbox_iduser = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbox_namauser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbox_idpelanggan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_namapelanggan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbox_idmenu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_idpesanan = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.tbl_pesan = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pesan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.tbox_hargamenu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_tambah);
            this.panel1.Controls.Add(this.tbox_namamenu);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.btn_hapusitem);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tbox_jh);
            this.panel1.Controls.Add(this.btn_hitung);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbox_jp);
            this.panel1.Controls.Add(this.cbox_iduser);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbox_namauser);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbox_idpelanggan);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbox_namapelanggan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbox_idmenu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbox_idpesanan);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.btn_hapus);
            this.panel1.Controls.Add(this.btn_ubah);
            this.panel1.Controls.Add(this.btn_simpan);
            this.panel1.Controls.Add(this.tbl_pesan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 643);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbox_cari);
            this.groupBox1.Location = new System.Drawing.Point(31, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 53);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Data Pesanan";
            // 
            // tbox_cari
            // 
            this.tbox_cari.Location = new System.Drawing.Point(6, 22);
            this.tbox_cari.Name = "tbox_cari";
            this.tbox_cari.Size = new System.Drawing.Size(465, 23);
            this.tbox_cari.TabIndex = 33;
            this.tbox_cari.TextChanged += new System.EventHandler(this.tbox_cari_TextChanged);
            // 
            // tbox_hargamenu
            // 
            this.tbox_hargamenu.Location = new System.Drawing.Point(140, 173);
            this.tbox_hargamenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_hargamenu.Name = "tbox_hargamenu";
            this.tbox_hargamenu.Size = new System.Drawing.Size(231, 23);
            this.tbox_hargamenu.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "Harga Menu";
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.Color.DimGray;
            this.btn_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tambah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_tambah.Image = ((System.Drawing.Image)(resources.GetObject("btn_tambah.Image")));
            this.btn_tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tambah.Location = new System.Drawing.Point(518, 354);
            this.btn_tambah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(119, 43);
            this.btn_tambah.TabIndex = 56;
            this.btn_tambah.TabStop = false;
            this.btn_tambah.Text = "Tambah Item";
            this.btn_tambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tambah.UseVisualStyleBackColor = false;
            this.btn_tambah.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbox_namamenu
            // 
            this.tbox_namamenu.Location = new System.Drawing.Point(140, 142);
            this.tbox_namamenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_namamenu.Name = "tbox_namamenu";
            this.tbox_namamenu.Size = new System.Drawing.Size(231, 23);
            this.tbox_namamenu.TabIndex = 55;
            this.tbox_namamenu.TextChanged += new System.EventHandler(this.tbox_namamenu_TextChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(642, 105);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(119, 244);
            this.listBox2.TabIndex = 54;
            // 
            // btn_hapusitem
            // 
            this.btn_hapusitem.BackColor = System.Drawing.Color.DimGray;
            this.btn_hapusitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hapusitem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_hapusitem.Image = ((System.Drawing.Image)(resources.GetObject("btn_hapusitem.Image")));
            this.btn_hapusitem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hapusitem.Location = new System.Drawing.Point(642, 354);
            this.btn_hapusitem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_hapusitem.Name = "btn_hapusitem";
            this.btn_hapusitem.Size = new System.Drawing.Size(119, 43);
            this.btn_hapusitem.TabIndex = 52;
            this.btn_hapusitem.TabStop = false;
            this.btn_hapusitem.Text = "Hapus Items ";
            this.btn_hapusitem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hapusitem.UseVisualStyleBackColor = false;
            this.btn_hapusitem.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DimGray;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(642, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 23);
            this.label12.TabIndex = 51;
            this.label12.Text = "Harga Menu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DimGray;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(520, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 23);
            this.label11.TabIndex = 50;
            this.label11.Text = "Nama Menu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 16);
            this.label10.TabIndex = 49;
            this.label10.Text = "Jumlah Harga";
            // 
            // tbox_jh
            // 
            this.tbox_jh.Location = new System.Drawing.Point(140, 298);
            this.tbox_jh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_jh.Name = "tbox_jh";
            this.tbox_jh.Size = new System.Drawing.Size(231, 23);
            this.tbox_jh.TabIndex = 48;
            // 
            // btn_hitung
            // 
            this.btn_hitung.BackColor = System.Drawing.Color.DimGray;
            this.btn_hitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hitung.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_hitung.Image = ((System.Drawing.Image)(resources.GetObject("btn_hitung.Image")));
            this.btn_hitung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hitung.Location = new System.Drawing.Point(377, 328);
            this.btn_hitung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_hitung.Name = "btn_hitung";
            this.btn_hitung.Size = new System.Drawing.Size(131, 54);
            this.btn_hitung.TabIndex = 47;
            this.btn_hitung.TabStop = false;
            this.btn_hitung.Text = "Hitung Jumlah Harga";
            this.btn_hitung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hitung.UseVisualStyleBackColor = false;
            this.btn_hitung.Click += new System.EventHandler(this.btn_hitung_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(518, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(119, 244);
            this.listBox1.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Jumlah Pesanan";
            // 
            // tbox_jp
            // 
            this.tbox_jp.Location = new System.Drawing.Point(140, 267);
            this.tbox_jp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_jp.Name = "tbox_jp";
            this.tbox_jp.Size = new System.Drawing.Size(231, 23);
            this.tbox_jp.TabIndex = 42;
            this.tbox_jp.TextChanged += new System.EventHandler(this.tbox_jp_TextChanged);
            this.tbox_jp.Leave += new System.EventHandler(this.tbox_jp_Leave);
            // 
            // cbox_iduser
            // 
            this.cbox_iduser.FormattingEnabled = true;
            this.cbox_iduser.Location = new System.Drawing.Point(140, 328);
            this.cbox_iduser.Name = "cbox_iduser";
            this.cbox_iduser.Size = new System.Drawing.Size(231, 24);
            this.cbox_iduser.TabIndex = 41;
            this.cbox_iduser.SelectedIndexChanged += new System.EventHandler(this.cbox_iduser_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Nama User";
            // 
            // tbox_namauser
            // 
            this.tbox_namauser.Location = new System.Drawing.Point(140, 359);
            this.tbox_namauser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_namauser.Name = "tbox_namauser";
            this.tbox_namauser.Size = new System.Drawing.Size(231, 23);
            this.tbox_namauser.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "ID User";
            // 
            // cbox_idpelanggan
            // 
            this.cbox_idpelanggan.FormattingEnabled = true;
            this.cbox_idpelanggan.Location = new System.Drawing.Point(140, 205);
            this.cbox_idpelanggan.Name = "cbox_idpelanggan";
            this.cbox_idpelanggan.Size = new System.Drawing.Size(231, 24);
            this.cbox_idpelanggan.TabIndex = 37;
            this.cbox_idpelanggan.SelectedIndexChanged += new System.EventHandler(this.cbox_idpelanggan_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nama Pelanggan";
            // 
            // tbox_namapelanggan
            // 
            this.tbox_namapelanggan.Location = new System.Drawing.Point(140, 236);
            this.tbox_namapelanggan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_namapelanggan.Name = "tbox_namapelanggan";
            this.tbox_namapelanggan.Size = new System.Drawing.Size(231, 23);
            this.tbox_namapelanggan.TabIndex = 35;
            this.tbox_namapelanggan.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "ID Pelanggan";
            // 
            // cbox_idmenu
            // 
            this.cbox_idmenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_idmenu.FormattingEnabled = true;
            this.cbox_idmenu.Location = new System.Drawing.Point(140, 112);
            this.cbox_idmenu.Name = "cbox_idmenu";
            this.cbox_idmenu.Size = new System.Drawing.Size(231, 24);
            this.cbox_idmenu.TabIndex = 31;
            this.cbox_idmenu.SelectedIndexChanged += new System.EventHandler(this.cbox_idmenu_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nama Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID Pesanan";
            // 
            // tbox_idpesanan
            // 
            this.tbox_idpesanan.Location = new System.Drawing.Point(140, 82);
            this.tbox_idpesanan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_idpesanan.Name = "tbox_idpesanan";
            this.tbox_idpesanan.Size = new System.Drawing.Size(231, 23);
            this.tbox_idpesanan.TabIndex = 25;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.DimGray;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(377, 267);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(131, 54);
            this.btn_reset.TabIndex = 24;
            this.btn_reset.TabStop = false;
            this.btn_reset.Text = "Reset";
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.DimGray;
            this.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hapus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_hapus.Image = ((System.Drawing.Image)(resources.GetObject("btn_hapus.Image")));
            this.btn_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hapus.Location = new System.Drawing.Point(377, 205);
            this.btn_hapus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(131, 54);
            this.btn_hapus.TabIndex = 23;
            this.btn_hapus.TabStop = false;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hapus.UseVisualStyleBackColor = false;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_ubah
            // 
            this.btn_ubah.BackColor = System.Drawing.Color.DimGray;
            this.btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ubah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ubah.Image = ((System.Drawing.Image)(resources.GetObject("btn_ubah.Image")));
            this.btn_ubah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ubah.Location = new System.Drawing.Point(377, 144);
            this.btn_ubah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(131, 54);
            this.btn_ubah.TabIndex = 22;
            this.btn_ubah.TabStop = false;
            this.btn_ubah.Text = "Ubah";
            this.btn_ubah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ubah.UseVisualStyleBackColor = false;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.Color.DimGray;
            this.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simpan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_simpan.Image = ((System.Drawing.Image)(resources.GetObject("btn_simpan.Image")));
            this.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_simpan.Location = new System.Drawing.Point(377, 82);
            this.btn_simpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(131, 54);
            this.btn_simpan.TabIndex = 21;
            this.btn_simpan.TabStop = false;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // tbl_pesan
            // 
            this.tbl_pesan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_pesan.Location = new System.Drawing.Point(15, 449);
            this.tbl_pesan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbl_pesan.Name = "tbl_pesan";
            this.tbl_pesan.Size = new System.Drawing.Size(754, 181);
            this.tbl_pesan.TabIndex = 1;
            this.tbl_pesan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_pesan_CellClick);
            // 
            // FrmEntriPesanMakanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 643);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmEntriPesanMakanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEntriPesanMakanan";
            this.Load += new System.EventHandler(this.FrmEntriPesanMakanan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pesan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tbl_pesan;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_idpesanan;
        private System.Windows.Forms.ComboBox cbox_idmenu;
        private System.Windows.Forms.ComboBox cbox_idpelanggan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_namapelanggan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbox_jp;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_hitung;
        private System.Windows.Forms.ComboBox cbox_iduser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbox_namauser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbox_jh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_hapusitem;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox tbox_namamenu;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.TextBox tbox_hargamenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbox_cari;
    }
}