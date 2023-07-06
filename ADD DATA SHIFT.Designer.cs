namespace FinalProject_KlinikBersalin
{
    partial class ADD_DATA_SHIFT
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
            this.shifttBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klinikBersalinDataSet = new FinalProject_KlinikBersalin.KlinikBersalinDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.shifttTableAdapter = new FinalProject_KlinikBersalin.KlinikBersalinDataSetTableAdapters.ShifttTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pasienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klinikBersalinDataSet1 = new FinalProject_KlinikBersalin.KlinikBersalinDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.pasienTableAdapter = new FinalProject_KlinikBersalin.KlinikBersalinDataSetTableAdapters.PasienTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idKamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPetugasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamTugasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idShiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.shifttBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 45);
            this.label7.TabIndex = 20;
            this.label7.Text = "DATA SHIFT";
            // 
            // shifttTableAdapter
            // 
            this.shifttTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(633, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 60);
            this.button1.TabIndex = 26;
            this.button1.Text = "Clear Data";
            this.button1.UseVisualStyleBackColor = false;
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
            this.idKamarDataGridViewTextBoxColumn,
            this.idPetugasDataGridViewTextBoxColumn,
            this.jamTugasDataGridViewTextBoxColumn,
            this.idShiftDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shifttBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuText;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(36, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 87);
            this.dataGridView1.TabIndex = 24;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(633, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 60);
            this.button2.TabIndex = 23;
            this.button2.Text = "Simpan Data";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pasienTableAdapter
            // 
            this.pasienTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SlateGray;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(633, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 60);
            this.button3.TabIndex = 25;
            this.button3.Text = "Add Data";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(36, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 200);
            this.panel1.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasienBindingSource, "Id_Pasien", true));
            this.textBox4.Location = new System.Drawing.Point(311, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(215, 26);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasienBindingSource, "Alamat", true));
            this.textBox3.Location = new System.Drawing.Point(22, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(215, 26);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasienBindingSource, "No_Telp", true));
            this.textBox2.Location = new System.Drawing.Point(311, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 26);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasienBindingSource, "Nama_Pasien", true));
            this.textBox1.Location = new System.Drawing.Point(23, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 26);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(306, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id Shift";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(18, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jam Tugas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(306, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Petugas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(17, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Id Kamar";
            // 
            // idKamarDataGridViewTextBoxColumn
            // 
            this.idKamarDataGridViewTextBoxColumn.DataPropertyName = "Id_Kamar";
            this.idKamarDataGridViewTextBoxColumn.HeaderText = "Id_Kamar";
            this.idKamarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idKamarDataGridViewTextBoxColumn.Name = "idKamarDataGridViewTextBoxColumn";
            // 
            // idPetugasDataGridViewTextBoxColumn
            // 
            this.idPetugasDataGridViewTextBoxColumn.DataPropertyName = "Id_Petugas";
            this.idPetugasDataGridViewTextBoxColumn.HeaderText = "Id_Petugas";
            this.idPetugasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idPetugasDataGridViewTextBoxColumn.Name = "idPetugasDataGridViewTextBoxColumn";
            // 
            // jamTugasDataGridViewTextBoxColumn
            // 
            this.jamTugasDataGridViewTextBoxColumn.DataPropertyName = "Jam_Tugas";
            this.jamTugasDataGridViewTextBoxColumn.HeaderText = "Jam_Tugas";
            this.jamTugasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jamTugasDataGridViewTextBoxColumn.Name = "jamTugasDataGridViewTextBoxColumn";
            // 
            // idShiftDataGridViewTextBoxColumn
            // 
            this.idShiftDataGridViewTextBoxColumn.DataPropertyName = "Id_Shift";
            this.idShiftDataGridViewTextBoxColumn.HeaderText = "Id_Shift";
            this.idShiftDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idShiftDataGridViewTextBoxColumn.Name = "idShiftDataGridViewTextBoxColumn";
            // 
            // ADD_DATA_SHIFT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(853, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "ADD_DATA_SHIFT";
            this.Text = "ADD_DATA_SHIFT";
            this.Load += new System.EventHandler(this.ADD_DATA_SHIFT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shifttBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private KlinikBersalinDataSet klinikBersalinDataSet;
        private System.Windows.Forms.BindingSource shifttBindingSource;
        private KlinikBersalinDataSetTableAdapters.ShifttTableAdapter shifttTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPetugasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamTugasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idShiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pasienBindingSource;
        private KlinikBersalinDataSet klinikBersalinDataSet1;
        private System.Windows.Forms.Button button2;
        private KlinikBersalinDataSetTableAdapters.PasienTableAdapter pasienTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}