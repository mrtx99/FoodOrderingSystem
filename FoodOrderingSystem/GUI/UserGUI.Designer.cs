﻿
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
            // UserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_welcomeuser);
            this.Name = "UserGUI";
            this.Text = "UserGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcomeuser;
    }
}