namespace Login
{
    partial class ActiveClubsReport
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
            this.lblClublist = new System.Windows.Forms.Label();
            this.lstClub = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblClublist
            // 
            this.lblClublist.AutoSize = true;
            this.lblClublist.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClublist.Location = new System.Drawing.Point(12, 17);
            this.lblClublist.Name = "lblClublist";
            this.lblClublist.Size = new System.Drawing.Size(147, 25);
            this.lblClublist.TabIndex = 14;
            this.lblClublist.Text = "Active Club List";
            // 
            // lstClub
            // 
            this.lstClub.FormattingEnabled = true;
            this.lstClub.ItemHeight = 25;
            this.lstClub.Location = new System.Drawing.Point(16, 49);
            this.lstClub.Name = "lstClub";
            this.lstClub.ScrollAlwaysVisible = true;
            this.lstClub.Size = new System.Drawing.Size(395, 379);
            this.lstClub.TabIndex = 15;
            this.lstClub.SelectedIndexChanged += new System.EventHandler(this.lstClub_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(311, 461);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 31);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 514);
            this.panel1.TabIndex = 17;
            // 
            // ActiveClubsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstClub);
            this.Controls.Add(this.lblClublist);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ActiveClubsReport";
            this.Text = "ActiveClubsReport";
            this.Load += new System.EventHandler(this.ActiveClubsReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClublist;
        private System.Windows.Forms.ListBox lstClub;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
    }
}