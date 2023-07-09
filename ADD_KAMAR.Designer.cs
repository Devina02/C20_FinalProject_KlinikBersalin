namespace FinalProject_KlinikBersalin
{
    partial class ADD_KAMAR
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kamarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klinikBersalinDataSet = new FinalProject_KlinikBersalin.KlinikBersalinDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kamarTableAdapter = new FinalProject_KlinikBersalin.KlinikBersalinDataSetTableAdapters.KamarTableAdapter();
            this.btnclear = new System.Windows.Forms.Button();
            this.pasienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klinikBersalinDataSet1 = new FinalProject_KlinikBersalin.KlinikBersalinDataSet();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.pasienTableAdapter = new FinalProject_KlinikBersalin.KlinikBersalinDataSetTableAdapters.PasienTableAdapter();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxidkamar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tbxhargakamar = new System.Windows.Forms.TextBox();
            this.tbxjeniskmr = new System.Windows.Forms.TextBox();
            this.tbxnmkamar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namaKamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaKamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPasienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.txbxpasien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kamarBindingSource
            // 
            this.kamarBindingSource.DataMember = "Kamar";
            this.kamarBindingSource.DataSource = this.klinikBersalinDataSet;
            // 
            // klinikBersalinDataSet
            // 
            this.klinikBersalinDataSet.DataSetName = "KlinikBersalinDataSet";
            this.klinikBersalinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(232, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 45);
            this.label7.TabIndex = 20;
            this.label7.Text = "KAMAR";
            // 
            // kamarTableAdapter
            // 
            this.kamarTableAdapter.ClearBeforeFill = true;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnclear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclear.Location = new System.Drawing.Point(334, 515);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(141, 50);
            this.btnclear.TabIndex = 26;
            this.btnclear.Text = "Clear Data";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // pasienBindingSource
            // 
            this.pasienBindingSource.DataMember = "Pasien";
            this.pasienBindingSource.DataSource = this.klinikBersalinDataSet1;
            // 
            // klinikBersalinDataSet1
            // 
            this.klinikBersalinDataSet1.DataSetName = "KlinikBersalinDataSet";
            this.klinikBersalinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.RosyBrown;
            this.btnsimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsimpan.Location = new System.Drawing.Point(334, 460);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(141, 49);
            this.btnsimpan.TabIndex = 23;
            this.btnsimpan.Text = "Simpan Data";
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // pasienTableAdapter
            // 
            this.pasienTableAdapter.ClearBeforeFill = true;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.SlateGray;
            this.btnadd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadd.Location = new System.Drawing.Point(334, 407);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(141, 47);
            this.btnadd.TabIndex = 25;
            this.btnadd.Text = "Add Data";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.tbxidkamar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.tbxhargakamar);
            this.panel1.Controls.Add(this.tbxjeniskmr);
            this.panel1.Controls.Add(this.tbxnmkamar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(176, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 111);
            this.panel1.TabIndex = 22;
            // 
            // tbxidkamar
            // 
            this.tbxidkamar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasienBindingSource, "No_Telp", true));
            this.tbxidkamar.Location = new System.Drawing.Point(367, 43);
            this.tbxidkamar.Name = "tbxidkamar";
            this.tbxidkamar.Size = new System.Drawing.Size(138, 26);
            this.tbxidkamar.TabIndex = 9;
            this.tbxidkamar.TextChanged += new System.EventHandler(this.tbxidkamar_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(372, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Id Kamar";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasienBindingSource, "Id_Pasien", true));
            this.textBox4.Location = new System.Drawing.Point(684, 44);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 26);
            this.textBox4.TabIndex = 7;
            // 
            // tbxhargakamar
            // 
            this.tbxhargakamar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasienBindingSource, "Alamat", true));
            this.tbxhargakamar.Location = new System.Drawing.Point(524, 43);
            this.tbxhargakamar.Name = "tbxhargakamar";
            this.tbxhargakamar.Size = new System.Drawing.Size(138, 26);
            this.tbxhargakamar.TabIndex = 6;
            // 
            // tbxjeniskmr
            // 
            this.tbxjeniskmr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasienBindingSource, "No_Telp", true));
            this.tbxjeniskmr.Location = new System.Drawing.Point(197, 44);
            this.tbxjeniskmr.Name = "tbxjeniskmr";
            this.tbxjeniskmr.Size = new System.Drawing.Size(152, 26);
            this.tbxjeniskmr.TabIndex = 5;
            // 
            // tbxnmkamar
            // 
            this.tbxnmkamar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasienBindingSource, "Nama_Pasien", true));
            this.tbxnmkamar.Location = new System.Drawing.Point(19, 45);
            this.tbxnmkamar.Name = "tbxnmkamar";
            this.tbxnmkamar.Size = new System.Drawing.Size(160, 26);
            this.tbxnmkamar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(690, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id Pasien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(521, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga Kamar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(192, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Kamar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(17, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nama Kamar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaKamarDataGridViewTextBoxColumn,
            this.idKamarDataGridViewTextBoxColumn,
            this.hargaKamarDataGridViewTextBoxColumn,
            this.jenisKamarDataGridViewTextBoxColumn,
            this.idPasienDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kamarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(176, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(799, 199);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // namaKamarDataGridViewTextBoxColumn
            // 
            this.namaKamarDataGridViewTextBoxColumn.DataPropertyName = "Nama_Kamar";
            this.namaKamarDataGridViewTextBoxColumn.HeaderText = "Nama_Kamar";
            this.namaKamarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaKamarDataGridViewTextBoxColumn.Name = "namaKamarDataGridViewTextBoxColumn";
            this.namaKamarDataGridViewTextBoxColumn.Width = 150;
            // 
            // idKamarDataGridViewTextBoxColumn
            // 
            this.idKamarDataGridViewTextBoxColumn.DataPropertyName = "Id_Kamar";
            this.idKamarDataGridViewTextBoxColumn.HeaderText = "Id_Kamar";
            this.idKamarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idKamarDataGridViewTextBoxColumn.Name = "idKamarDataGridViewTextBoxColumn";
            this.idKamarDataGridViewTextBoxColumn.Width = 150;
            // 
            // hargaKamarDataGridViewTextBoxColumn
            // 
            this.hargaKamarDataGridViewTextBoxColumn.DataPropertyName = "Harga_Kamar";
            this.hargaKamarDataGridViewTextBoxColumn.HeaderText = "Harga_Kamar";
            this.hargaKamarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hargaKamarDataGridViewTextBoxColumn.Name = "hargaKamarDataGridViewTextBoxColumn";
            this.hargaKamarDataGridViewTextBoxColumn.Width = 150;
            // 
            // jenisKamarDataGridViewTextBoxColumn
            // 
            this.jenisKamarDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Kamar";
            this.jenisKamarDataGridViewTextBoxColumn.HeaderText = "Jenis_Kamar";
            this.jenisKamarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jenisKamarDataGridViewTextBoxColumn.Name = "jenisKamarDataGridViewTextBoxColumn";
            this.jenisKamarDataGridViewTextBoxColumn.Width = 150;
            // 
            // idPasienDataGridViewTextBoxColumn
            // 
            this.idPasienDataGridViewTextBoxColumn.DataPropertyName = "Id_Pasien";
            this.idPasienDataGridViewTextBoxColumn.HeaderText = "Id_Pasien";
            this.idPasienDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idPasienDataGridViewTextBoxColumn.Name = "idPasienDataGridViewTextBoxColumn";
            this.idPasienDataGridViewTextBoxColumn.Width = 150;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(13, 392);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 63);
            this.button6.TabIndex = 51;
            this.button6.Text = "Obat";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSlateGray;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(13, 474);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 65);
            this.button5.TabIndex = 50;
            this.button5.Text = "Rekam Medis";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.CadetBlue;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(12, 304);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 65);
            this.button7.TabIndex = 49;
            this.button7.Text = "Kamar";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(13, 216);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 67);
            this.button8.TabIndex = 48;
            this.button8.Text = "Petugas";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.RosyBrown;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(12, 130);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(141, 66);
            this.button9.TabIndex = 47;
            this.button9.Text = "Dokter";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.SlateGray;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(12, 43);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(141, 64);
            this.button10.TabIndex = 46;
            this.button10.Text = "Pasien";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // txbxpasien
            // 
            this.txbxpasien.Location = new System.Drawing.Point(546, 483);
            this.txbxpasien.Name = "txbxpasien";
            this.txbxpasien.Size = new System.Drawing.Size(100, 26);
            this.txbxpasien.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(546, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 27);
            this.label8.TabIndex = 53;
            this.label8.Text = "Id_Pasien";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(663, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 54);
            this.button1.TabIndex = 52;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ADD_KAMAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1025, 583);
            this.Controls.Add(this.txbxpasien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "ADD_KAMAR";
            this.Text = "ADD_KAMAR";
            this.Load += new System.EventHandler(this.ADD_KAMAR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private KlinikBersalinDataSet klinikBersalinDataSet;
        private System.Windows.Forms.BindingSource kamarBindingSource;
        private KlinikBersalinDataSetTableAdapters.KamarTableAdapter kamarTableAdapter;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.BindingSource pasienBindingSource;
        private KlinikBersalinDataSet klinikBersalinDataSet1;
        private System.Windows.Forms.Button btnsimpan;
        private KlinikBersalinDataSetTableAdapters.PasienTableAdapter pasienTableAdapter;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tbxhargakamar;
        private System.Windows.Forms.TextBox tbxjeniskmr;
        private System.Windows.Forms.TextBox tbxnmkamar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaKamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPasienDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbxidkamar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox txbxpasien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}