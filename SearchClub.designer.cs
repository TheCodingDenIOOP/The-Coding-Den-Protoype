﻿namespace WindowsFormsApp2
{
    partial class Search
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textSN = new System.Windows.Forms.TextBox();
            this.LearnMore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(559, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSN
            // 
            this.textSN.AcceptsReturn = true;
            this.textSN.AcceptsTab = true;
            this.textSN.AllowDrop = true;
            this.textSN.Location = new System.Drawing.Point(300, 62);
            this.textSN.Multiline = true;
            this.textSN.Name = "textSN";
            this.textSN.Size = new System.Drawing.Size(253, 26);
            this.textSN.TabIndex = 2;
            this.textSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textSN.Enter += new System.EventHandler(this.textSN_Enter);
            this.textSN.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textSN_PreviewKeyDown);
            // 
            // LearnMore
            // 
            this.LearnMore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LearnMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LearnMore.Location = new System.Drawing.Point(559, 394);
            this.LearnMore.Name = "LearnMore";
            this.LearnMore.Size = new System.Drawing.Size(98, 39);
            this.LearnMore.TabIndex = 3;
            this.LearnMore.Text = "More";
            this.LearnMore.UseVisualStyleBackColor = false;
            this.LearnMore.Click += new System.EventHandler(this.LearnMore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Club Name or ID(Keywords) :";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(31, 137);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 27;
            this.dgv.Size = new System.Drawing.Size(626, 230);
            this.dgv.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 447);
            this.panel1.TabIndex = 6;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 445);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LearnMore);
            this.Controls.Add(this.textSN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Club";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textSN;
        private System.Windows.Forms.Button LearnMore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel1;
    }
}

