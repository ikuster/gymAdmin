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
    public partial class PotvrdaBrisanja : Form
    {
        public PotvrdaBrisanja()
        {
            InitializeComponent();
        }

        private void BtnNePotvrdaBrisanja_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
