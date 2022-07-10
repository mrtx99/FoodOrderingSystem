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
    public partial class CartGUI : Form
    {
        public CartGUI()
        {
            InitializeComponent();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Order successfully placed!", "Order status");
        }

        private void CartGUI_FormClosing(object sender, FormClosingEventArgs e)
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
       
        private void btn_cartback_Click(object sender, EventArgs e)
        {


            UserGUI ugui = new UserGUI();
            this.Dispose();
            ugui.Show();
        }
    }
}
