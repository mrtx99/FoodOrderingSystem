
namespace FoodOrderingSystem.GUI
{
    partial class ProfileGUI
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
            this.btn_profileback = new System.Windows.Forms.Button();
            this.lbl_profileuserid = new System.Windows.Forms.Label();
            this.lbl_profilename = new System.Windows.Forms.Label();
            this.lbl_profilephone = new System.Windows.Forms.Label();
            this.lbl_profileaddress = new System.Windows.Forms.Label();
            this.lbl_profileaccountdetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_profileback
            // 
            this.btn_profileback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profileback.Location = new System.Drawing.Point(12, 415);
            this.btn_profileback.Name = "btn_profileback";
            this.btn_profileback.Size = new System.Drawing.Size(75, 23);
            this.btn_profileback.TabIndex = 1;
            this.btn_profileback.Text = "Back";
            this.btn_profileback.UseVisualStyleBackColor = true;
            this.btn_profileback.Click += new System.EventHandler(this.btn_profileback_Click);
            // 
            // lbl_profileuserid
            // 
            this.lbl_profileuserid.AutoSize = true;
            this.lbl_profileuserid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profileuserid.Location = new System.Drawing.Point(167, 126);
            this.lbl_profileuserid.Name = "lbl_profileuserid";
            this.lbl_profileuserid.Size = new System.Drawing.Size(68, 16);
            this.lbl_profileuserid.TabIndex = 2;
            this.lbl_profileuserid.Text = "User ID :";
            // 
            // lbl_profilename
            // 
            this.lbl_profilename.AutoSize = true;
            this.lbl_profilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profilename.Location = new System.Drawing.Point(167, 175);
            this.lbl_profilename.Name = "lbl_profilename";
            this.lbl_profilename.Size = new System.Drawing.Size(57, 16);
            this.lbl_profilename.TabIndex = 3;
            this.lbl_profilename.Text = "Name :";
            // 
            // lbl_profilephone
            // 
            this.lbl_profilephone.AutoSize = true;
            this.lbl_profilephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profilephone.Location = new System.Drawing.Point(167, 222);
            this.lbl_profilephone.Name = "lbl_profilephone";
            this.lbl_profilephone.Size = new System.Drawing.Size(60, 16);
            this.lbl_profilephone.TabIndex = 4;
            this.lbl_profilephone.Text = "Phone :";
            // 
            // lbl_profileaddress
            // 
            this.lbl_profileaddress.AutoSize = true;
            this.lbl_profileaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profileaddress.Location = new System.Drawing.Point(167, 268);
            this.lbl_profileaddress.Name = "lbl_profileaddress";
            this.lbl_profileaddress.Size = new System.Drawing.Size(74, 16);
            this.lbl_profileaddress.TabIndex = 5;
            this.lbl_profileaddress.Text = "Address :";
            // 
            // lbl_profileaccountdetails
            // 
            this.lbl_profileaccountdetails.AutoSize = true;
            this.lbl_profileaccountdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profileaccountdetails.Location = new System.Drawing.Point(323, 30);
            this.lbl_profileaccountdetails.Name = "lbl_profileaccountdetails";
            this.lbl_profileaccountdetails.Size = new System.Drawing.Size(133, 20);
            this.lbl_profileaccountdetails.TabIndex = 6;
            this.lbl_profileaccountdetails.Text = "Account details";
            // 
            // ProfileGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_profileaccountdetails);
            this.Controls.Add(this.lbl_profileaddress);
            this.Controls.Add(this.lbl_profilephone);
            this.Controls.Add(this.lbl_profilename);
            this.Controls.Add(this.lbl_profileuserid);
            this.Controls.Add(this.btn_profileback);
            this.Name = "ProfileGUI";
            this.Text = "Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfileGUI_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProfileGUI_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_profileback;
        private System.Windows.Forms.Label lbl_profileuserid;
        private System.Windows.Forms.Label lbl_profilename;
        private System.Windows.Forms.Label lbl_profilephone;
        private System.Windows.Forms.Label lbl_profileaddress;
        private System.Windows.Forms.Label lbl_profileaccountdetails;
    }
}