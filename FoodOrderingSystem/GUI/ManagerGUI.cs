using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderingSystem.GUI
{
    public partial class ManagerGUI : Form
    {
        public ManagerGUI()
        {
            InitializeComponent();
        }

        private void ManagerGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you Sure switch to login page?", "Warnning", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    LoginGUI log = new LoginGUI();
                    this.Dispose();
                    log.Show();


                }
            }
        }
    }
}
