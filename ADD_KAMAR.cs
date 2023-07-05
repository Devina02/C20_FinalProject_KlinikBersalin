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
    public partial class ADD_KAMAR : Form
    {
        public ADD_KAMAR()
        {
            InitializeComponent();
        }

        private void ADD_KAMAR_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'klinikBersalinDataSet.Kamar' table. You can move, or remove it, as needed.
            this.kamarTableAdapter.Fill(this.klinikBersalinDataSet.Kamar);

        }
    }
}
