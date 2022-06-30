
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
            this.tabControl_admin.Location = new System.Drawing.Point(16, -4);
            this.tabControl_admin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl_admin.Name = "tabControl_admin";
            this.tabControl_admin.SelectedIndex = 0;
            this.tabControl_admin.Size = new System.Drawing.Size(1035, 543);
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
            this.tabPage_addfooditem.Location = new System.Drawing.Point(4, 26);
            this.tabPage_addfooditem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_addfooditem.Name = "tabPage_addfooditem";
            this.tabPage_addfooditem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_addfooditem.Size = new System.Drawing.Size(1027, 513);
            this.tabPage_addfooditem.TabIndex = 0;
            this.tabPage_addfooditem.Text = "Add Food Items";
            // 
            // btn_fooditemadd
            // 
            this.btn_fooditemadd.Location = new System.Drawing.Point(479, 322);
            this.btn_fooditemadd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_fooditemadd.Name = "btn_fooditemadd";
            this.btn_fooditemadd.Size = new System.Drawing.Size(100, 28);
            this.btn_fooditemadd.TabIndex = 8;
            this.btn_fooditemadd.Text = "Add";
            this.btn_fooditemadd.UseVisualStyleBackColor = true;
            // 
            // txt_itemtype
            // 
            this.txt_itemtype.Location = new System.Drawing.Point(339, 271);
            this.txt_itemtype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_itemtype.Name = "txt_itemtype";
            this.txt_itemtype.Size = new System.Drawing.Size(239, 23);
            this.txt_itemtype.TabIndex = 7;
            // 
            // txt_itemprice
            // 
            this.txt_itemprice.Location = new System.Drawing.Point(339, 217);
            this.txt_itemprice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_itemprice.Name = "txt_itemprice";
            this.txt_itemprice.Size = new System.Drawing.Size(239, 23);
            this.txt_itemprice.TabIndex = 6;
            // 
            // txt_itemname
            // 
            this.txt_itemname.Location = new System.Drawing.Point(339, 174);
            this.txt_itemname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(239, 23);
            this.txt_itemname.TabIndex = 5;
            // 
            // txt_itemid
            // 
            this.txt_itemid.Location = new System.Drawing.Point(339, 128);
            this.txt_itemid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_itemid.Name = "txt_itemid";
            this.txt_itemid.Size = new System.Drawing.Size(239, 23);
            this.txt_itemid.TabIndex = 4;
            // 
            // lbl_itemtype
            // 
            this.lbl_itemtype.AutoSize = true;
            this.lbl_itemtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemtype.Location = new System.Drawing.Point(165, 271);
            this.lbl_itemtype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemtype.Name = "lbl_itemtype";
            this.lbl_itemtype.Size = new System.Drawing.Size(44, 18);
            this.lbl_itemtype.TabIndex = 3;
            this.lbl_itemtype.Text = "Type";
            // 
            // lbl_itemprice
            // 
            this.lbl_itemprice.AutoSize = true;
            this.lbl_itemprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemprice.Location = new System.Drawing.Point(165, 223);
            this.lbl_itemprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemprice.Name = "lbl_itemprice";
            this.lbl_itemprice.Size = new System.Drawing.Size(45, 18);
            this.lbl_itemprice.TabIndex = 2;
            this.lbl_itemprice.Text = "price";
            // 
            // lbl_itemname
            // 
            this.lbl_itemname.AutoSize = true;
            this.lbl_itemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemname.Location = new System.Drawing.Point(165, 180);
            this.lbl_itemname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemname.Name = "lbl_itemname";
            this.lbl_itemname.Size = new System.Drawing.Size(86, 18);
            this.lbl_itemname.TabIndex = 1;
            this.lbl_itemname.Text = "Item name";
            // 
            // lbl_itemid
            // 
            this.lbl_itemid.AutoSize = true;
            this.lbl_itemid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemid.Location = new System.Drawing.Point(165, 134);
            this.lbl_itemid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemid.Name = "lbl_itemid";
            this.lbl_itemid.Size = new System.Drawing.Size(61, 18);
            this.lbl_itemid.TabIndex = 0;
            this.lbl_itemid.Text = "Item ID";
            // 
            // tabPage_addmanager
            // 
            this.tabPage_addmanager.BackColor = System.Drawing.Color.Honeydew;
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
            this.tabPage_addmanager.Location = new System.Drawing.Point(4, 26);
            this.tabPage_addmanager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_addmanager.Name = "tabPage_addmanager";
            this.tabPage_addmanager.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_addmanager.Size = new System.Drawing.Size(1027, 513);
            this.tabPage_addmanager.TabIndex = 1;
            this.tabPage_addmanager.Text = "Add Manager";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(483, 335);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(239, 23);
            this.txt_address.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 335);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Address";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(483, 290);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(239, 23);
            this.txt_phone.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 290);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Phone";
            // 
            // btn_addmanager
            // 
            this.btn_addmanager.Location = new System.Drawing.Point(623, 393);
            this.btn_addmanager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addmanager.Name = "btn_addmanager";
            this.btn_addmanager.Size = new System.Drawing.Size(100, 28);
            this.btn_addmanager.TabIndex = 17;
            this.btn_addmanager.Text = "Add";
            this.btn_addmanager.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(483, 240);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 23);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(483, 186);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 23);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(483, 143);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(239, 23);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(483, 97);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(239, 23);
            this.textBox4.TabIndex = 13;
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.Location = new System.Drawing.Point(309, 240);
            this.lbl_role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(43, 18);
            this.lbl_role.TabIndex = 12;
            this.lbl_role.Text = "Role";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(309, 192);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(83, 18);
            this.lbl_password.TabIndex = 11;
            this.lbl_password.Text = "Password";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(309, 149);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(85, 18);
            this.lbl_username.TabIndex = 10;
            this.lbl_username.Text = "Username";
            // 
            // lbl_userid
            // 
            this.lbl_userid.AutoSize = true;
            this.lbl_userid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userid.Location = new System.Drawing.Point(309, 103);
            this.lbl_userid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_userid.Name = "lbl_userid";
            this.lbl_userid.Size = new System.Drawing.Size(62, 18);
            this.lbl_userid.TabIndex = 9;
            this.lbl_userid.Text = "User Id";
            // 
            // AdminGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl_admin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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