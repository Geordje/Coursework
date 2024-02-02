using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            if ((Control.MouseButtons & MouseButtons.Left) != 0)
            {
                // Left button is down.
            }
        }
    }
}
