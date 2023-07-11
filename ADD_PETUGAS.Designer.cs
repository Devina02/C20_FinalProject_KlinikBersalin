namespace FinalProject_KlinikBersalin
{
    partial class ADD_PETUGAS
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
            this.petugasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klinikBersalinDataSet = new FinalProject_KlinikBersalin.KlinikBersalinDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.petugasTableAdapter = new FinalProject_KlinikBersalin.KlinikBersalinDataSetTableAdapters.PetugasTableAdapter();
            this.BtnClear = new System.Windows.Forms.Button();
            this.shifttBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPetugas = new System.Windows.Forms.TextBox();
            this.tbxnama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxkamar = new System.Windows.Forms.ComboBox();
            this.shifttTableAdapter = new FinalProject_KlinikBersalin.KlinikBersalinDataSetTableAdapters.ShifttTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namaPetugasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPetugasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailPetugasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petugasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.petugasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shifttBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petugasBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // petugasBindingSource
            // 
            this.petugasBindingSource.DataMember = "Petugas";
            this.petugasBindingSource.DataSource = this.klinikBersalinDataSet;
            // 
            // klinikBersalinDataSet
            // 
            this.klinikBersalinDataSet.DataSetName = "KlinikBersalinDataSet";
            this.klinikBersalinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 14;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 13;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(193, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 45);
            this.label7.TabIndex = 16;
            this.label7.Text = "DATA PETUGAS";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // petugasTableAdapter
            // 
            this.petugasTableAdapter.ClearBeforeFill = true;
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClear.Location = new System.Drawing.Point(521, 460);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(128, 60);
            this.BtnClear.TabIndex = 31;
            this.BtnClear.Text = "Clear Data";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // shifttBindingSource
            // 
            this.shifttBindingSource.DataMember = "Shiftt";
            this.shifttBindingSource.DataSource = this.klinikBersalinDataSet;
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnSimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSimpan.Location = new System.Drawing.Point(359, 460);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(137, 60);
            this.BtnSimpan.TabIndex = 28;
            this.BtnSimpan.Text = "Simpan Data";
            this.BtnSimpan.UseVisualStyleBackColor = false;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.SlateGray;
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAdd.Location = new System.Drawing.Point(201, 460);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(134, 60);
            this.BtnAdd.TabIndex = 30;
            this.BtnAdd.Text = "Add Data";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tbxEmail
            // 
            this.tbxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petugasBindingSource, "Email_Petugas", true));
            this.tbxEmail.Location = new System.Drawing.Point(189, 91);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(215, 26);
            this.tbxEmail.TabIndex = 6;
            // 
            // tbxPetugas
            // 
            this.tbxPetugas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petugasBindingSource, "Id_Petugas", true));
            this.tbxPetugas.Location = new System.Drawing.Point(17, 69);
            this.tbxPetugas.Name = "tbxPetugas";
            this.tbxPetugas.Size = new System.Drawing.Size(111, 26);
            this.tbxPetugas.TabIndex = 5;
            // 
            // tbxnama
            // 
            this.tbxnama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petugasBindingSource, "Nama_Petugas", true));
            this.tbxnama.Location = new System.Drawing.Point(189, 32);
            this.tbxnama.Name = "tbxnama";
            this.tbxnama.Size = new System.Drawing.Size(215, 26);
            this.tbxnama.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id Kamar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nama Petugas";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox1.Controls.Add(this.cbxkamar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxEmail);
            this.groupBox1.Controls.Add(this.tbxnama);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(201, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 192);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Petugas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbxkamar
            // 
            this.cbxkamar.FormattingEnabled = true;
            this.cbxkamar.Location = new System.Drawing.Point(187, 148);
            this.cbxkamar.Name = "cbxkamar";
            this.cbxkamar.Size = new System.Drawing.Size(215, 28);
            this.cbxkamar.TabIndex = 61;
            // 
            // shifttTableAdapter
            // 
            this.shifttTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(12, 362);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 56);
            this.button6.TabIndex = 39;
            this.button6.Text = "Obat";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSlateGray;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(12, 437);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 58);
            this.button5.TabIndex = 38;
            this.button5.Text = "Rekam Medis";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CadetBlue;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(11, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 58);
            this.button4.TabIndex = 37;
            this.button4.Text = "Kamar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(12, 189);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 60);
            this.button7.TabIndex = 36;
            this.button7.Text = "Petugas";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.RosyBrown;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(11, 103);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 59);
            this.button8.TabIndex = 35;
            this.button8.Text = "Dokter";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.SlateGray;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(11, 16);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(140, 57);
            this.button9.TabIndex = 34;
            this.button9.Text = "Pasien";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(17, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 27);
            this.label8.TabIndex = 41;
            this.label8.Text = "Id_Petugas";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnDelete.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnDelete.Location = new System.Drawing.Point(164, 13);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(118, 53);
            this.BtnDelete.TabIndex = 40;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaPetugasDataGridViewTextBoxColumn,
            this.idPetugasDataGridViewTextBoxColumn,
            this.emailPetugasDataGridViewTextBoxColumn,
            this.idKamarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.petugasBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(201, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(653, 150);
            this.dataGridView1.TabIndex = 43;
            // 
            // namaPetugasDataGridViewTextBoxColumn
            // 
            this.namaPetugasDataGridViewTextBoxColumn.DataPropertyName = "Nama_Petugas";
            this.namaPetugasDataGridViewTextBoxColumn.HeaderText = "Nama_Petugas";
            this.namaPetugasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaPetugasDataGridViewTextBoxColumn.Name = "namaPetugasDataGridViewTextBoxColumn";
            this.namaPetugasDataGridViewTextBoxColumn.Width = 150;
            // 
            // idPetugasDataGridViewTextBoxColumn
            // 
            this.idPetugasDataGridViewTextBoxColumn.DataPropertyName = "Id_Petugas";
            this.idPetugasDataGridViewTextBoxColumn.HeaderText = "Id_Petugas";
            this.idPetugasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idPetugasDataGridViewTextBoxColumn.Name = "idPetugasDataGridViewTextBoxColumn";
            this.idPetugasDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailPetugasDataGridViewTextBoxColumn
            // 
            this.emailPetugasDataGridViewTextBoxColumn.DataPropertyName = "Email_Petugas";
            this.emailPetugasDataGridViewTextBoxColumn.HeaderText = "Email_Petugas";
            this.emailPetugasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailPetugasDataGridViewTextBoxColumn.Name = "emailPetugasDataGridViewTextBoxColumn";
            this.emailPetugasDataGridViewTextBoxColumn.Width = 150;
            // 
            // idKamarDataGridViewTextBoxColumn
            // 
            this.idKamarDataGridViewTextBoxColumn.DataPropertyName = "Id_Kamar";
            this.idKamarDataGridViewTextBoxColumn.HeaderText = "Id_Kamar";
            this.idKamarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idKamarDataGridViewTextBoxColumn.Name = "idKamarDataGridViewTextBoxColumn";
            this.idKamarDataGridViewTextBoxColumn.Width = 150;
            // 
            // petugasBindingSource1
            // 
            this.petugasBindingSource1.DataMember = "Petugas";
            this.petugasBindingSource1.DataSource = this.klinikBersalinDataSet;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkKhaki;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(12, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 51);
            this.button2.TabIndex = 60;
            this.button2.Text = "Shift";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.Location = new System.Drawing.Point(164, 72);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(118, 57);
            this.btnupdate.TabIndex = 61;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.tbxPetugas);
            this.panel1.Location = new System.Drawing.Point(685, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 139);
            this.panel1.TabIndex = 62;
            // 
            // ADD_PETUGAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1025, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "ADD_PETUGAS";
            this.Text = "ADD_PETUGAS";
            this.Load += new System.EventHandler(this.ADD_PETUGAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petugasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shifttBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petugasBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private KlinikBersalinDataSet klinikBersalinDataSet;
        private System.Windows.Forms.BindingSource petugasBindingSource;
        private KlinikBersalinDataSetTableAdapters.PetugasTableAdapter petugasTableAdapter;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPetugas;
        private System.Windows.Forms.TextBox tbxnama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource shifttBindingSource;
        private KlinikBersalinDataSetTableAdapters.ShifttTableAdapter shifttTableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPetugasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPetugasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailPetugasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource petugasBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbxkamar;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Panel panel1;
    }
}