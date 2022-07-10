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
    public partial class ProfileGUI : Form
    {
        public ProfileGUI()
        {
            InitializeComponent();
        }


        private void ProfileGUI_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ProfileGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you Sure to close application?", "Warnning", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();

                }
            }
        }

        private void btn_profileback_Click(object sender, EventArgs e)
        {



            UserGUI usergui = new UserGUI();
            this.Dispose();
            usergui.Show();
        }
    }
}
