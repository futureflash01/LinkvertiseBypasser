namespace LinkvertiseBypass
{
    partial class LinkvertiseBypassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinkvertiseBypassForm));
            this.bypassButton = new System.Windows.Forms.Button();
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.bypassedTextBox = new LinkvertiseBypass.LinkvertiseBypassForm.ReadOnlyTextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.bypassedLinkLabel = new System.Windows.Forms.Label();
            this.enterLinkLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bypassButton
            // 
            this.bypassButton.Location = new System.Drawing.Point(286, 69);
            this.bypassButton.Name = "bypassButton";
            this.bypassButton.Size = new System.Drawing.Size(75, 23);
            this.bypassButton.TabIndex = 0;
            this.bypassButton.Text = "Bypass";
            this.bypassButton.UseVisualStyleBackColor = true;
            this.bypassButton.Click += new System.EventHandler(this.bypassButton_Click);
            // 
            // linkTextBox
            // 
            this.linkTextBox.Location = new System.Drawing.Point(25, 34);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(593, 20);
            this.linkTextBox.TabIndex = 1;
            // 
            // bypassedTextBox
            // 
            this.bypassedTextBox.BackColor = System.Drawing.Color.White;
            this.bypassedTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bypassedTextBox.Location = new System.Drawing.Point(25, 163);
            this.bypassedTextBox.Name = "bypassedTextBox";
            this.bypassedTextBox.ReadOnly = true;
            this.bypassedTextBox.Size = new System.Drawing.Size(593, 20);
            this.bypassedTextBox.TabIndex = 999;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(286, 199);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 3;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // bypassedLinkLabel
            // 
            this.bypassedLinkLabel.AutoSize = true;
            this.bypassedLinkLabel.Location = new System.Drawing.Point(285, 139);
            this.bypassedLinkLabel.Name = "bypassedLinkLabel";
            this.bypassedLinkLabel.Size = new System.Drawing.Size(76, 13);
            this.bypassedLinkLabel.TabIndex = 5;
            this.bypassedLinkLabel.Text = "Bypassed Link";
            // 
            // enterLinkLabel
            // 
            this.enterLinkLabel.AutoSize = true;
            this.enterLinkLabel.Location = new System.Drawing.Point(274, 11);
            this.enterLinkLabel.Name = "enterLinkLabel";
            this.enterLinkLabel.Size = new System.Drawing.Size(106, 13);
            this.enterLinkLabel.TabIndex = 4;
            this.enterLinkLabel.Text = "Enter URL to Bypass";
            // 
            // LinkvertiseBypassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 251);
            this.Controls.Add(this.bypassedLinkLabel);
            this.Controls.Add(this.enterLinkLabel);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.bypassedTextBox);
            this.Controls.Add(this.linkTextBox);
            this.Controls.Add(this.bypassButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LinkvertiseBypassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinkvertiseBypass";
            this.Load += new System.EventHandler(this.LinkvertiseBypassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bypassButton;
        private System.Windows.Forms.TextBox linkTextBox;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Label bypassedLinkLabel;
        private System.Windows.Forms.Label enterLinkLabel;
        //private System.Windows.Forms.TextBox bypassedTextBox;
        private ReadOnlyTextBox bypassedTextBox;
    }
}

