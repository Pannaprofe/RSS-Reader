namespace RSS_Reader
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.TableLayoutPanel();
            this.txt_CurrentNews = new System.Windows.Forms.RichTextBox();
            this.SportCB = new System.Windows.Forms.CheckBox();
            this.BusinessCB = new System.Windows.Forms.CheckBox();
            this.TechnologyCB = new System.Windows.Forms.CheckBox();
            this.StarLifeCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the category";
            // 
            // Panel
            // 
            this.Panel.AutoScroll = true;
            this.Panel.ColumnCount = 1;
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel.Location = new System.Drawing.Point(135, 9);
            this.Panel.Name = "Panel";
            this.Panel.RowCount = 1;
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Panel.Size = new System.Drawing.Size(253, 232);
            this.Panel.TabIndex = 6;
            // 
            // txt_CurrentNews
            // 
            this.txt_CurrentNews.BackColor = System.Drawing.Color.White;
            this.txt_CurrentNews.Location = new System.Drawing.Point(403, 9);
            this.txt_CurrentNews.Name = "txt_CurrentNews";
            this.txt_CurrentNews.ReadOnly = true;
            this.txt_CurrentNews.Size = new System.Drawing.Size(218, 232);
            this.txt_CurrentNews.TabIndex = 7;
            this.txt_CurrentNews.Text = "Double click on any news in the left panel";
            this.txt_CurrentNews.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.txt_CurrentNews_LinkClicked);
            // 
            // SportCB
            // 
            this.SportCB.AutoSize = true;
            this.SportCB.Location = new System.Drawing.Point(12, 34);
            this.SportCB.Name = "SportCB";
            this.SportCB.Size = new System.Drawing.Size(51, 17);
            this.SportCB.TabIndex = 8;
            this.SportCB.Text = "Sport";
            this.SportCB.UseVisualStyleBackColor = true;
            this.SportCB.CheckedChanged += new System.EventHandler(this.SportCB_CheckedChanged);
            // 
            // BusinessCB
            // 
            this.BusinessCB.AutoSize = true;
            this.BusinessCB.Location = new System.Drawing.Point(12, 57);
            this.BusinessCB.Name = "BusinessCB";
            this.BusinessCB.Size = new System.Drawing.Size(68, 17);
            this.BusinessCB.TabIndex = 9;
            this.BusinessCB.Text = "Business";
            this.BusinessCB.UseVisualStyleBackColor = true;
            this.BusinessCB.CheckedChanged += new System.EventHandler(this.BusinessCB_CheckedChanged);
            // 
            // TechnologyCB
            // 
            this.TechnologyCB.AutoSize = true;
            this.TechnologyCB.Location = new System.Drawing.Point(12, 80);
            this.TechnologyCB.Name = "TechnologyCB";
            this.TechnologyCB.Size = new System.Drawing.Size(96, 17);
            this.TechnologyCB.TabIndex = 10;
            this.TechnologyCB.Text = "TechnologyCB";
            this.TechnologyCB.UseVisualStyleBackColor = true;
            this.TechnologyCB.CheckedChanged += new System.EventHandler(this.TechnologyCB_CheckedChanged);
            // 
            // StarLifeCB
            // 
            this.StarLifeCB.AutoSize = true;
            this.StarLifeCB.Location = new System.Drawing.Point(11, 103);
            this.StarLifeCB.Name = "StarLifeCB";
            this.StarLifeCB.Size = new System.Drawing.Size(65, 17);
            this.StarLifeCB.TabIndex = 11;
            this.StarLifeCB.Text = "Star Life";
            this.StarLifeCB.UseVisualStyleBackColor = true;
            this.StarLifeCB.CheckedChanged += new System.EventHandler(this.StarLifeCB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 252);
            this.Controls.Add(this.StarLifeCB);
            this.Controls.Add(this.TechnologyCB);
            this.Controls.Add(this.BusinessCB);
            this.Controls.Add(this.SportCB);
            this.Controls.Add(this.txt_CurrentNews);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel Panel;
        private System.Windows.Forms.RichTextBox txt_CurrentNews;
        private System.Windows.Forms.CheckBox SportCB;
        private System.Windows.Forms.CheckBox BusinessCB;
        private System.Windows.Forms.CheckBox TechnologyCB;
        private System.Windows.Forms.CheckBox StarLifeCB;
    }
}

