namespace Login
{
    partial class AddMember
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblClubName = new System.Windows.Forms.Label();
            this.lblClubID = new System.Windows.Forms.Label();
            this.txtClubID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(179, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 36);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(298, 151);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 36);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 59);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(259, 26);
            this.txtName.TabIndex = 36;
            // 
            // lblClubName
            // 
            this.lblClubName.AutoSize = true;
            this.lblClubName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClubName.Location = new System.Drawing.Point(12, 62);
            this.lblClubName.Name = "lblClubName";
            this.lblClubName.Size = new System.Drawing.Size(51, 20);
            this.lblClubName.TabIndex = 35;
            this.lblClubName.Text = "Name";
            // 
            // lblClubID
            // 
            this.lblClubID.AutoSize = true;
            this.lblClubID.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClubID.Location = new System.Drawing.Point(12, 19);
            this.lblClubID.Name = "lblClubID";
            this.lblClubID.Size = new System.Drawing.Size(62, 20);
            this.lblClubID.TabIndex = 37;
            this.lblClubID.Text = "Club ID";
            // 
            // txtClubID
            // 
            this.txtClubID.Location = new System.Drawing.Point(129, 12);
            this.txtClubID.MaxLength = 50;
            this.txtClubID.Name = "txtClubID";
            this.txtClubID.ReadOnly = true;
            this.txtClubID.Size = new System.Drawing.Size(53, 26);
            this.txtClubID.TabIndex = 38;
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(400, 199);
            this.Controls.Add(this.txtClubID);
            this.Controls.Add(this.lblClubID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblClubName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddMember";
            this.Text = "AddMember";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblClubName;
        private System.Windows.Forms.Label lblClubID;
        private System.Windows.Forms.TextBox txtClubID;
    }
}