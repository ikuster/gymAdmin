using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymAdmin
{
    public partial class DetaljiKlijent : Form
    {
        public DetaljiKlijent()
        {
            InitializeComponent();
        }

        private void BtnOdustaniDetaljiKlijent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
