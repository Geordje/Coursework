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
    public partial class AdminPopup : Form
    {
        public AdminPopup()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (PasswordF.Text != "adminAccess")
            {
                this.Close();
                MessageBox.Show("Incorrect Password","Editing not turned on",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Home.profilePage.EditEnable();
                this.Close();
                MessageBox.Show("Editing mode on, submit once done", "Editing turned on", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
    }
}
