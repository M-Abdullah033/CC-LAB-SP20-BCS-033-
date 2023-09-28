namespace TwoBufferLexicalA
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
            this.rtbBuffer2 = new System.Windows.Forms.RichTextBox();
            this.rtbBuffer1 = new System.Windows.Forms.RichTextBox();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbBuffer2
            // 
            this.rtbBuffer2.Location = new System.Drawing.Point(236, 166);
            this.rtbBuffer2.Name = "rtbBuffer2";
            this.rtbBuffer2.Size = new System.Drawing.Size(430, 107);
            this.rtbBuffer2.TabIndex = 0;
            this.rtbBuffer2.Text = "";
            // 
            // rtbBuffer1
            // 
            this.rtbBuffer1.Location = new System.Drawing.Point(54, 166);
            this.rtbBuffer1.Name = "rtbBuffer1";
            this.rtbBuffer1.Size = new System.Drawing.Size(151, 107);
            this.rtbBuffer1.TabIndex = 1;
            this.rtbBuffer1.Text = "";
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(54, 30);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(612, 105);
            this.rtbInput.TabIndex = 2;
            this.rtbInput.Text = "";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(268, 320);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(100, 47);
            this.btnAnalyze.TabIndex = 3;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 399);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.rtbInput);
            this.Controls.Add(this.rtbBuffer1);
            this.Controls.Add(this.rtbBuffer2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbBuffer2;
        private System.Windows.Forms.RichTextBox rtbBuffer1;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Button btnAnalyze;
    }
}

