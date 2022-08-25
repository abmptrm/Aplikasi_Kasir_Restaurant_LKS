
namespace Kasir_Restaurant
{
    partial class FrmEntriPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntriPelanggan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_alamat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_nohp = new System.Windows.Forms.TextBox();
            this.cbox_jk = new System.Windows.Forms.ComboBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_namapelanggan = new System.Windows.Forms.TextBox();
            this.tbox_idpelanggan = new System.Windows.Forms.TextBox();
            this.tbl_pelanggan = new System.Windows.Forms.DataGridView();
            this.tbox_cari = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pelanggan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbox_alamat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbox_nohp);
            this.panel1.Controls.Add(this.cbox_jk);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.btn_hapus);
            this.panel1.Controls.Add(this.btn_ubah);
            this.panel1.Controls.Add(this.btn_simpan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbox_namapelanggan);
            this.panel1.Controls.Add(this.tbox_idpelanggan);
            this.panel1.Controls.Add(this.tbl_pelanggan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 643);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Alamat";
            // 
            // tbox_alamat
            // 
            this.tbox_alamat.Location = new System.Drawing.Point(157, 180);
            this.tbox_alamat.Name = "tbox_alamat";
            this.tbox_alamat.Size = new System.Drawing.Size(199, 23);
            this.tbox_alamat.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "No. Telpon";
            // 
            // tbox_nohp
            // 
            this.tbox_nohp.Location = new System.Drawing.Point(157, 149);
            this.tbox_nohp.Name = "tbox_nohp";
            this.tbox_nohp.Size = new System.Drawing.Size(199, 23);
            this.tbox_nohp.TabIndex = 27;
            // 
            // cbox_jk
            // 
            this.cbox_jk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_jk.FormattingEnabled = true;
            this.cbox_jk.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.cbox_jk.Location = new System.Drawing.Point(157, 119);
            this.cbox_jk.Name = "cbox_jk";
            this.cbox_jk.Size = new System.Drawing.Size(199, 24);
            this.cbox_jk.TabIndex = 26;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.DimGray;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(481, 119);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(99, 53);
            this.btn_reset.TabIndex = 25;
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
            this.btn_hapus.Location = new System.Drawing.Point(481, 64);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(99, 49);
            this.btn_hapus.TabIndex = 24;
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
            this.btn_ubah.Location = new System.Drawing.Point(374, 119);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(101, 53);
            this.btn_ubah.TabIndex = 23;
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
            this.btn_simpan.Location = new System.Drawing.Point(374, 64);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(101, 49);
            this.btn_simpan.TabIndex = 22;
            this.btn_simpan.TabStop = false;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nama Pelanggan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Pelanggan";
            // 
            // tbox_namapelanggan
            // 
            this.tbox_namapelanggan.Location = new System.Drawing.Point(157, 90);
            this.tbox_namapelanggan.Name = "tbox_namapelanggan";
            this.tbox_namapelanggan.Size = new System.Drawing.Size(199, 23);
            this.tbox_namapelanggan.TabIndex = 2;
            // 
            // tbox_idpelanggan
            // 
            this.tbox_idpelanggan.Location = new System.Drawing.Point(157, 64);
            this.tbox_idpelanggan.Name = "tbox_idpelanggan";
            this.tbox_idpelanggan.Size = new System.Drawing.Size(199, 23);
            this.tbox_idpelanggan.TabIndex = 1;
            // 
            // tbl_pelanggan
            // 
            this.tbl_pelanggan.AllowUserToAddRows = false;
            this.tbl_pelanggan.AllowUserToDeleteRows = false;
            this.tbl_pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_pelanggan.Location = new System.Drawing.Point(12, 278);
            this.tbl_pelanggan.Name = "tbl_pelanggan";
            this.tbl_pelanggan.ReadOnly = true;
            this.tbl_pelanggan.Size = new System.Drawing.Size(757, 353);
            this.tbl_pelanggan.TabIndex = 0;
            this.tbl_pelanggan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_pelanggan_CellClick);
            // 
            // tbox_cari
            // 
            this.tbox_cari.Location = new System.Drawing.Point(6, 22);
            this.tbox_cari.Name = "tbox_cari";
            this.tbox_cari.Size = new System.Drawing.Size(316, 23);
            this.tbox_cari.TabIndex = 33;
            this.tbox_cari.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbox_cari);
            this.groupBox1.Location = new System.Drawing.Point(28, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 53);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Data Pelanggan";
            // 
            // FrmEntriPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 643);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEntriPelanggan";
            this.Text = "FrmEntriMenu";
            this.Load += new System.EventHandler(this.FrmEntriPelanggan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pelanggan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_namapelanggan;
        private System.Windows.Forms.TextBox tbox_idpelanggan;
        private System.Windows.Forms.DataGridView tbl_pelanggan;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_alamat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_nohp;
        private System.Windows.Forms.ComboBox cbox_jk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbox_cari;
    }
}