namespace P10_1_714220068.view
{
    partial class FormTransaksiBarang
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
            this.gb_transaksibarang = new System.Windows.Forms.GroupBox();
            this.DataTransaksiBarang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.id_barang = new System.Windows.Forms.ComboBox();
            this.harga_barang = new System.Windows.Forms.TextBox();
            this.label_harga = new System.Windows.Forms.Label();
            this.nama_barang = new System.Windows.Forms.TextBox();
            this.label_barang = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_form_transaksibarang = new System.Windows.Forms.GroupBox();
            this.total = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_qty = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.TextBox();
            this.label_id_barang = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.gb_tbl_admin = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.label_caridata = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_transaksibarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksiBarang)).BeginInit();
            this.gb_form_transaksibarang.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_tbl_admin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_transaksibarang
            // 
            this.gb_transaksibarang.Controls.Add(this.DataTransaksiBarang);
            this.gb_transaksibarang.Location = new System.Drawing.Point(1, 4);
            this.gb_transaksibarang.Margin = new System.Windows.Forms.Padding(4);
            this.gb_transaksibarang.Name = "gb_transaksibarang";
            this.gb_transaksibarang.Padding = new System.Windows.Forms.Padding(4);
            this.gb_transaksibarang.Size = new System.Drawing.Size(984, 231);
            this.gb_transaksibarang.TabIndex = 12;
            this.gb_transaksibarang.TabStop = false;
            this.gb_transaksibarang.Text = "Table Transaksi Barang";
            // 
            // DataTransaksiBarang
            // 
            this.DataTransaksiBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTransaksiBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTransaksiBarang.Location = new System.Drawing.Point(13, 23);
            this.DataTransaksiBarang.Margin = new System.Windows.Forms.Padding(4);
            this.DataTransaksiBarang.Name = "DataTransaksiBarang";
            this.DataTransaksiBarang.RowHeadersWidth = 51;
            this.DataTransaksiBarang.Size = new System.Drawing.Size(948, 201);
            this.DataTransaksiBarang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rp.";
            // 
            // id_barang
            // 
            this.id_barang.FormattingEnabled = true;
            this.id_barang.Location = new System.Drawing.Point(8, 14);
            this.id_barang.Margin = new System.Windows.Forms.Padding(4);
            this.id_barang.Name = "id_barang";
            this.id_barang.Size = new System.Drawing.Size(193, 24);
            this.id_barang.TabIndex = 0;
            // 
            // harga_barang
            // 
            this.harga_barang.Location = new System.Drawing.Point(243, 74);
            this.harga_barang.Margin = new System.Windows.Forms.Padding(4);
            this.harga_barang.Name = "harga_barang";
            this.harga_barang.Size = new System.Drawing.Size(197, 22);
            this.harga_barang.TabIndex = 7;
            // 
            // label_harga
            // 
            this.label_harga.AutoSize = true;
            this.label_harga.Location = new System.Drawing.Point(239, 54);
            this.label_harga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_harga.Name = "label_harga";
            this.label_harga.Size = new System.Drawing.Size(92, 16);
            this.label_harga.TabIndex = 1;
            this.label_harga.Text = "Harga Barang";
            // 
            // nama_barang
            // 
            this.nama_barang.Location = new System.Drawing.Point(8, 74);
            this.nama_barang.Margin = new System.Windows.Forms.Padding(4);
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.Size = new System.Drawing.Size(193, 22);
            this.nama_barang.TabIndex = 6;
            // 
            // label_barang
            // 
            this.label_barang.AutoSize = true;
            this.label_barang.Location = new System.Drawing.Point(7, 54);
            this.label_barang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_barang.Name = "label_barang";
            this.label_barang.Size = new System.Drawing.Size(91, 16);
            this.label_barang.TabIndex = 0;
            this.label_barang.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Rp.";
            // 
            // gb_form_transaksibarang
            // 
            this.gb_form_transaksibarang.Controls.Add(this.label3);
            this.gb_form_transaksibarang.Controls.Add(this.total);
            this.gb_form_transaksibarang.Controls.Add(this.label2);
            this.gb_form_transaksibarang.Controls.Add(this.label_qty);
            this.gb_form_transaksibarang.Controls.Add(this.qty);
            this.gb_form_transaksibarang.Controls.Add(this.label_id_barang);
            this.gb_form_transaksibarang.Controls.Add(this.groupBox2);
            this.gb_form_transaksibarang.Location = new System.Drawing.Point(1, 243);
            this.gb_form_transaksibarang.Margin = new System.Windows.Forms.Padding(4);
            this.gb_form_transaksibarang.Name = "gb_form_transaksibarang";
            this.gb_form_transaksibarang.Padding = new System.Windows.Forms.Padding(4);
            this.gb_form_transaksibarang.Size = new System.Drawing.Size(568, 235);
            this.gb_form_transaksibarang.TabIndex = 13;
            this.gb_form_transaksibarang.TabStop = false;
            this.gb_form_transaksibarang.Text = "Form Transaksi Barang";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(109, 191);
            this.total.Margin = new System.Windows.Forms.Padding(4);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(195, 22);
            this.total.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total";
            // 
            // label_qty
            // 
            this.label_qty.AutoSize = true;
            this.label_qty.Location = new System.Drawing.Point(19, 155);
            this.label_qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_qty.Name = "label_qty";
            this.label_qty.Size = new System.Drawing.Size(55, 16);
            this.label_qty.TabIndex = 15;
            this.label_qty.Text = "Quantity";
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(109, 151);
            this.qty.Margin = new System.Windows.Forms.Padding(4);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(195, 22);
            this.qty.TabIndex = 14;
            // 
            // label_id_barang
            // 
            this.label_id_barang.AutoSize = true;
            this.label_id_barang.Location = new System.Drawing.Point(19, 38);
            this.label_id_barang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id_barang.Name = "label_id_barang";
            this.label_id_barang.Size = new System.Drawing.Size(65, 16);
            this.label_id_barang.TabIndex = 13;
            this.label_id_barang.Text = "Id Barang";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.id_barang);
            this.groupBox2.Controls.Add(this.harga_barang);
            this.groupBox2.Controls.Add(this.label_harga);
            this.groupBox2.Controls.Add(this.nama_barang);
            this.groupBox2.Controls.Add(this.label_barang);
            this.groupBox2.Location = new System.Drawing.Point(103, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(457, 123);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(20, 108);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(4);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(365, 28);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(20, 69);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(365, 28);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(20, 150);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(365, 28);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // gb_tbl_admin
            // 
            this.gb_tbl_admin.Controls.Add(this.btnHapus);
            this.gb_tbl_admin.Controls.Add(this.btnUbah);
            this.gb_tbl_admin.Controls.Add(this.btnSimpan);
            this.gb_tbl_admin.Controls.Add(this.btnRefresh);
            this.gb_tbl_admin.Location = new System.Drawing.Point(577, 344);
            this.gb_tbl_admin.Margin = new System.Windows.Forms.Padding(4);
            this.gb_tbl_admin.Name = "gb_tbl_admin";
            this.gb_tbl_admin.Padding = new System.Windows.Forms.Padding(4);
            this.gb_tbl_admin.Size = new System.Drawing.Size(408, 190);
            this.gb_tbl_admin.TabIndex = 14;
            this.gb_tbl_admin.TabStop = false;
            this.gb_tbl_admin.Text = "Tombol Admin";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(20, 28);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(365, 28);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(113, 34);
            this.tbCariData.Margin = new System.Windows.Forms.Padding(4);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(241, 22);
            this.tbCariData.TabIndex = 12;
            // 
            // label_caridata
            // 
            this.label_caridata.AutoSize = true;
            this.label_caridata.Location = new System.Drawing.Point(8, 38);
            this.label_caridata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_caridata.Name = "label_caridata";
            this.label_caridata.Size = new System.Drawing.Size(63, 16);
            this.label_caridata.TabIndex = 12;
            this.label_caridata.Text = "Cari Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCariData);
            this.groupBox1.Controls.Add(this.label_caridata);
            this.groupBox1.Location = new System.Drawing.Point(577, 252);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(385, 85);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Pencarian";
            // 
            // FormTransaksiBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 546);
            this.Controls.Add(this.gb_transaksibarang);
            this.Controls.Add(this.gb_form_transaksibarang);
            this.Controls.Add(this.gb_tbl_admin);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTransaksiBarang";
            this.Text = "FormTransaksiBarang";
            this.gb_transaksibarang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksiBarang)).EndInit();
            this.gb_form_transaksibarang.ResumeLayout(false);
            this.gb_form_transaksibarang.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gb_tbl_admin.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_transaksibarang;
        private System.Windows.Forms.DataGridView DataTransaksiBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox id_barang;
        private System.Windows.Forms.TextBox harga_barang;
        private System.Windows.Forms.Label label_harga;
        private System.Windows.Forms.TextBox nama_barang;
        private System.Windows.Forms.Label label_barang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_form_transaksibarang;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_qty;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.Label label_id_barang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.GroupBox gb_tbl_admin;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Label label_caridata;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}