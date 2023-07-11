namespace FinalProject_KlinikBersalin
{
    partial class ADD_REKAM_MEDIS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbxidobat = new System.Windows.Forms.ComboBox();
            this.txbxIDRM = new System.Windows.Forms.TextBox();
            this.cmbxidpasien = new System.Windows.Forms.ComboBox();
            this.cmbxiddokter = new System.Windows.Forms.ComboBox();
            this.tbxjumlahobat = new System.Windows.Forms.TextBox();
            this.rekamMedisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klinikBersalinDataSet = new FinalProject_KlinikBersalin.KlinikBersalinDataSet();
            this.tbxtindakan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxriwayat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rekamMedisTableAdapter = new FinalProject_KlinikBersalin.KlinikBersalinDataSetTableAdapters.RekamMedisTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDokterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPasienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riwayatPenyakitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tindakanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglresepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRekamMedisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.klinikBersalinDataSet1 = new FinalProject_KlinikBersalin.KlinikBersalinDataSet();
            this.btncetak = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.klinikBersalinDataSet2 = new FinalProject_KlinikBersalin.KlinikBersalinDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rekamMedisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.cmbxidobat);
            this.panel1.Controls.Add(this.cmbxidpasien);
            this.panel1.Controls.Add(this.cmbxiddokter);
            this.panel1.Controls.Add(this.tbxjumlahobat);
            this.panel1.Controls.Add(this.tbxtindakan);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbxriwayat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(163, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 214);
            this.panel1.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(479, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // cmbxidobat
            // 
            this.cmbxidobat.FormattingEnabled = true;
            this.cmbxidobat.Location = new System.Drawing.Point(381, 68);
            this.cmbxidobat.Name = "cmbxidobat";
            this.cmbxidobat.Size = new System.Drawing.Size(142, 28);
            this.cmbxidobat.TabIndex = 19;
            // 
            // txbxIDRM
            // 
            this.txbxIDRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxIDRM.Location = new System.Drawing.Point(15, 60);
            this.txbxIDRM.Name = "txbxIDRM";
            this.txbxIDRM.Size = new System.Drawing.Size(165, 30);
            this.txbxIDRM.TabIndex = 57;
            this.txbxIDRM.TextChanged += new System.EventHandler(this.txbxIDRM_TextChanged);
            // 
            // cmbxidpasien
            // 
            this.cmbxidpasien.FormattingEnabled = true;
            this.cmbxidpasien.Location = new System.Drawing.Point(209, 68);
            this.cmbxidpasien.Name = "cmbxidpasien";
            this.cmbxidpasien.Size = new System.Drawing.Size(142, 28);
            this.cmbxidpasien.TabIndex = 18;
            // 
            // cmbxiddokter
            // 
            this.cmbxiddokter.FormattingEnabled = true;
            this.cmbxiddokter.Location = new System.Drawing.Point(32, 68);
            this.cmbxiddokter.Name = "cmbxiddokter";
            this.cmbxiddokter.Size = new System.Drawing.Size(142, 28);
            this.cmbxiddokter.TabIndex = 17;
            // 
            // tbxjumlahobat
            // 
            this.tbxjumlahobat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rekamMedisBindingSource, "Jumlah_Obat", true));
            this.tbxjumlahobat.Location = new System.Drawing.Point(551, 70);
            this.tbxjumlahobat.Name = "tbxjumlahobat";
            this.tbxjumlahobat.Size = new System.Drawing.Size(137, 26);
            this.tbxjumlahobat.TabIndex = 14;
            this.tbxjumlahobat.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // rekamMedisBindingSource
            // 
            this.rekamMedisBindingSource.DataMember = "RekamMedis";
            this.rekamMedisBindingSource.DataSource = this.klinikBersalinDataSet;
            // 
            // klinikBersalinDataSet
            // 
            this.klinikBersalinDataSet.DataSetName = "KlinikBersalinDataSet";
            this.klinikBersalinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbxtindakan
            // 
            this.tbxtindakan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rekamMedisBindingSource, "Tindakan", true));
            this.tbxtindakan.Location = new System.Drawing.Point(277, 165);
            this.tbxtindakan.Name = "tbxtindakan";
            this.tbxtindakan.Size = new System.Drawing.Size(147, 26);
            this.tbxtindakan.TabIndex = 12;
            this.tbxtindakan.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(290, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 26);
            this.label10.TabIndex = 11;
            this.label10.Text = "Tindakan";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(479, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 26);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tgl Resep";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(546, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 26);
            this.label8.TabIndex = 9;
            this.label8.Text = "Jumlah Obat";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(10, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Id Rekam Medis";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbxriwayat
            // 
            this.tbxriwayat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rekamMedisBindingSource, "Riwayat_Penyakit", true));
            this.tbxriwayat.Location = new System.Drawing.Point(74, 167);
            this.tbxriwayat.Name = "tbxriwayat";
            this.tbxriwayat.Size = new System.Drawing.Size(154, 26);
            this.tbxriwayat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(60, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Riwayat Penyakit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(380, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Obat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(210, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Pasien";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(27, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Id Dokter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 23;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.SlateGray;
            this.btnadd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadd.Location = new System.Drawing.Point(934, 291);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(183, 47);
            this.btnadd.TabIndex = 25;
            this.btnadd.Text = "Add Data";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(204, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 45);
            this.label7.TabIndex = 24;
            this.label7.Text = "REKAM MEDIS";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // rekamMedisTableAdapter
            // 
            this.rekamMedisTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDokterDataGridViewTextBoxColumn,
            this.idPasienDataGridViewTextBoxColumn,
            this.idObatDataGridViewTextBoxColumn,
            this.riwayatPenyakitDataGridViewTextBoxColumn,
            this.tindakanDataGridViewTextBoxColumn,
            this.tglresepDataGridViewTextBoxColumn,
            this.jumlahObatDataGridViewTextBoxColumn,
            this.idRekamMedisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rekamMedisBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Location = new System.Drawing.Point(159, 75);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1113, 180);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDokterDataGridViewTextBoxColumn
            // 
            this.idDokterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDokterDataGridViewTextBoxColumn.DataPropertyName = "Id_Dokter";
            this.idDokterDataGridViewTextBoxColumn.HeaderText = "Id_Dokter";
            this.idDokterDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDokterDataGridViewTextBoxColumn.Name = "idDokterDataGridViewTextBoxColumn";
            // 
            // idPasienDataGridViewTextBoxColumn
            // 
            this.idPasienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idPasienDataGridViewTextBoxColumn.DataPropertyName = "Id_Pasien";
            this.idPasienDataGridViewTextBoxColumn.HeaderText = "Id_Pasien";
            this.idPasienDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idPasienDataGridViewTextBoxColumn.Name = "idPasienDataGridViewTextBoxColumn";
            // 
            // idObatDataGridViewTextBoxColumn
            // 
            this.idObatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idObatDataGridViewTextBoxColumn.DataPropertyName = "Id_Obat";
            this.idObatDataGridViewTextBoxColumn.HeaderText = "Id_Obat";
            this.idObatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idObatDataGridViewTextBoxColumn.Name = "idObatDataGridViewTextBoxColumn";
            // 
            // riwayatPenyakitDataGridViewTextBoxColumn
            // 
            this.riwayatPenyakitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.riwayatPenyakitDataGridViewTextBoxColumn.DataPropertyName = "Riwayat_Penyakit";
            this.riwayatPenyakitDataGridViewTextBoxColumn.HeaderText = "Riwayat_Penyakit";
            this.riwayatPenyakitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.riwayatPenyakitDataGridViewTextBoxColumn.Name = "riwayatPenyakitDataGridViewTextBoxColumn";
            // 
            // tindakanDataGridViewTextBoxColumn
            // 
            this.tindakanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tindakanDataGridViewTextBoxColumn.DataPropertyName = "Tindakan";
            this.tindakanDataGridViewTextBoxColumn.HeaderText = "Tindakan";
            this.tindakanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tindakanDataGridViewTextBoxColumn.Name = "tindakanDataGridViewTextBoxColumn";
            // 
            // tglresepDataGridViewTextBoxColumn
            // 
            this.tglresepDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tglresepDataGridViewTextBoxColumn.DataPropertyName = "Tgl_resep";
            this.tglresepDataGridViewTextBoxColumn.HeaderText = "Tgl_resep";
            this.tglresepDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tglresepDataGridViewTextBoxColumn.Name = "tglresepDataGridViewTextBoxColumn";
            // 
            // jumlahObatDataGridViewTextBoxColumn
            // 
            this.jumlahObatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jumlahObatDataGridViewTextBoxColumn.DataPropertyName = "Jumlah_Obat";
            this.jumlahObatDataGridViewTextBoxColumn.HeaderText = "Jumlah_Obat";
            this.jumlahObatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jumlahObatDataGridViewTextBoxColumn.Name = "jumlahObatDataGridViewTextBoxColumn";
            // 
            // idRekamMedisDataGridViewTextBoxColumn
            // 
            this.idRekamMedisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idRekamMedisDataGridViewTextBoxColumn.DataPropertyName = "Id_Rekam_Medis";
            this.idRekamMedisDataGridViewTextBoxColumn.HeaderText = "Id_Rekam_Medis";
            this.idRekamMedisDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idRekamMedisDataGridViewTextBoxColumn.Name = "idRekamMedisDataGridViewTextBoxColumn";
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.RosyBrown;
            this.btnsimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsimpan.Location = new System.Drawing.Point(934, 351);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(183, 47);
            this.btnsimpan.TabIndex = 28;
            this.btnsimpan.Text = "Simpan Data";
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnclear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclear.Location = new System.Drawing.Point(934, 473);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(183, 47);
            this.btnclear.TabIndex = 29;
            this.btnclear.Text = "Clear Data";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // klinikBersalinDataSet1
            // 
            this.klinikBersalinDataSet1.DataSetName = "KlinikBersalinDataSet";
            this.klinikBersalinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btncetak
            // 
            this.btncetak.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btncetak.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncetak.Location = new System.Drawing.Point(934, 413);
            this.btncetak.Name = "btncetak";
            this.btncetak.Size = new System.Drawing.Size(183, 47);
            this.btncetak.TabIndex = 30;
            this.btncetak.Text = "Cetak Rekam Medis";
            this.btncetak.UseVisualStyleBackColor = false;
            this.btncetak.Click += new System.EventHandler(this.btncetak_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(13, 329);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 63);
            this.button6.TabIndex = 45;
            this.button6.Text = "Obat";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSlateGray;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(13, 398);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 65);
            this.button5.TabIndex = 44;
            this.button5.Text = "Rekam Medis";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.CadetBlue;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(12, 259);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 65);
            this.button7.TabIndex = 43;
            this.button7.Text = "Kamar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(13, 185);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 67);
            this.button8.TabIndex = 42;
            this.button8.Text = "Petugas";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.RosyBrown;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(12, 113);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(141, 66);
            this.button9.TabIndex = 41;
            this.button9.Text = "Dokter";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.SlateGray;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(12, 42);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(141, 64);
            this.button10.TabIndex = 40;
            this.button10.Text = "Pasien";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightSlateGray;
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(46, 100);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(107, 54);
            this.button11.TabIndex = 55;
            this.button11.Text = "Delete";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.DarkKhaki;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button13.Location = new System.Drawing.Point(13, 472);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(140, 65);
            this.button13.TabIndex = 60;
            this.button13.Text = "Shift";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // klinikBersalinDataSet2
            // 
            this.klinikBersalinDataSet2.DataSetName = "KlinikBersalinDataSet";
            this.klinikBersalinDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(46, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 52);
            this.button1.TabIndex = 61;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txbxIDRM);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(1140, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 226);
            this.panel2.TabIndex = 62;
            // 
            // ADD_REKAM_MEDIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1361, 578);
            this.Controls.Add(this.btncetak);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "ADD_REKAM_MEDIS";
            this.Text = "ADD_REKAM_MEDIS";
            this.Load += new System.EventHandler(this.ADD_REKAM_MEDIS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rekamMedisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxriwayat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxjumlahobat;
        private System.Windows.Forms.TextBox tbxtindakan;
        private KlinikBersalinDataSet klinikBersalinDataSet;
        private System.Windows.Forms.BindingSource rekamMedisBindingSource;
        private KlinikBersalinDataSetTableAdapters.RekamMedisTableAdapter rekamMedisTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnclear;
        private KlinikBersalinDataSet klinikBersalinDataSet1;
        private System.Windows.Forms.Button btncetak;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDokterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPasienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn riwayatPenyakitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tindakanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglresepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRekamMedisDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txbxIDRM;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ComboBox cmbxidobat;
        private System.Windows.Forms.ComboBox cmbxidpasien;
        private System.Windows.Forms.ComboBox cmbxiddokter;
        private KlinikBersalinDataSet klinikBersalinDataSet2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}