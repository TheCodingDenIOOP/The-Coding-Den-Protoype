namespace Login
{
    partial class EditClub
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClubID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstMembers = new System.Windows.Forms.ListBox();
            this.lblMembers = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblClubName = new System.Windows.Forms.Label();
            this.lblPresident = new System.Windows.Forms.Label();
            this.lblVPresident = new System.Windows.Forms.Label();
            this.lblSecretary = new System.Windows.Forms.Label();
            this.lblRgstDate = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtClubName = new System.Windows.Forms.TextBox();
            this.txtSecretary = new System.Windows.Forms.TextBox();
            this.txtRgstDate = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtVPresident = new System.Windows.Forms.TextBox();
            this.txtPresident = new System.Windows.Forms.TextBox();
            this.txtClubID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.txtClubID);
            this.panel1.Controls.Add(this.lblClubID);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblClubName);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblPresident);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.lblVPresident);
            this.panel1.Controls.Add(this.lblMembers);
            this.panel1.Controls.Add(this.lblSecretary);
            this.panel1.Controls.Add(this.lstMembers);
            this.panel1.Controls.Add(this.lblRgstDate);
            this.panel1.Controls.Add(this.txtPresident);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.txtVPresident);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.txtRgstDate);
            this.panel1.Controls.Add(this.txtClubName);
            this.panel1.Controls.Add(this.txtSecretary);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 1058);
            this.panel1.TabIndex = 34;
            // 
            // lblClubID
            // 
            this.lblClubID.AutoSize = true;
            this.lblClubID.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClubID.Location = new System.Drawing.Point(48, 33);
            this.lblClubID.Name = "lblClubID";
            this.lblClubID.Size = new System.Drawing.Size(62, 20);
            this.lblClubID.TabIndex = 33;
            this.lblClubID.Text = "Club ID";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(385, 878);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 36);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add Member";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstMembers
            // 
            this.lstMembers.FormattingEnabled = true;
            this.lstMembers.ItemHeight = 20;
            this.lstMembers.Location = new System.Drawing.Point(52, 628);
            this.lstMembers.Name = "lstMembers";
            this.lstMembers.ScrollAlwaysVisible = true;
            this.lstMembers.Size = new System.Drawing.Size(450, 244);
            this.lstMembers.TabIndex = 28;
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblMembers.Location = new System.Drawing.Point(48, 569);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(111, 20);
            this.lblMembers.TabIndex = 29;
            this.lblMembers.Text = "Club Members";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(53, 595);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(359, 26);
            this.txtSearch.TabIndex = 30;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(413, 591);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 37);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblClubName
            // 
            this.lblClubName.AutoSize = true;
            this.lblClubName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClubName.Location = new System.Drawing.Point(48, 86);
            this.lblClubName.Name = "lblClubName";
            this.lblClubName.Size = new System.Drawing.Size(87, 20);
            this.lblClubName.TabIndex = 11;
            this.lblClubName.Text = "Club Name";
            // 
            // lblPresident
            // 
            this.lblPresident.AutoSize = true;
            this.lblPresident.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblPresident.Location = new System.Drawing.Point(48, 145);
            this.lblPresident.Name = "lblPresident";
            this.lblPresident.Size = new System.Drawing.Size(76, 20);
            this.lblPresident.TabIndex = 14;
            this.lblPresident.Text = "President";
            // 
            // lblVPresident
            // 
            this.lblVPresident.AutoSize = true;
            this.lblVPresident.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblVPresident.Location = new System.Drawing.Point(48, 208);
            this.lblVPresident.Name = "lblVPresident";
            this.lblVPresident.Size = new System.Drawing.Size(111, 20);
            this.lblVPresident.TabIndex = 15;
            this.lblVPresident.Text = "Vice President";
            // 
            // lblSecretary
            // 
            this.lblSecretary.AutoSize = true;
            this.lblSecretary.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblSecretary.Location = new System.Drawing.Point(48, 270);
            this.lblSecretary.Name = "lblSecretary";
            this.lblSecretary.Size = new System.Drawing.Size(77, 20);
            this.lblSecretary.TabIndex = 18;
            this.lblSecretary.Text = "Secretary";
            // 
            // lblRgstDate
            // 
            this.lblRgstDate.AutoSize = true;
            this.lblRgstDate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblRgstDate.Location = new System.Drawing.Point(48, 329);
            this.lblRgstDate.Name = "lblRgstDate";
            this.lblRgstDate.Size = new System.Drawing.Size(108, 20);
            this.lblRgstDate.TabIndex = 20;
            this.lblRgstDate.Text = "Register Date";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblDesc.Location = new System.Drawing.Point(48, 397);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(125, 20);
            this.lblDesc.TabIndex = 22;
            this.lblDesc.Text = "Club Description";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(412, 938);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 36);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(249, 938);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 36);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Confirm Change";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtClubName
            // 
            this.txtClubName.Location = new System.Drawing.Point(221, 83);
            this.txtClubName.MaxLength = 50;
            this.txtClubName.Name = "txtClubName";
            this.txtClubName.ReadOnly = true;
            this.txtClubName.Size = new System.Drawing.Size(281, 26);
            this.txtClubName.TabIndex = 13;
            // 
            // txtSecretary
            // 
            this.txtSecretary.Location = new System.Drawing.Point(221, 267);
            this.txtSecretary.MaxLength = 50;
            this.txtSecretary.Name = "txtSecretary";
            this.txtSecretary.Size = new System.Drawing.Size(281, 26);
            this.txtSecretary.TabIndex = 19;
            // 
            // txtRgstDate
            // 
            this.txtRgstDate.Location = new System.Drawing.Point(221, 326);
            this.txtRgstDate.MaxLength = 50;
            this.txtRgstDate.Name = "txtRgstDate";
            this.txtRgstDate.ReadOnly = true;
            this.txtRgstDate.Size = new System.Drawing.Size(281, 26);
            this.txtRgstDate.TabIndex = 21;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(220, 394);
            this.txtDescription.MaxLength = 500;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(282, 145);
            this.txtDescription.TabIndex = 24;
            // 
            // txtVPresident
            // 
            this.txtVPresident.Location = new System.Drawing.Point(221, 202);
            this.txtVPresident.MaxLength = 50;
            this.txtVPresident.Name = "txtVPresident";
            this.txtVPresident.Size = new System.Drawing.Size(281, 26);
            this.txtVPresident.TabIndex = 17;
            // 
            // txtPresident
            // 
            this.txtPresident.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPresident.Location = new System.Drawing.Point(221, 142);
            this.txtPresident.MaxLength = 50;
            this.txtPresident.Name = "txtPresident";
            this.txtPresident.Size = new System.Drawing.Size(281, 26);
            this.txtPresident.TabIndex = 16;
            // 
            // txtClubID
            // 
            this.txtClubID.Location = new System.Drawing.Point(222, 30);
            this.txtClubID.MaxLength = 50;
            this.txtClubID.Name = "txtClubID";
            this.txtClubID.ReadOnly = true;
            this.txtClubID.Size = new System.Drawing.Size(281, 26);
            this.txtClubID.TabIndex = 34;
            // 
            // EditClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 991);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditClub";
            this.Text = "EditClub";
            this.Load += new System.EventHandler(this.EditClub_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtClubID;
        private System.Windows.Forms.Label lblClubID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblClubName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPresident;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblVPresident;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.Label lblSecretary;
        private System.Windows.Forms.ListBox lstMembers;
        private System.Windows.Forms.Label lblRgstDate;
        private System.Windows.Forms.TextBox txtPresident;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtVPresident;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtRgstDate;
        private System.Windows.Forms.TextBox txtClubName;
        private System.Windows.Forms.TextBox txtSecretary;
    }
}