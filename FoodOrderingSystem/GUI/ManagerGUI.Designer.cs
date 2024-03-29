﻿
namespace FoodOrderingSystem.GUI
{
    partial class ManagerGUI
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
            this.tabControl_manager = new System.Windows.Forms.TabControl();
            this.tabP_pendingorders = new System.Windows.Forms.TabPage();
            this.dataGridView_pendingorders = new System.Windows.Forms.DataGridView();
            this.pendingorderid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendingorder_itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendingorder_userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_decline = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.tabP_paymenthistory = new System.Windows.Forms.TabPage();
            this.listView_paymenthistory = new System.Windows.Forms.ListView();
            this.columnHeader_paymentid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_userid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_orderid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl_manager.SuspendLayout();
            this.tabP_pendingorders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pendingorders)).BeginInit();
            this.tabP_paymenthistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_manager
            // 
            this.tabControl_manager.Controls.Add(this.tabP_pendingorders);
            this.tabControl_manager.Controls.Add(this.tabP_paymenthistory);
            this.tabControl_manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_manager.Location = new System.Drawing.Point(0, -3);
            this.tabControl_manager.Name = "tabControl_manager";
            this.tabControl_manager.SelectedIndex = 0;
            this.tabControl_manager.Size = new System.Drawing.Size(801, 454);
            this.tabControl_manager.TabIndex = 0;
            // 
            // tabP_pendingorders
            // 
            this.tabP_pendingorders.BackColor = System.Drawing.Color.Orange;
            this.tabP_pendingorders.Controls.Add(this.dataGridView_pendingorders);
            this.tabP_pendingorders.Controls.Add(this.btn_decline);
            this.tabP_pendingorders.Controls.Add(this.btn_accept);
            this.tabP_pendingorders.Location = new System.Drawing.Point(4, 22);
            this.tabP_pendingorders.Name = "tabP_pendingorders";
            this.tabP_pendingorders.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_pendingorders.Size = new System.Drawing.Size(793, 428);
            this.tabP_pendingorders.TabIndex = 0;
            this.tabP_pendingorders.Text = "Pending orders";
            // 
            // dataGridView_pendingorders
            // 
            this.dataGridView_pendingorders.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView_pendingorders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pendingorders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pendingorderid,
            this.pendingorder_itemid,
            this.pendingorder_userid});
            this.dataGridView_pendingorders.Location = new System.Drawing.Point(8, 6);
            this.dataGridView_pendingorders.Name = "dataGridView_pendingorders";
            this.dataGridView_pendingorders.ReadOnly = true;
            this.dataGridView_pendingorders.Size = new System.Drawing.Size(776, 378);
            this.dataGridView_pendingorders.TabIndex = 2;
            this.dataGridView_pendingorders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_pendingorders_CellContentClick);
            // 
            // pendingorderid
            // 
            this.pendingorderid.HeaderText = "order id";
            this.pendingorderid.Name = "pendingorderid";
            this.pendingorderid.ReadOnly = true;
            this.pendingorderid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // pendingorder_itemid
            // 
            this.pendingorder_itemid.HeaderText = "Item id";
            this.pendingorder_itemid.Name = "pendingorder_itemid";
            this.pendingorder_itemid.ReadOnly = true;
            // 
            // pendingorder_userid
            // 
            this.pendingorder_userid.HeaderText = "User id";
            this.pendingorder_userid.Name = "pendingorder_userid";
            this.pendingorder_userid.ReadOnly = true;
            // 
            // btn_decline
            // 
            this.btn_decline.BackColor = System.Drawing.Color.Red;
            this.btn_decline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decline.Location = new System.Drawing.Point(613, 393);
            this.btn_decline.Name = "btn_decline";
            this.btn_decline.Size = new System.Drawing.Size(75, 23);
            this.btn_decline.TabIndex = 1;
            this.btn_decline.Text = "Decline";
            this.btn_decline.UseVisualStyleBackColor = false;
            this.btn_decline.Click += new System.EventHandler(this.btn_decline_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accept.Location = new System.Drawing.Point(709, 393);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_accept.Size = new System.Drawing.Size(75, 23);
            this.btn_accept.TabIndex = 0;
            this.btn_accept.Text = "Accept";
            this.btn_accept.UseVisualStyleBackColor = false;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // tabP_paymenthistory
            // 
            this.tabP_paymenthistory.BackColor = System.Drawing.Color.Orange;
            this.tabP_paymenthistory.Controls.Add(this.listView_paymenthistory);
            this.tabP_paymenthistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabP_paymenthistory.Location = new System.Drawing.Point(4, 22);
            this.tabP_paymenthistory.Name = "tabP_paymenthistory";
            this.tabP_paymenthistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_paymenthistory.Size = new System.Drawing.Size(793, 428);
            this.tabP_paymenthistory.TabIndex = 1;
            this.tabP_paymenthistory.Text = "Payments History";
            // 
            // listView_paymenthistory
            // 
            this.listView_paymenthistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_paymentid,
            this.columnHeader_userid,
            this.columnHeader_orderid});
            this.listView_paymenthistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_paymenthistory.FullRowSelect = true;
            this.listView_paymenthistory.GridLines = true;
            this.listView_paymenthistory.HideSelection = false;
            this.listView_paymenthistory.Location = new System.Drawing.Point(329, 15);
            this.listView_paymenthistory.Name = "listView_paymenthistory";
            this.listView_paymenthistory.Size = new System.Drawing.Size(455, 401);
            this.listView_paymenthistory.TabIndex = 0;
            this.listView_paymenthistory.UseCompatibleStateImageBehavior = false;
            this.listView_paymenthistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_paymentid
            // 
            this.columnHeader_paymentid.Text = "Payment ID";
            this.columnHeader_paymentid.Width = 123;
            // 
            // columnHeader_userid
            // 
            this.columnHeader_userid.Text = "User ID";
            this.columnHeader_userid.Width = 194;
            // 
            // columnHeader_orderid
            // 
            this.columnHeader_orderid.Text = "Order ID";
            this.columnHeader_orderid.Width = 125;
            // 
            // ManagerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl_manager);
            this.Name = "ManagerGUI";
            this.Text = "Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerGUI_FormClosing);
            this.Load += new System.EventHandler(this.ManagerGUI_Load);
            this.tabControl_manager.ResumeLayout(false);
            this.tabP_pendingorders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pendingorders)).EndInit();
            this.tabP_paymenthistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_manager;
        private System.Windows.Forms.TabPage tabP_pendingorders;
        private System.Windows.Forms.TabPage tabP_paymenthistory;
        private System.Windows.Forms.ListView listView_paymenthistory;
        private System.Windows.Forms.ColumnHeader columnHeader_paymentid;
        private System.Windows.Forms.ColumnHeader columnHeader_userid;
        private System.Windows.Forms.ColumnHeader columnHeader_orderid;
        private System.Windows.Forms.Button btn_decline;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.DataGridView dataGridView_pendingorders;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendingorderid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendingorder_itemid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendingorder_userid;
    }
}