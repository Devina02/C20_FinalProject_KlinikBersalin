﻿namespace FinalProject_KlinikBersalin
{
    partial class Obat
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
            this.label7 = new System.Windows.Forms.Label();
            this.obatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klinikBersalinDataSet = new FinalProject_KlinikBersalin.KlinikBersalinDataSet();
            this.obatTableAdapter = new FinalProject_KlinikBersalin.KlinikBersalinDataSetTableAdapters.ObatTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namaObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDokterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPasienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxHargaObat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxJenisObat = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbxNamaObat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnObat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 45);
            this.label7.TabIndex = 16;
            this.label7.Text = "OBAT";
            // 
            // obatBindingSource
            // 
            this.obatBindingSource.DataMember = "Obat";
            this.obatBindingSource.DataSource = this.klinikBersalinDataSet;
            // 
            // klinikBersalinDataSet
            // 
            this.klinikBersalinDataSet.DataSetName = "KlinikBersalinDataSet";
            this.klinikBersalinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obatTableAdapter
            // 
            this.obatTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaObatDataGridViewTextBoxColumn,
            this.idObatDataGridViewTextBoxColumn,
            this.hargaObatDataGridViewTextBoxColumn,
            this.jenisObatDataGridViewTextBoxColumn,
            this.idDokterDataGridViewTextBoxColumn,
            this.idPasienDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.obatBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuText;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(42, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(826, 212);
            this.dataGridView1.TabIndex = 35;
            // 
            // namaObatDataGridViewTextBoxColumn
            // 
            this.namaObatDataGridViewTextBoxColumn.DataPropertyName = "Nama_Obat";
            this.namaObatDataGridViewTextBoxColumn.HeaderText = "Nama_Obat";
            this.namaObatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaObatDataGridViewTextBoxColumn.Name = "namaObatDataGridViewTextBoxColumn";
            // 
            // idObatDataGridViewTextBoxColumn
            // 
            this.idObatDataGridViewTextBoxColumn.DataPropertyName = "Id_Obat";
            this.idObatDataGridViewTextBoxColumn.HeaderText = "Id_Obat";
            this.idObatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idObatDataGridViewTextBoxColumn.Name = "idObatDataGridViewTextBoxColumn";
            // 
            // hargaObatDataGridViewTextBoxColumn
            // 
            this.hargaObatDataGridViewTextBoxColumn.DataPropertyName = "Harga_Obat";
            this.hargaObatDataGridViewTextBoxColumn.HeaderText = "Harga_Obat";
            this.hargaObatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hargaObatDataGridViewTextBoxColumn.Name = "hargaObatDataGridViewTextBoxColumn";
            // 
            // jenisObatDataGridViewTextBoxColumn
            // 
            this.jenisObatDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Obat";
            this.jenisObatDataGridViewTextBoxColumn.HeaderText = "Jenis_Obat";
            this.jenisObatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jenisObatDataGridViewTextBoxColumn.Name = "jenisObatDataGridViewTextBoxColumn";
            // 
            // idDokterDataGridViewTextBoxColumn
            // 
            this.idDokterDataGridViewTextBoxColumn.DataPropertyName = "Id_Dokter";
            this.idDokterDataGridViewTextBoxColumn.HeaderText = "Id_Dokter";
            this.idDokterDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDokterDataGridViewTextBoxColumn.Name = "idDokterDataGridViewTextBoxColumn";
            // 
            // idPasienDataGridViewTextBoxColumn
            // 
            this.idPasienDataGridViewTextBoxColumn.DataPropertyName = "Id_Pasien";
            this.idPasienDataGridViewTextBoxColumn.HeaderText = "Id_Pasien";
            this.idPasienDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idPasienDataGridViewTextBoxColumn.Name = "idPasienDataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.tbxHargaObat);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbxJenisObat);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.tbxNamaObat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(165, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 200);
            this.panel1.TabIndex = 33;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbxHargaObat
            // 
            this.tbxHargaObat.Location = new System.Drawing.Point(311, 154);
            this.tbxHargaObat.Name = "tbxHargaObat";
            this.tbxHargaObat.Size = new System.Drawing.Size(215, 26);
            this.tbxHargaObat.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(306, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "Harga Obat";
            // 
            // tbxJenisObat
            // 
            this.tbxJenisObat.Location = new System.Drawing.Point(22, 154);
            this.tbxJenisObat.Name = "tbxJenisObat";
            this.tbxJenisObat.Size = new System.Drawing.Size(215, 26);
            this.tbxJenisObat.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(311, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 26);
            this.textBox2.TabIndex = 5;
            // 
            // tbxNamaObat
            // 
            this.tbxNamaObat.Location = new System.Drawing.Point(23, 65);
            this.tbxNamaObat.Name = "tbxNamaObat";
            this.tbxNamaObat.Size = new System.Drawing.Size(215, 26);
            this.tbxNamaObat.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(18, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Obat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(306, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Id Obat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(17, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nama Obat";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 32;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(578, 523);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 60);
            this.btnClear.TabIndex = 38;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSimpan.Location = new System.Drawing.Point(359, 523);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(157, 60);
            this.btnSimpan.TabIndex = 36;
            this.btnSimpan.Text = "Simpan Data";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnObat
            // 
            this.btnObat.BackColor = System.Drawing.Color.SlateGray;
            this.btnObat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnObat.Location = new System.Drawing.Point(147, 523);
            this.btnObat.Name = "btnObat";
            this.btnObat.Size = new System.Drawing.Size(157, 60);
            this.btnObat.TabIndex = 37;
            this.btnObat.Text = "Add Data";
            this.btnObat.UseVisualStyleBackColor = false;
            // 
            // Obat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(905, 622);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnObat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Name = "Obat";
            this.Text = "Obat";
            this.Load += new System.EventHandler(this.Obat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private KlinikBersalinDataSet klinikBersalinDataSet;
        private System.Windows.Forms.BindingSource obatBindingSource;
        private KlinikBersalinDataSetTableAdapters.ObatTableAdapter obatTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDokterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPasienDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxJenisObat;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbxNamaObat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnObat;
        private System.Windows.Forms.TextBox tbxHargaObat;
        private System.Windows.Forms.Label label8;
    }
}