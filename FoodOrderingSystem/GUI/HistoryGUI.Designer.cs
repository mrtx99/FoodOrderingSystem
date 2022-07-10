
namespace FoodOrderingSystem.GUI
{
    partial class HistoryGUI
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
            this.btn_historyback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_historyback
            // 
            this.btn_historyback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_historyback.Location = new System.Drawing.Point(12, 415);
            this.btn_historyback.Name = "btn_historyback";
            this.btn_historyback.Size = new System.Drawing.Size(75, 23);
            this.btn_historyback.TabIndex = 0;
            this.btn_historyback.Text = "Back";
            this.btn_historyback.UseVisualStyleBackColor = true;
            this.btn_historyback.Click += new System.EventHandler(this.btn_historyback_Click);
            // 
            // HistoryGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_historyback);
            this.Name = "HistoryGUI";
            this.Text = "History";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HistoryGUI_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_historyback;
    }
}