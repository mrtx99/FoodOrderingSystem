
namespace FoodOrderingSystem.GUI
{
    partial class AdminGUI
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
            this.tabControl_admin = new System.Windows.Forms.TabControl();
            this.tabPage_addfooditem = new System.Windows.Forms.TabPage();
            this.btn_fooditemadd = new System.Windows.Forms.Button();
            this.txt_itemtype = new System.Windows.Forms.TextBox();
            this.txt_itemprice = new System.Windows.Forms.TextBox();
            this.txt_itemname = new System.Windows.Forms.TextBox();
            this.txt_itemid = new System.Windows.Forms.TextBox();
            this.lbl_itemtype = new System.Windows.Forms.Label();
            this.lbl_itemprice = new System.Windows.Forms.Label();
            this.lbl_itemname = new System.Windows.Forms.Label();
            this.lbl_itemid = new System.Windows.Forms.Label();
            this.tabPage_addmanager = new System.Windows.Forms.TabPage();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addmanager = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbl_role = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_userid = new System.Windows.Forms.Label();
            this.tabControl_admin.SuspendLayout();
            this.tabPage_addfooditem.SuspendLayout();
            this.tabPage_addmanager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_admin
            // 
            this.tabControl_admin.Controls.Add(this.tabPage_addfooditem);
            this.tabControl_admin.Controls.Add(this.tabPage_addmanager);
            this.tabControl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_admin.Location = new System.Drawing.Point(12, -3);
            this.tabControl_admin.Name = "tabControl_admin";
            this.tabControl_admin.SelectedIndex = 0;
            this.tabControl_admin.Size = new System.Drawing.Size(776, 441);
            this.tabControl_admin.TabIndex = 0;
            // 
            // tabPage_addfooditem
            // 
            this.tabPage_addfooditem.BackColor = System.Drawing.Color.DarkOrange;
            this.tabPage_addfooditem.Controls.Add(this.btn_fooditemadd);
            this.tabPage_addfooditem.Controls.Add(this.txt_itemtype);
            this.tabPage_addfooditem.Controls.Add(this.txt_itemprice);
            this.tabPage_addfooditem.Controls.Add(this.txt_itemname);
            this.tabPage_addfooditem.Controls.Add(this.txt_itemid);
            this.tabPage_addfooditem.Controls.Add(this.lbl_itemtype);
            this.tabPage_addfooditem.Controls.Add(this.lbl_itemprice);
            this.tabPage_addfooditem.Controls.Add(this.lbl_itemname);
            this.tabPage_addfooditem.Controls.Add(this.lbl_itemid);
            this.tabPage_addfooditem.Location = new System.Drawing.Point(4, 22);
            this.tabPage_addfooditem.Name = "tabPage_addfooditem";
            this.tabPage_addfooditem.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage_addfooditem.Size = new System.Drawing.Size(768, 415);
            this.tabPage_addfooditem.TabIndex = 0;
            this.tabPage_addfooditem.Text = "Add Food Items";
            // 
            // btn_fooditemadd
            // 
            this.btn_fooditemadd.Location = new System.Drawing.Point(359, 262);
            this.btn_fooditemadd.Name = "btn_fooditemadd";
            this.btn_fooditemadd.Size = new System.Drawing.Size(75, 23);
            this.btn_fooditemadd.TabIndex = 8;
            this.btn_fooditemadd.Text = "Add";
            this.btn_fooditemadd.UseVisualStyleBackColor = true;
            // 
            // txt_itemtype
            // 
            this.txt_itemtype.Location = new System.Drawing.Point(254, 220);
            this.txt_itemtype.Name = "txt_itemtype";
            this.txt_itemtype.Size = new System.Drawing.Size(180, 20);
            this.txt_itemtype.TabIndex = 7;
            // 
            // txt_itemprice
            // 
            this.txt_itemprice.Location = new System.Drawing.Point(254, 176);
            this.txt_itemprice.Name = "txt_itemprice";
            this.txt_itemprice.Size = new System.Drawing.Size(180, 20);
            this.txt_itemprice.TabIndex = 6;
            // 
            // txt_itemname
            // 
            this.txt_itemname.Location = new System.Drawing.Point(254, 141);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(180, 20);
            this.txt_itemname.TabIndex = 5;
            // 
            // txt_itemid
            // 
            this.txt_itemid.Location = new System.Drawing.Point(254, 104);
            this.txt_itemid.Name = "txt_itemid";
            this.txt_itemid.Size = new System.Drawing.Size(180, 20);
            this.txt_itemid.TabIndex = 4;
            // 
            // lbl_itemtype
            // 
            this.lbl_itemtype.AutoSize = true;
            this.lbl_itemtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemtype.Location = new System.Drawing.Point(124, 220);
            this.lbl_itemtype.Name = "lbl_itemtype";
            this.lbl_itemtype.Size = new System.Drawing.Size(37, 15);
            this.lbl_itemtype.TabIndex = 3;
            this.lbl_itemtype.Text = "Type";
            // 
            // lbl_itemprice
            // 
            this.lbl_itemprice.AutoSize = true;
            this.lbl_itemprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemprice.Location = new System.Drawing.Point(124, 181);
            this.lbl_itemprice.Name = "lbl_itemprice";
            this.lbl_itemprice.Size = new System.Drawing.Size(39, 15);
            this.lbl_itemprice.TabIndex = 2;
            this.lbl_itemprice.Text = "price";
            // 
            // lbl_itemname
            // 
            this.lbl_itemname.AutoSize = true;
            this.lbl_itemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemname.Location = new System.Drawing.Point(124, 146);
            this.lbl_itemname.Name = "lbl_itemname";
            this.lbl_itemname.Size = new System.Drawing.Size(75, 15);
            this.lbl_itemname.TabIndex = 1;
            this.lbl_itemname.Text = "Item name";
            // 
            // lbl_itemid
            // 
            this.lbl_itemid.AutoSize = true;
            this.lbl_itemid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemid.Location = new System.Drawing.Point(124, 109);
            this.lbl_itemid.Name = "lbl_itemid";
            this.lbl_itemid.Size = new System.Drawing.Size(53, 15);
            this.lbl_itemid.TabIndex = 0;
            this.lbl_itemid.Text = "Item ID";
            // 
            // tabPage_addmanager
            // 
            this.tabPage_addmanager.BackColor = System.Drawing.Color.SandyBrown;
            this.tabPage_addmanager.Controls.Add(this.txt_address);
            this.tabPage_addmanager.Controls.Add(this.label2);
            this.tabPage_addmanager.Controls.Add(this.txt_phone);
            this.tabPage_addmanager.Controls.Add(this.label1);
            this.tabPage_addmanager.Controls.Add(this.btn_addmanager);
            this.tabPage_addmanager.Controls.Add(this.textBox1);
            this.tabPage_addmanager.Controls.Add(this.textBox2);
            this.tabPage_addmanager.Controls.Add(this.textBox3);
            this.tabPage_addmanager.Controls.Add(this.textBox4);
            this.tabPage_addmanager.Controls.Add(this.lbl_role);
            this.tabPage_addmanager.Controls.Add(this.lbl_password);
            this.tabPage_addmanager.Controls.Add(this.lbl_username);
            this.tabPage_addmanager.Controls.Add(this.lbl_userid);
            this.tabPage_addmanager.Location = new System.Drawing.Point(4, 22);
            this.tabPage_addmanager.Name = "tabPage_addmanager";
            this.tabPage_addmanager.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage_addmanager.Size = new System.Drawing.Size(768, 415);
            this.tabPage_addmanager.TabIndex = 1;
            this.tabPage_addmanager.Text = "Add Manager";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(362, 272);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(180, 20);
            this.txt_address.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Address";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(362, 236);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(180, 20);
            this.txt_phone.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Phone";
            // 
            // btn_addmanager
            // 
            this.btn_addmanager.Location = new System.Drawing.Point(467, 319);
            this.btn_addmanager.Name = "btn_addmanager";
            this.btn_addmanager.Size = new System.Drawing.Size(75, 23);
            this.btn_addmanager.TabIndex = 17;
            this.btn_addmanager.Text = "Add";
            this.btn_addmanager.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(362, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(362, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(362, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(362, 79);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 20);
            this.textBox4.TabIndex = 13;
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.Location = new System.Drawing.Point(232, 195);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(37, 15);
            this.lbl_role.TabIndex = 12;
            this.lbl_role.Text = "Role";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(232, 156);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(69, 15);
            this.lbl_password.TabIndex = 11;
            this.lbl_password.Text = "Password";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(232, 121);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(73, 15);
            this.lbl_username.TabIndex = 10;
            this.lbl_username.Text = "Username";
            // 
            // lbl_userid
            // 
            this.lbl_userid.AutoSize = true;
            this.lbl_userid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userid.Location = new System.Drawing.Point(232, 84);
            this.lbl_userid.Name = "lbl_userid";
            this.lbl_userid.Size = new System.Drawing.Size(53, 15);
            this.lbl_userid.TabIndex = 9;
            this.lbl_userid.Text = "User Id";
            // 
            // AdminGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl_admin);
            this.Name = "AdminGUI";
            this.Text = "AdminGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminGUI_FormClosing);
            this.tabControl_admin.ResumeLayout(false);
            this.tabPage_addfooditem.ResumeLayout(false);
            this.tabPage_addfooditem.PerformLayout();
            this.tabPage_addmanager.ResumeLayout(false);
            this.tabPage_addmanager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_admin;
        private System.Windows.Forms.TabPage tabPage_addfooditem;
        private System.Windows.Forms.TabPage tabPage_addmanager;
        private System.Windows.Forms.Label lbl_itemname;
        private System.Windows.Forms.Label lbl_itemid;
        private System.Windows.Forms.Label lbl_itemtype;
        private System.Windows.Forms.Label lbl_itemprice;
        private System.Windows.Forms.TextBox txt_itemtype;
        private System.Windows.Forms.TextBox txt_itemprice;
        private System.Windows.Forms.TextBox txt_itemname;
        private System.Windows.Forms.TextBox txt_itemid;
        private System.Windows.Forms.Button btn_fooditemadd;
        private System.Windows.Forms.Button btn_addmanager;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_userid;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label1;
    }
}