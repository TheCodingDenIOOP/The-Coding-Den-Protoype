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
            this.txtPresident = new System.Windows.Forms.TextBox();
            this.txtVPresident = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtRgstDate = new System.Windows.Forms.TextBox();
            this.txtSecretary = new System.Windows.Forms.TextBox();
            this.txtClubName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblRgstDate = new System.Windows.Forms.Label();
            this.lblSecretary = new System.Windows.Forms.Label();
            this.lblVPresident = new System.Windows.Forms.Label();
            this.lblPresident = new System.Windows.Forms.Label();
            this.lblClubName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblMembers = new System.Windows.Forms.Label();
            this.lstMembers = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPresident
            // 
            this.txtPresident.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPresident.Location = new System.Drawing.Point(206, 251);
            this.txtPresident.MaxLength = 50;
            this.txtPresident.Name = "txtPresident";
            this.txtPresident.Size = new System.Drawing.Size(281, 30);
            this.txtPresident.TabIndex = 16;
            // 
            // txtVPresident
            // 
            this.txtVPresident.Location = new System.Drawing.Point(206, 311);
            this.txtVPresident.MaxLength = 50;
            this.txtVPresident.Name = "txtVPresident";
            this.txtVPresident.Size = new System.Drawing.Size(281, 30);
            this.txtVPresident.TabIndex = 17;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(205, 503);
            this.txtDescription.MaxLength = 500;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(282, 145);
            this.txtDescription.TabIndex = 24;
            // 
            // txtRgstDate
            // 
            this.txtRgstDate.Location = new System.Drawing.Point(206, 435);
            this.txtRgstDate.MaxLength = 50;
            this.txtRgstDate.Name = "txtRgstDate";
            this.txtRgstDate.ReadOnly = true;
            this.txtRgstDate.Size = new System.Drawing.Size(281, 30);
            this.txtRgstDate.TabIndex = 21;
            // 
            // txtSecretary
            // 
            this.txtSecretary.Location = new System.Drawing.Point(206, 376);
            this.txtSecretary.MaxLength = 50;
            this.txtSecretary.Name = "txtSecretary";
            this.txtSecretary.Size = new System.Drawing.Size(281, 30);
            this.txtSecretary.TabIndex = 19;
            // 
            // txtClubName
            // 
            this.txtClubName.Location = new System.Drawing.Point(206, 192);
            this.txtClubName.MaxLength = 50;
            this.txtClubName.Name = "txtClubName";
            this.txtClubName.ReadOnly = true;
            this.txtClubName.Size = new System.Drawing.Size(281, 30);
            this.txtClubName.TabIndex = 13;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(239, 1121);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 28);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Confirm Change";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(397, 1121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 28);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpload.Location = new System.Drawing.Point(206, 133);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(90, 33);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(206, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblDesc.Location = new System.Drawing.Point(33, 506);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(155, 25);
            this.lblDesc.TabIndex = 22;
            this.lblDesc.Text = "Club Description";
            // 
            // lblRgstDate
            // 
            this.lblRgstDate.AutoSize = true;
            this.lblRgstDate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblRgstDate.Location = new System.Drawing.Point(33, 438);
            this.lblRgstDate.Name = "lblRgstDate";
            this.lblRgstDate.Size = new System.Drawing.Size(129, 25);
            this.lblRgstDate.TabIndex = 20;
            this.lblRgstDate.Text = "Register Date";
            // 
            // lblSecretary
            // 
            this.lblSecretary.AutoSize = true;
            this.lblSecretary.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblSecretary.Location = new System.Drawing.Point(33, 379);
            this.lblSecretary.Name = "lblSecretary";
            this.lblSecretary.Size = new System.Drawing.Size(96, 25);
            this.lblSecretary.TabIndex = 18;
            this.lblSecretary.Text = "Secretary";
            // 
            // lblVPresident
            // 
            this.lblVPresident.AutoSize = true;
            this.lblVPresident.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblVPresident.Location = new System.Drawing.Point(33, 317);
            this.lblVPresident.Name = "lblVPresident";
            this.lblVPresident.Size = new System.Drawing.Size(138, 25);
            this.lblVPresident.TabIndex = 15;
            this.lblVPresident.Text = "Vice President";
            // 
            // lblPresident
            // 
            this.lblPresident.AutoSize = true;
            this.lblPresident.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblPresident.Location = new System.Drawing.Point(33, 254);
            this.lblPresident.Name = "lblPresident";
            this.lblPresident.Size = new System.Drawing.Size(94, 25);
            this.lblPresident.TabIndex = 14;
            this.lblPresident.Text = "President";
            // 
            // lblClubName
            // 
            this.lblClubName.AutoSize = true;
            this.lblClubName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClubName.Location = new System.Drawing.Point(33, 195);
            this.lblClubName.Name = "lblClubName";
            this.lblClubName.Size = new System.Drawing.Size(110, 25);
            this.lblClubName.TabIndex = 11;
            this.lblClubName.Text = "Club Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Club Logo";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(398, 700);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 37);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(38, 704);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(359, 30);
            this.txtSearch.TabIndex = 30;
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblMembers.Location = new System.Drawing.Point(33, 678);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(140, 25);
            this.lblMembers.TabIndex = 29;
            this.lblMembers.Text = "Club Members";
            // 
            // lstMembers
            // 
            this.lstMembers.FormattingEnabled = true;
            this.lstMembers.ItemHeight = 25;
            this.lstMembers.Location = new System.Drawing.Point(37, 737);
            this.lstMembers.Name = "lstMembers";
            this.lstMembers.ScrollAlwaysVisible = true;
            this.lstMembers.Size = new System.Drawing.Size(450, 254);
            this.lstMembers.TabIndex = 28;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(277, 1007);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 36);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Location = new System.Drawing.Point(382, 1007);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(105, 36);
            this.btnRemove.TabIndex = 33;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 1058);
            this.panel1.TabIndex = 34;
            // 
            // EditClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 1055);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblMembers);
            this.Controls.Add(this.lstMembers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPresident);
            this.Controls.Add(this.txtVPresident);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtRgstDate);
            this.Controls.Add(this.txtSecretary);
            this.Controls.Add(this.txtClubName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblRgstDate);
            this.Controls.Add(this.lblSecretary);
            this.Controls.Add(this.lblVPresident);
            this.Controls.Add(this.lblPresident);
            this.Controls.Add(this.lblClubName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditClub";
            this.Text = "EditClub";
            this.Load += new System.EventHandler(this.EditClub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPresident;
        private System.Windows.Forms.TextBox txtVPresident;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtRgstDate;
        private System.Windows.Forms.TextBox txtSecretary;
        private System.Windows.Forms.TextBox txtClubName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblRgstDate;
        private System.Windows.Forms.Label lblSecretary;
        private System.Windows.Forms.Label lblVPresident;
        private System.Windows.Forms.Label lblPresident;
        private System.Windows.Forms.Label lblClubName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.ListBox lstMembers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panel1;
    }
}