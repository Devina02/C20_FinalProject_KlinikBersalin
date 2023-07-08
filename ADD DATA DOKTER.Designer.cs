namespace FinalProject_KlinikBersalin
{
    partial class ADD_DATA_DOKTER
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
            this.label1 = new System.Windows.Forms.Label();
            this.dokterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klinikBersalinDataSet = new FinalProject_KlinikBersalin.KlinikBersalinDataSet();
            this.dokterTableAdapter = new FinalProject_KlinikBersalin.KlinikBersalinDataSetTableAdapters.DokterTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxnama = new System.Windows.Forms.TextBox();
            this.tbxiddokter = new System.Windows.Forms.TextBox();
            this.tbxemail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namaDokterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDokterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emaildokterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dokterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dokterBindingSource
            // 
            this.dokterBindingSource.DataMember = "Dokter";
            this.dokterBindingSource.DataSource = this.klinikBersalinDataSet;
            // 
            // klinikBersalinDataSet
            // 
            this.klinikBersalinDataSet.DataSetName = "KlinikBersalinDataSet";
            this.klinikBersalinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dokterTableAdapter
            // 
            this.dokterTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 45);
            this.label7.TabIndex = 11;
            this.label7.Text = "DATA DOKTER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(629, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 60);
            this.button2.TabIndex = 19;
            this.button2.Text = "Clear Data";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(15, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nama Dokter";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(14, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "Id Dokter";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(16, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "Email";
            // 
            // tbxnama
            // 
            this.tbxnama.Location = new System.Drawing.Point(21, 48);
            this.tbxnama.Name = "tbxnama";
            this.tbxnama.Size = new System.Drawing.Size(514, 26);
            this.tbxnama.TabIndex = 4;
            // 
            // tbxiddokter
            // 
            this.tbxiddokter.Location = new System.Drawing.Point(19, 204);
            this.tbxiddokter.Name = "tbxiddokter";
            this.tbxiddokter.Size = new System.Drawing.Size(516, 26);
            this.tbxiddokter.TabIndex = 5;
            // 
            // tbxemail
            // 
            this.tbxemail.Location = new System.Drawing.Point(20, 125);
            this.tbxemail.Name = "tbxemail";
            this.tbxemail.Size = new System.Drawing.Size(515, 26);
            this.tbxemail.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.tbxemail);
            this.panel2.Controls.Add(this.tbxiddokter);
            this.panel2.Controls.Add(this.tbxnama);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(54, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 264);
            this.panel2.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RosyBrown;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(629, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 60);
            this.button4.TabIndex = 16;
            this.button4.Text = "Simpan Data";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SlateGray;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(629, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 60);
            this.button3.TabIndex = 18;
            this.button3.Text = "Add Data";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.namaDokterDataGridViewTextBoxColumn,
            this.idDokterDataGridViewTextBoxColumn,
            this.emaildokterDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dokterBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuText;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(54, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(732, 133);
            this.dataGridView1.TabIndex = 20;
            // 
            // namaDokterDataGridViewTextBoxColumn
            // 
            this.namaDokterDataGridViewTextBoxColumn.DataPropertyName = "Nama_Dokter";
            this.namaDokterDataGridViewTextBoxColumn.HeaderText = "Nama_Dokter";
            this.namaDokterDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaDokterDataGridViewTextBoxColumn.Name = "namaDokterDataGridViewTextBoxColumn";
            // 
            // idDokterDataGridViewTextBoxColumn
            // 
            this.idDokterDataGridViewTextBoxColumn.DataPropertyName = "Id_Dokter";
            this.idDokterDataGridViewTextBoxColumn.HeaderText = "Id_Dokter";
            this.idDokterDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDokterDataGridViewTextBoxColumn.Name = "idDokterDataGridViewTextBoxColumn";
            // 
            // emaildokterDataGridViewTextBoxColumn
            // 
            this.emaildokterDataGridViewTextBoxColumn.DataPropertyName = "Email_dokter";
            this.emaildokterDataGridViewTextBoxColumn.HeaderText = "Email_dokter";
            this.emaildokterDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emaildokterDataGridViewTextBoxColumn.Name = "emaildokterDataGridViewTextBoxColumn";
            // 
            // ADD_DATA_DOKTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 516);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ADD_DATA_DOKTER";
            this.Text = "ADD_DATA_DOKTER";
            this.Load += new System.EventHandler(this.ADD_DATA_DOKTER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dokterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klinikBersalinDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private KlinikBersalinDataSet klinikBersalinDataSet;
        private System.Windows.Forms.BindingSource dokterBindingSource;
        private KlinikBersalinDataSetTableAdapters.DokterTableAdapter dokterTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxnama;
        private System.Windows.Forms.TextBox tbxiddokter;
        private System.Windows.Forms.TextBox tbxemail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDokterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDokterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emaildokterDataGridViewTextBoxColumn;
    }
}