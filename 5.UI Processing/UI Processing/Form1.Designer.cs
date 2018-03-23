namespace UI_Processing
{
    partial class frmloop
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
            this.btncatch = new System.Windows.Forms.Button();
            this.rtxtouput = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btncatch
            // 
            this.btncatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btncatch.Location = new System.Drawing.Point(227, 262);
            this.btncatch.Name = "btncatch";
            this.btncatch.Size = new System.Drawing.Size(133, 35);
            this.btncatch.TabIndex = 0;
            this.btncatch.Text = "Catch";
            this.btncatch.UseVisualStyleBackColor = true;
            this.btncatch.Click += new System.EventHandler(this.btncatch_Click);
            // 
            // rtxtouput
            // 
            this.rtxtouput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtouput.Location = new System.Drawing.Point(26, 12);
            this.rtxtouput.Name = "rtxtouput";
            this.rtxtouput.Size = new System.Drawing.Size(334, 244);
            this.rtxtouput.TabIndex = 2;
            this.rtxtouput.Text = "";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // frmloop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(385, 302);
            this.Controls.Add(this.rtxtouput);
            this.Controls.Add(this.btncatch);
            this.Name = "frmloop";
            this.Text = "IUA C# Background Processing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmloop_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncatch;
        private System.Windows.Forms.RichTextBox rtxtouput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

