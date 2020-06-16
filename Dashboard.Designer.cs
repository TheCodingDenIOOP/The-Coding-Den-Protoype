namespace Login
{
    partial class Dashboard
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblGenerateRp = new System.Windows.Forms.Label();
            this.btnAddClub = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnArchived = new System.Windows.Forms.Button();
            this.btnClubAct = new System.Windows.Forms.Button();
            this.btnActiveClub = new System.Windows.Forms.Button();
            this.lstClub = new System.Windows.Forms.ListBox();
            this.lblClublist = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(478, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGenerateRp
            // 
            this.lblGenerateRp.AutoSize = true;
            this.lblGenerateRp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblGenerateRp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenerateRp.Location = new System.Drawing.Point(474, 211);
            this.lblGenerateRp.Name = "lblGenerateRp";
            this.lblGenerateRp.Size = new System.Drawing.Size(154, 25);
            this.lblGenerateRp.TabIndex = 6;
            this.lblGenerateRp.Text = "Generate report:";
            // 
            // btnAddClub
            // 
            this.btnAddClub.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddClub.Location = new System.Drawing.Point(478, 54);
            this.btnAddClub.Name = "btnAddClub";
            this.btnAddClub.Size = new System.Drawing.Size(133, 31);
            this.btnAddClub.TabIndex = 7;
            this.btnAddClub.Text = "Add New Club";
            this.btnAddClub.UseVisualStyleBackColor = false;
            this.btnAddClub.Click += new System.EventHandler(this.btnAddClub_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInfo.Location = new System.Drawing.Point(478, 91);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(133, 31);
            this.btnInfo.TabIndex = 8;
            this.btnInfo.Text = "Club Info";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnArchived
            // 
            this.btnArchived.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnArchived.Location = new System.Drawing.Point(478, 165);
            this.btnArchived.Name = "btnArchived";
            this.btnArchived.Size = new System.Drawing.Size(133, 31);
            this.btnArchived.TabIndex = 9;
            this.btnArchived.Text = "Archived";
            this.btnArchived.UseVisualStyleBackColor = false;
            this.btnArchived.Click += new System.EventHandler(this.btnArchived_Click);
            // 
            // btnClubAct
            // 
            this.btnClubAct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClubAct.Location = new System.Drawing.Point(478, 276);
            this.btnClubAct.Name = "btnClubAct";
            this.btnClubAct.Size = new System.Drawing.Size(133, 31);
            this.btnClubAct.TabIndex = 10;
            this.btnClubAct.Text = "Club Activities";
            this.btnClubAct.UseVisualStyleBackColor = false;
            this.btnClubAct.Click += new System.EventHandler(this.btnClubAct_Click);
            // 
            // btnActiveClub
            // 
            this.btnActiveClub.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActiveClub.Location = new System.Drawing.Point(478, 239);
            this.btnActiveClub.Name = "btnActiveClub";
            this.btnActiveClub.Size = new System.Drawing.Size(133, 31);
            this.btnActiveClub.TabIndex = 11;
            this.btnActiveClub.Text = "Active Club List";
            this.btnActiveClub.UseVisualStyleBackColor = false;
            this.btnActiveClub.Click += new System.EventHandler(this.btnActiveClub_Click);
            // 
            // lstClub
            // 
            this.lstClub.FormattingEnabled = true;
            this.lstClub.ItemHeight = 25;
            this.lstClub.Location = new System.Drawing.Point(35, 90);
            this.lstClub.Name = "lstClub";
            this.lstClub.ScrollAlwaysVisible = true;
            this.lstClub.Size = new System.Drawing.Size(408, 254);
            this.lstClub.TabIndex = 12;
            this.lstClub.SelectedIndexChanged += new System.EventHandler(this.lstClub_SelectedIndexChanged);
            // 
            // lblClublist
            // 
            this.lblClublist.AutoSize = true;
            this.lblClublist.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClublist.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClublist.Location = new System.Drawing.Point(31, 34);
            this.lblClublist.Name = "lblClublist";
            this.lblClublist.Size = new System.Drawing.Size(147, 25);
            this.lblClublist.TabIndex = 13;
            this.lblClublist.Text = "Active Club List";
            this.lblClublist.Click += new System.EventHandler(this.lblClublist_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(36, 58);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(315, 30);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(350, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 34);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Location = new System.Drawing.Point(478, 128);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(133, 31);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 417);
            this.panel1.TabIndex = 17;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 416);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblClublist);
            this.Controls.Add(this.lstClub);
            this.Controls.Add(this.btnActiveClub);
            this.Controls.Add(this.btnClubAct);
            this.Controls.Add(this.btnArchived);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnAddClub);
            this.Controls.Add(this.lblGenerateRp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblGenerateRp;
        private System.Windows.Forms.Button btnAddClub;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnArchived;
        private System.Windows.Forms.Button btnClubAct;
        private System.Windows.Forms.Button btnActiveClub;
        private System.Windows.Forms.ListBox lstClub;
        private System.Windows.Forms.Label lblClublist;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panel1;
    }
}