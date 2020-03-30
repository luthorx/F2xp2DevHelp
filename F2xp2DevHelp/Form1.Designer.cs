namespace F2xp2DevHelp
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
            this.AddDll = new System.Windows.Forms.Button();
            this.TreeAssemblies = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.chkForceSet = new System.Windows.Forms.CheckBox();
            this.chkData = new System.Windows.Forms.CheckedListBox();
            this.txtSet = new System.Windows.Forms.TextBox();
            this.cmbTemplates = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGet = new System.Windows.Forms.TextBox();
            this.txtTemplate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddDll
            // 
            this.AddDll.Location = new System.Drawing.Point(279, 12);
            this.AddDll.Name = "AddDll";
            this.AddDll.Size = new System.Drawing.Size(119, 23);
            this.AddDll.TabIndex = 0;
            this.AddDll.Text = "Select .Net Dll";
            this.AddDll.UseVisualStyleBackColor = true;
            this.AddDll.Click += new System.EventHandler(this.AddDll_Click);
            // 
            // TreeAssemblies
            // 
            this.TreeAssemblies.Location = new System.Drawing.Point(12, 12);
            this.TreeAssemblies.Name = "TreeAssemblies";
            this.TreeAssemblies.Size = new System.Drawing.Size(244, 387);
            this.TreeAssemblies.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(474, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkForceSet
            // 
            this.chkForceSet.AutoSize = true;
            this.chkForceSet.Checked = true;
            this.chkForceSet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkForceSet.Location = new System.Drawing.Point(279, 382);
            this.chkForceSet.Name = "chkForceSet";
            this.chkForceSet.Size = new System.Drawing.Size(168, 17);
            this.chkForceSet.TabIndex = 4;
            this.chkForceSet.Text = "Force to generate Set Method";
            this.chkForceSet.UseVisualStyleBackColor = true;
            // 
            // chkData
            // 
            this.chkData.FormattingEnabled = true;
            this.chkData.Location = new System.Drawing.Point(278, 41);
            this.chkData.Name = "chkData";
            this.chkData.Size = new System.Drawing.Size(457, 124);
            this.chkData.TabIndex = 5;
            this.chkData.Visible = false;
            // 
            // txtSet
            // 
            this.txtSet.Location = new System.Drawing.Point(804, 199);
            this.txtSet.Multiline = true;
            this.txtSet.Name = "txtSet";
            this.txtSet.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSet.Size = new System.Drawing.Size(208, 127);
            this.txtSet.TabIndex = 6;
            // 
            // cmbTemplates
            // 
            this.cmbTemplates.FormattingEnabled = true;
            this.cmbTemplates.Location = new System.Drawing.Point(278, 172);
            this.cmbTemplates.Name = "cmbTemplates";
            this.cmbTemplates.Size = new System.Drawing.Size(245, 21);
            this.cmbTemplates.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(804, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Template SET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Template GET";
            // 
            // txtGet
            // 
            this.txtGet.Location = new System.Drawing.Point(594, 199);
            this.txtGet.Multiline = true;
            this.txtGet.Name = "txtGet";
            this.txtGet.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGet.Size = new System.Drawing.Size(204, 127);
            this.txtGet.TabIndex = 9;
            // 
            // txtTemplate
            // 
            this.txtTemplate.Location = new System.Drawing.Point(278, 199);
            this.txtTemplate.Multiline = true;
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTemplate.Size = new System.Drawing.Size(310, 127);
            this.txtTemplate.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 415);
            this.Controls.Add(this.txtTemplate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTemplates);
            this.Controls.Add(this.txtSet);
            this.Controls.Add(this.chkData);
            this.Controls.Add(this.chkForceSet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TreeAssemblies);
            this.Controls.Add(this.AddDll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDll;
        private System.Windows.Forms.TreeView TreeAssemblies;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkForceSet;
        private System.Windows.Forms.CheckedListBox chkData;
        private System.Windows.Forms.TextBox txtSet;
        private System.Windows.Forms.ComboBox cmbTemplates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGet;
        private System.Windows.Forms.TextBox txtTemplate;
    }
}

