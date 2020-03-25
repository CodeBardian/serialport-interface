using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPort
{
    public partial class licenseForm : Form
    {
        public licenseForm()
        {
            InitializeComponent();
        }

        private void SerialPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
