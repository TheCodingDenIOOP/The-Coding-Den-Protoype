namespace Login
{
    partial class Archived
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblClublist = new System.Windows.Forms.Label();
            this.lstClub = new System.Windows.Forms.ListBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(348, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 34);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(33, 55);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(315, 30);
            this.txtSearch.TabIndex = 25;
            // 
            // lblClublist
            // 
            this.lblClublist.AutoSize = true;
            this.lblClublist.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClublist.Location = new System.Drawing.Point(29, 30);
            this.lblClublist.Name = "lblClublist";
            this.lblClublist.Size = new System.Drawing.Size(170, 25);
            this.lblClublist.TabIndex = 24;
            this.lblClublist.Text = "Archived Club List";
            // 
            // lstClub
            // 
            this.lstClub.FormattingEnabled = true;
            this.lstClub.ItemHeight = 25;
            this.lstClub.Location = new System.Drawing.Point(33, 86);
            this.lstClub.Name = "lstClub";
            this.lstClub.Size = new System.Drawing.Size(404, 254);
            this.lstClub.TabIndex = 23;
            this.lstClub.SelectedIndexChanged += new System.EventHandler(this.lstClub_SelectedIndexChanged);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDel.Location = new System.Drawing.Point(476, 97);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(133, 31);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAct
            // 
            this.btnAct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAct.Location = new System.Drawing.Point(476, 60);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(133, 31);
            this.btnAct.TabIndex = 18;
            this.btnAct.Text = "Activate";
            this.btnAct.UseVisualStyleBackColor = false;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(476, 356);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 31);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 416);
            this.panel1.TabIndex = 27;
            // 
            // Archived
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 416);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblClublist);
            this.Controls.Add(this.lstClub);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Archived";
            this.Text = "Archived";
            this.Load += new System.EventHandler(this.Archived_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblClublist;
        private System.Windows.Forms.ListBox lstClub;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
    }
}