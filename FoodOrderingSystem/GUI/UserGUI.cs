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
    public partial class UserGUI : Form
    {
        public UserGUI()
        {
            InitializeComponent();
        }

        private void UserGUI_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {


            ProfileGUI progui = new ProfileGUI();
            this.Hide();
            progui.Show();
        }

        private void User_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_userhistory_Click(object sender, EventArgs e)
        {
            HistoryGUI his = new HistoryGUI();
            this.Dispose();
            his.Show();
        }

        private void UserGUI_Load_1(object sender, EventArgs e)
        {
           
        }
    }
}
