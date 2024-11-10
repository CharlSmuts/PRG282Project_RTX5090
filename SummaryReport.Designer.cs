namespace Project
{
    partial class SummaryReport
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
            this.btnExitSummary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // btnExitSummary
            // 
            this.btnExitSummary.Location = new System.Drawing.Point(695, 9);
            this.btnExitSummary.Name = "btnExitSummary";
            this.btnExitSummary.Size = new System.Drawing.Size(93, 33);
            this.btnExitSummary.TabIndex = 1;
            this.btnExitSummary.Text = "Exit";
            this.btnExitSummary.UseVisualStyleBackColor = true;
            this.btnExitSummary.Click += new System.EventHandler(this.button1_Click);
            // 
            // SummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitSummary);
            this.Controls.Add(this.label1);
            this.Name = "SummaryReport";
            this.Text = "SummaryReport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SummaryReport_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExitSummary;
    }
}