using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_KlinikBersalin
{
    public partial class ADD_DATA_DOKTER : Form
    {
        public ADD_DATA_DOKTER()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ADD_DATA_DOKTER_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'klinikBersalinDataSet.Dokter' table. You can move, or remove it, as needed.
            this.dokterTableAdapter.Fill(this.klinikBersalinDataSet.Dokter);

        }
    }
}
