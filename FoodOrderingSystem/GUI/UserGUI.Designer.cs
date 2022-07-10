
namespace FoodOrderingSystem.GUI
{
    partial class UserGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_welcomeuser = new System.Windows.Forms.Label();
            this.dataGridView_menu = new System.Windows.Forms.DataGridView();
            this.Datagrid_ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datagrid_fitemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_fitemprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_fitemtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_fitemdiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_userhistory = new System.Windows.Forms.Button();
            this.btn_addtocart = new System.Windows.Forms.Button();
            this.btn_cart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_welcomeuser
            // 
            this.lbl_welcomeuser.AutoSize = true;
            this.lbl_welcomeuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcomeuser.Location = new System.Drawing.Point(12, 9);
            this.lbl_welcomeuser.Name = "lbl_welcomeuser";
            this.lbl_welcomeuser.Size = new System.Drawing.Size(74, 15);
            this.lbl_welcomeuser.TabIndex = 0;
            this.lbl_welcomeuser.Text = "Welcome, ";
            // 
            // dataGridView_menu
            // 
            this.dataGridView_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datagrid_ItemID,
            this.Datagrid_fitemname,
            this.datagrid_fitemprice,
            this.datagrid_fitemtype,
            this.datagrid_fitemdiscount});
            this.dataGridView_menu.Location = new System.Drawing.Point(115, 54);
            this.dataGridView_menu.Name = "dataGridView_menu";
            this.dataGridView_menu.Size = new System.Drawing.Size(563, 355);
            this.dataGridView_menu.TabIndex = 1;
            // 
            // Datagrid_ItemID
            // 
            this.Datagrid_ItemID.HeaderText = "Item ID";
            this.Datagrid_ItemID.Name = "Datagrid_ItemID";
            // 
            // Datagrid_fitemname
            // 
            this.Datagrid_fitemname.HeaderText = "Name ";
            this.Datagrid_fitemname.Name = "Datagrid_fitemname";
            this.Datagrid_fitemname.Width = 120;
            // 
            // datagrid_fitemprice
            // 
            this.datagrid_fitemprice.HeaderText = "Price";
            this.datagrid_fitemprice.Name = "datagrid_fitemprice";
            // 
            // datagrid_fitemtype
            // 
            this.datagrid_fitemtype.HeaderText = "Type";
            this.datagrid_fitemtype.Name = "datagrid_fitemtype";
            // 
            // datagrid_fitemdiscount
            // 
            this.datagrid_fitemdiscount.HeaderText = "discount";
            this.datagrid_fitemdiscount.Name = "datagrid_fitemdiscount";
            // 
            // btn_profile
            // 
            this.btn_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profile.Location = new System.Drawing.Point(15, 54);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(71, 23);
            this.btn_profile.TabIndex = 2;
            this.btn_profile.Text = "Profile";
            this.btn_profile.UseVisualStyleBackColor = true;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // btn_userhistory
            // 
            this.btn_userhistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userhistory.Location = new System.Drawing.Point(15, 83);
            this.btn_userhistory.Name = "btn_userhistory";
            this.btn_userhistory.Size = new System.Drawing.Size(71, 23);
            this.btn_userhistory.TabIndex = 3;
            this.btn_userhistory.Text = "History";
            this.btn_userhistory.UseVisualStyleBackColor = true;
            this.btn_userhistory.Click += new System.EventHandler(this.btn_userhistory_Click);
            // 
            // btn_addtocart
            // 
            this.btn_addtocart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addtocart.Location = new System.Drawing.Point(549, 415);
            this.btn_addtocart.Name = "btn_addtocart";
            this.btn_addtocart.Size = new System.Drawing.Size(129, 23);
            this.btn_addtocart.TabIndex = 4;
            this.btn_addtocart.Text = "Add to Cart";
            this.btn_addtocart.UseVisualStyleBackColor = true;
            this.btn_addtocart.Click += new System.EventHandler(this.btn_addtocart_Click);
            // 
            // btn_cart
            // 
            this.btn_cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cart.Location = new System.Drawing.Point(711, 54);
            this.btn_cart.Name = "btn_cart";
            this.btn_cart.Size = new System.Drawing.Size(77, 23);
            this.btn_cart.TabIndex = 5;
            this.btn_cart.Text = "Cart";
            this.btn_cart.UseVisualStyleBackColor = true;
            this.btn_cart.Click += new System.EventHandler(this.btn_cart_Click);
            // 
            // UserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cart);
            this.Controls.Add(this.btn_addtocart);
            this.Controls.Add(this.btn_userhistory);
            this.Controls.Add(this.btn_profile);
            this.Controls.Add(this.dataGridView_menu);
            this.Controls.Add(this.lbl_welcomeuser);
            this.Name = "UserGUI";
            this.Text = "User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_FormClosing);
            this.Load += new System.EventHandler(this.UserGUI_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcomeuser;
        private System.Windows.Forms.DataGridView dataGridView_menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datagrid_ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datagrid_fitemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_fitemprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_fitemtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_fitemdiscount;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_userhistory;
        private System.Windows.Forms.Button btn_addtocart;
        private System.Windows.Forms.Button btn_cart;
    }
}