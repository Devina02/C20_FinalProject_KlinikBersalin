﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_KlinikBersalin
{
    public partial class ADD_DATA : Form
    {
        private string stringConnection = " data source = LAPTOP-DP3PQGGM\\DEPIIII;" +
          "database=KlinikBersalin;User ID=sa;Password=123";
        private SqlConnection koneksi;
        public ADD_DATA()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);

        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Pasien";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void Refreshform()
        {

            tbxNamaPasien.Text = "";
            tbxTelp.Text = "";
            tbxAlamat.Text = "";

            button2.Enabled = false;

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ADD_DATA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'klinikBersalinDataSet.Pasien' table. You can move, or remove it, as needed.
            this.pasienTableAdapter.Fill(this.klinikBersalinDataSet.Pasien);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nmPasien = tbxNamaPasien.Text;
            string noTelp = tbxTelp.Text;
            string alamt = tbxAlamat.Text;

            if (nmPasien == "")
            {
                MessageBox.Show("Masukan nama Pasien", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string getIdQuery = "SELECT MAX(Id_Pasien) FROM dbo.Pasien";
                SqlCommand getIdCmd = new SqlCommand(getIdQuery, koneksi);
                object result = getIdCmd.ExecuteScalar();
                string newId = "P0001";

                if (result != null && result != DBNull.Value)
                {
                    string lastId = Convert.ToString(result);
                    int lastNumber = int.Parse(lastId.Substring(1));
                    newId = "P" + (lastNumber + 1).ToString("D4");
                }

                string insertQuery = "INSERT INTO dbo.Pasien (Nama_Pasien, Id_Pasien, No_Telp, alamat) VALUES (@Nama_Pasien, @Id_Pasien, @No_Telp, @alamat)";
                SqlCommand cmd = new SqlCommand(insertQuery, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@Nama_Pasien", nmPasien));
                cmd.Parameters.Add(new SqlParameter("@Id_Pasien", newId));
                cmd.Parameters.Add(new SqlParameter("@No_Telp", noTelp));
                cmd.Parameters.Add(new SqlParameter("@Alamat", alamt));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                Refreshform();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            //nmp.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnObat_Click(object sender, EventArgs e)
        {
            new Obat().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string stringConnection = " data source = LAPTOP-DP3PQGGM\\DEPIIII;" +
             "database=KlinikBersalin;User ID=sa;Password=123";
            string query = "DELETE FROM Pasien WHERE Id_Pasien = @Id_Pasien";
            using (SqlConnection koneksi = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(query, koneksi))
                {
                    cmd.Parameters.AddWithValue("@Id_Pasien", txbxpasien.Text);

                    try
                    {
                        koneksi.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data successfully deleted.");
                        dataGridView();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message + " (Error Code: " + ex.Number + ")");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

        }

        private void tbxSearch_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Refreshform();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new ADD_DATA_DOKTER().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new ADD_PETUGAS().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ADD_KAMAR().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Obat().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ADD_REKAM_MEDIS().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Add_Shift().Show();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string IdPasien = txbxpasien.Text;
            string nmPasien = tbxNamaPasien.Text;
            string noTelp = tbxTelp.Text;
            string alamt = tbxAlamat.Text;

            string updateQuery = "UPDATE dbo.Pasien SET Nama_Pasien = @Nama_Pasien, No_Telp = @No_Telp, alamat = @alamat WHERE Id_Pasien = @Id_Pasien";
            SqlCommand cmd = new SqlCommand(updateQuery, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@Nama_Pasien", nmPasien));
            cmd.Parameters.Add(new SqlParameter("@No_Telp", noTelp));
            cmd.Parameters.Add(new SqlParameter("@alamat", alamt));
            cmd.Parameters.Add(new SqlParameter("@Id_Pasien", IdPasien));

            koneksi.Open();
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data Pasien updated successfully.");
            dataGridView();
            Refreshform();
        }

        private void txbxpasien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}