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

        private void dataGridView_pendingorders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_decline_Click(object sender, EventArgs e)
        {
           // string a;

            MessageBox.Show("Order is declined!");
           

        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order is Accepted!");

        }

        private void ManagerGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
