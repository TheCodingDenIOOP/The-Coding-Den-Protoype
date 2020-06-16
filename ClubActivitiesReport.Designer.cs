namespace Login
{
    partial class ClubActivitiesReport
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lstActivities = new System.Windows.Forms.ListBox();
            this.lblClubAct = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(311, 461);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 31);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstActivities
            // 
            this.lstActivities.FormattingEnabled = true;
            this.lstActivities.ItemHeight = 25;
            this.lstActivities.Location = new System.Drawing.Point(16, 49);
            this.lstActivities.Name = "lstActivities";
            this.lstActivities.ScrollAlwaysVisible = true;
            this.lstActivities.Size = new System.Drawing.Size(395, 379);
            this.lstActivities.TabIndex = 18;
            this.lstActivities.SelectedIndexChanged += new System.EventHandler(this.lstActivities_SelectedIndexChanged);
            // 
            // lblClubAct
            // 
            this.lblClubAct.AutoSize = true;
            this.lblClubAct.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClubAct.Location = new System.Drawing.Point(12, 17);
            this.lblClubAct.Name = "lblClubAct";
            this.lblClubAct.Size = new System.Drawing.Size(135, 25);
            this.lblClubAct.TabIndex = 17;
            this.lblClubAct.Text = "Club Activities";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 514);
            this.panel1.TabIndex = 20;
            // 
            // ClubActivitiesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstActivities);
            this.Controls.Add(this.lblClubAct);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClubActivitiesReport";
            this.Text = "ClubActivities";
            this.Load += new System.EventHandler(this.ClubActivitiesReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstActivities;
        private System.Windows.Forms.Label lblClubAct;
        private System.Windows.Forms.Panel panel1;
    }
}