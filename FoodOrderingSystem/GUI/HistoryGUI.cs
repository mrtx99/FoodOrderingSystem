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
    public partial class HistoryGUI : Form
    {
        public HistoryGUI()
        {
            InitializeComponent();
        }

        private void btn_historyback_Click(object sender, EventArgs e)
        {
            UserGUI usergui = new UserGUI();
            this.Dispose();
            usergui.Show();
        }




        private void HistoryGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you Sure to exit the application?", "Warnning", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();


                }
            }
        }
    }
}
