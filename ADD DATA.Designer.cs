namespace FinalProject_KlinikBersalin
{
    partial class ADD_DATA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNamaPasien = new System.Windows.Forms.TextBox();
            this.pasienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klinikBersalinDataSet = new FinalProject_KlinikBersalin.KlinikBersalinDataSet();
            this.tbxTelp = new System.Windows.Forms.TextBox();
            this.tbxAlamat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pasienTableAdapter = new FinalProject_KlinikBersalin.KlinikBersalinDataSetTableAdapters.PasienTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPasienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPasienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbxpasien = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pasienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Pasien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(19, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "No Telepon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(18, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // tbxNamaPasien
            // 
            this.tbxNamaPasien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasienBindingSource, "Nama_Pasien", true));
            this.tbxNamaPasien.Location = new System.Drawing.Point(24, 50);
            this.tbxNamaPasien.Name = "tbxNamaPasien";
            this.tbxNamaPasien.Size = new System.Drawing.Size(217, 26);
            this.tbxNamaPasien.TabIndex = 4;
            this.tbxNamaPasien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pasienBindingSource
            // 
            this.pasienBindingSource.DataMember = "Pasien";
            this.pasienBindingSource.DataSource = this.klinikBersalinDataSet;
            // 
            // klinikBersalinDataSet
            // 
            this.klinikBersalinDataSet.DataSetName = "KlinikBersalinDataSet";
            this.klinikBersalinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbxTelp
            // 
            this.tbxTelp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasienBindingSource, "No_Telp", true));
            this.tbxTelp.Location = new System.Drawing.Point(24, 218);
            this.tbxTelp.Name = "tbxTelp";
            this.tbxTelp.Size = new System.Drawing.Size(217, 26);
            this.tbxTelp.TabIndex = 5;
            // 
            // tbxAlamat
            // 
            this.tbxAlamat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasienBindingSource, "Alamat", true));
            this.tbxAlamat.Location = new System.Drawing.Point(22, 134);
            this.tbxAlamat.Name = "tbxAlamat";
            this.tbxAlamat.Size = new System.Drawing.Size(219, 26);
            this.tbxAlamat.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 45);
            this.label5.TabIndex = 8;
            this.label5.Text = "DATA PASIEN";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.tbxAlamat);
            this.panel1.Controls.Add(this.tbxTelp);
            this.panel1.Controls.Add(this.tbxNamaPasien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(203, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 261);
            this.panel1.TabIndex = 9;
            // 
            // pasienTableAdapter
            // 
            this.pasienTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(645, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 61);
            this.button2.TabIndex = 10;
            this.button2.Text = "Simpan Data";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // noTelpDataGridViewTextBoxColumn
            // 
            this.noTelpDataGridViewTextBoxColumn.DataPropertyName = "No_Telp";
            this.noTelpDataGridViewTextBoxColumn.HeaderText = "No_Telp";
            this.noTelpDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.noTelpDataGridViewTextBoxColumn.Name = "noTelpDataGridViewTextBoxColumn";
            // 
            // idPasienDataGridViewTextBoxColumn
            // 
            this.idPasienDataGridViewTextBoxColumn.DataPropertyName = "Id_Pasien";
            this.idPasienDataGridViewTextBoxColumn.HeaderText = "Id_Pasien";
            this.idPasienDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idPasienDataGridViewTextBoxColumn.Name = "idPasienDataGridViewTextBoxColumn";
            // 
            // namaPasienDataGridViewTextBoxColumn
            // 
            this.namaPasienDataGridViewTextBoxColumn.DataPropertyName = "Nama_Pasien";
            this.namaPasienDataGridViewTextBoxColumn.HeaderText = "Nama_Pasien";
            this.namaPasienDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaPasienDataGridViewTextBoxColumn.Name = "namaPasienDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaPasienDataGridViewTextBoxColumn,
            this.idPasienDataGridViewTextBoxColumn,
            this.noTelpDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pasienBindingSource;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuText;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(203, 87);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(727, 212);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SlateGray;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(515, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 60);
            this.button3.TabIndex = 12;
            this.button3.Text = "Add Data";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSlateGray;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(189, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 54);
            this.button4.TabIndex = 15;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(72, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 27);
            this.label4.TabIndex = 17;
            this.label4.Text = "Id_Pasien";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // txbxpasien
            // 
            this.txbxpasien.Location = new System.Drawing.Point(72, 85);
            this.txbxpasien.Name = "txbxpasien";
            this.txbxpasien.Size = new System.Drawing.Size(100, 26);
            this.txbxpasien.TabIndex = 18;
            this.txbxpasien.TextChanged += new System.EventHandler(this.txbxpasien_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(773, 327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 61);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkKhaki;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(31, 538);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 65);
            this.button7.TabIndex = 67;
            this.button7.Text = "Shift";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(32, 380);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 63);
            this.button6.TabIndex = 66;
            this.button6.Text = "Obat";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSlateGray;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(32, 457);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 65);
            this.button5.TabIndex = 65;
            this.button5.Text = "Rekam Medis";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(31, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 65);
            this.button1.TabIndex = 64;
            this.button1.Text = "Kamar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(32, 204);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 67);
            this.button8.TabIndex = 63;
            this.button8.Text = "Petugas";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.RosyBrown;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(31, 118);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(141, 66);
            this.button9.TabIndex = 62;
            this.button9.Text = "Dokter";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.SlateGray;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(31, 31);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(141, 64);
            this.button10.TabIndex = 61;
            this.button10.Text = "Pasien";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnUpdate.Location = new System.Drawing.Point(189, 89);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(107, 47);
            this.BtnUpdate.TabIndex = 68;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.BtnUpdate);
            this.panel2.Controls.Add(this.txbxpasien);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(517, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 162);
            this.panel2.TabIndex = 69;
            // 
            // ADD_DATA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(945, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Name = "ADD_DATA";
            this.Text = "ADD_DATA";
            this.Load += new System.EventHandler(this.ADD_DATA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pasienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNamaPasien;
        private System.Windows.Forms.TextBox tbxTelp;
        private System.Windows.Forms.TextBox tbxAlamat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private KlinikBersalinDataSet klinikBersalinDataSet;
        private System.Windows.Forms.BindingSource pasienBindingSource;
        private KlinikBersalinDataSetTableAdapters.PasienTableAdapter pasienTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTelpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPasienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPasienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbxpasien;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Panel panel2;
    }
}