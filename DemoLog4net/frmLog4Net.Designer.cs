namespace DemoLog4net
{
    partial class frmLog4Net
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnLogIt = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 166);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(489, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(36, 44);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(222, 20);
            this.txtMessage.TabIndex = 1;
            // 
            // btnLogIt
            // 
            this.btnLogIt.Location = new System.Drawing.Point(36, 98);
            this.btnLogIt.Name = "btnLogIt";
            this.btnLogIt.Size = new System.Drawing.Size(75, 23);
            this.btnLogIt.TabIndex = 2;
            this.btnLogIt.Text = "Log It";
            this.btnLogIt.UseVisualStyleBackColor = true;
            this.btnLogIt.Click += new System.EventHandler(this.btnLogIt_Click);
            // 
            // frmLog4Net
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 188);
            this.Controls.Add(this.btnLogIt);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmLog4Net";
            this.Text = "Log4Net";
            this.Load += new System.EventHandler(this.frmLog4Net_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnLogIt;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

