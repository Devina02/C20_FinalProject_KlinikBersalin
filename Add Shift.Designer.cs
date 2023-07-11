namespace FinalProject_KlinikBersalin
{
    partial class Add_Shift
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxjamtugas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbxIdShift = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.shifttBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klinikBersalinDataSet = new FinalProject_KlinikBersalin.KlinikBersalinDataSet();
            this.klinikBersalinDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shifttTableAdapter = new FinalProject_KlinikBersalin.KlinikBersalinDataSetTableAdapters.ShifttTableAdapter();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.shifttBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idKamarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPetugasDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamTugasDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idShiftDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shifttBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.klinikBersalinDataSet1 = new FinalProject_KlinikBersalin.KlinikBersalinDataSet1();
            this.shifttTableAdapter1 = new FinalProject_KlinikBersalin.KlinikBersalinDataSet1TableAdapters.ShifttTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifttBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shifttBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shifttBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbxjamtugas);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(193, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 143);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shift Petugas";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(189, 37);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(563, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(6, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "Id Kamar";
            // 
            // tbxjamtugas
            // 
            this.tbxjamtugas.Location = new System.Drawing.Point(189, 87);
            this.tbxjamtugas.Name = "tbxjamtugas";
            this.tbxjamtugas.Size = new System.Drawing.Size(215, 26);
            this.tbxjamtugas.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(439, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "Id Petugas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(6, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "Jam Tugas";
            // 
            // txbxIdShift
            // 
            this.txbxIdShift.Location = new System.Drawing.Point(52, 54);
            this.txbxIdShift.Name = "txbxIdShift";
            this.txbxIdShift.Size = new System.Drawing.Size(97, 26);
            this.txbxIdShift.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(13, 331);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 63);
            this.button6.TabIndex = 51;
            this.button6.Text = "Obat";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSlateGray;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(13, 404);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 65);
            this.button5.TabIndex = 50;
            this.button5.Text = "Rekam Medis";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.CadetBlue;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(12, 255);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 65);
            this.button7.TabIndex = 49;
            this.button7.Text = "Kamar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(13, 175);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 67);
            this.button8.TabIndex = 48;
            this.button8.Text = "Petugas";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.RosyBrown;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(12, 97);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(141, 66);
            this.button9.TabIndex = 47;
            this.button9.Text = "Dokter";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.SlateGray;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(12, 22);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(141, 64);
            this.button10.TabIndex = 46;
            this.button10.Text = "Pasien";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(60, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 27);
            this.label1.TabIndex = 53;
            this.label1.Text = "Id_Shift";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(49, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 44);
            this.button1.TabIndex = 52;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shifttBindingSource
            // 
            this.shifttBindingSource.DataMember = "Shiftt";
            this.shifttBindingSource.DataSource = this.klinikBersalinDataSet;
            // 
            // klinikBersalinDataSet
            // 
            this.klinikBersalinDataSet.DataSetName = "KlinikBersalinDataSet";
            this.klinikBersalinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klinikBersalinDataSetBindingSource
            // 
            this.klinikBersalinDataSetBindingSource.DataSource = this.klinikBersalinDataSet;
            this.klinikBersalinDataSetBindingSource.Position = 0;
            // 
            // shifttTableAdapter
            // 
            this.shifttTableAdapter.ClearBeforeFill = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(644, 470);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 60);
            this.btnClear.TabIndex = 58;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSimpan.Location = new System.Drawing.Point(425, 470);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(157, 60);
            this.btnSimpan.TabIndex = 56;
            this.btnSimpan.Text = "Simpan Data";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SlateGray;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(203, 470);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 60);
            this.btnAdd.TabIndex = 57;
            this.btnAdd.Text = "Add Data";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(196, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 45);
            this.label7.TabIndex = 21;
            this.label7.Text = "DATA SHIFT";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkKhaki;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(13, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 65);
            this.button2.TabIndex = 59;
            this.button2.Text = "Shift";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // shifttBindingSource1
            // 
            this.shifttBindingSource1.DataMember = "Shiftt";
            this.shifttBindingSource1.DataSource = this.klinikBersalinDataSetBindingSource;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKamarDataGridViewTextBoxColumn1,
            this.idPetugasDataGridViewTextBoxColumn1,
            this.jamTugasDataGridViewTextBoxColumn1,
            this.idShiftDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.shifttBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(193, 232);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(649, 218);
            this.dataGridView2.TabIndex = 61;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idKamarDataGridViewTextBoxColumn1
            // 
            this.idKamarDataGridViewTextBoxColumn1.DataPropertyName = "Id_Kamar";
            this.idKamarDataGridViewTextBoxColumn1.HeaderText = "Id_Kamar";
            this.idKamarDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idKamarDataGridViewTextBoxColumn1.Name = "idKamarDataGridViewTextBoxColumn1";
            this.idKamarDataGridViewTextBoxColumn1.Width = 150;
            // 
            // idPetugasDataGridViewTextBoxColumn1
            // 
            this.idPetugasDataGridViewTextBoxColumn1.DataPropertyName = "Id_Petugas";
            this.idPetugasDataGridViewTextBoxColumn1.HeaderText = "Id_Petugas";
            this.idPetugasDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idPetugasDataGridViewTextBoxColumn1.Name = "idPetugasDataGridViewTextBoxColumn1";
            this.idPetugasDataGridViewTextBoxColumn1.Width = 150;
            // 
            // jamTugasDataGridViewTextBoxColumn1
            // 
            this.jamTugasDataGridViewTextBoxColumn1.DataPropertyName = "Jam_Tugas";
            this.jamTugasDataGridViewTextBoxColumn1.HeaderText = "Jam_Tugas";
            this.jamTugasDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.jamTugasDataGridViewTextBoxColumn1.Name = "jamTugasDataGridViewTextBoxColumn1";
            this.jamTugasDataGridViewTextBoxColumn1.Width = 150;
            // 
            // idShiftDataGridViewTextBoxColumn1
            // 
            this.idShiftDataGridViewTextBoxColumn1.DataPropertyName = "Id_Shift";
            this.idShiftDataGridViewTextBoxColumn1.HeaderText = "Id_Shift";
            this.idShiftDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idShiftDataGridViewTextBoxColumn1.Name = "idShiftDataGridViewTextBoxColumn1";
            this.idShiftDataGridViewTextBoxColumn1.Width = 150;
            // 
            // shifttBindingSource2
            // 
            this.shifttBindingSource2.DataMember = "Shiftt";
            this.shifttBindingSource2.DataSource = this.klinikBersalinDataSet1;
            // 
            // klinikBersalinDataSet1
            // 
            this.klinikBersalinDataSet1.DataSetName = "KlinikBersalinDataSet1";
            this.klinikBersalinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shifttTableAdapter1
            // 
            this.shifttTableAdapter1.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSlateGray;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(49, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 46);
            this.button3.TabIndex = 62;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txbxIdShift);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(861, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 200);
            this.panel1.TabIndex = 63;
            // 
            // Add_Shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1090, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.groupBox2);
            this.Name = "Add_Shift";
            this.Text = "Add_Shift";
            this.Load += new System.EventHandler(this.Add_Shift_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifttBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shifttBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shifttBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbxIdShift;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxjamtugas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource klinikBersalinDataSetBindingSource;
        private KlinikBersalinDataSet klinikBersalinDataSet;
        private System.Windows.Forms.BindingSource shifttBindingSource;
        private KlinikBersalinDataSetTableAdapters.ShifttTableAdapter shifttTableAdapter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource shifttBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private KlinikBersalinDataSet1 klinikBersalinDataSet1;
        private System.Windows.Forms.BindingSource shifttBindingSource2;
        private KlinikBersalinDataSet1TableAdapters.ShifttTableAdapter shifttTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKamarDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPetugasDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamTugasDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idShiftDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
    }
}