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
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            UserGUI usergui = new UserGUI();

            AdminGUI ad = new AdminGUI();
            ManagerGUI mag = new ManagerGUI();
            this.Hide();
            //ad.Show();
            //mag.Show();
            usergui.Show();
        }

        private void LoginGUI_Load(object sender, EventArgs e)
        {

        }

        private void LoginGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you Sure to Exit application??", "Warnning", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();      

                }
            }
        }

        private void btn_registernow_Click_1(object sender, EventArgs e)
        {
            RegisterGUI reg = new RegisterGUI();
            this.Hide();
            reg.Show();
        }
    }
}

