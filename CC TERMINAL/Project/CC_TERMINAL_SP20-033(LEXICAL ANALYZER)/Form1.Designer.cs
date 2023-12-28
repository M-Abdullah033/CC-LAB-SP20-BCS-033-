namespace CC_TERMINAL_005_LEXICAL_ANALYZER_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtInput = new TextBox();
            btnAnalyze = new Button();
            lstTokens = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.BackColor = SystemColors.MenuText;
            txtInput.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtInput.ForeColor = Color.Yellow;
            txtInput.Location = new Point(12, 90);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(316, 342);
            txtInput.TabIndex = 0;
            // 
            // btnAnalyze
            // 
            btnAnalyze.BackColor = SystemColors.MenuHighlight;
            btnAnalyze.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnalyze.ForeColor = Color.Yellow;
            btnAnalyze.Location = new Point(352, 137);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(149, 63);
            btnAnalyze.TabIndex = 1;
            btnAnalyze.Text = "Analyze";
            btnAnalyze.UseVisualStyleBackColor = false;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // lstTokens
            // 
            lstTokens.BackColor = SystemColors.MenuText;
            lstTokens.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lstTokens.ForeColor = Color.Yellow;
            lstTokens.FormattingEnabled = true;
            lstTokens.ItemHeight = 26;
            lstTokens.Location = new Point(542, 90);
            lstTokens.Name = "lstTokens";
            lstTokens.Size = new Size(246, 342);
            lstTokens.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(49, 36);
            label1.Name = "label1";
            label1.Size = new Size(204, 35);
            label1.TabIndex = 3;
            label1.Text = "INPUT CODE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(599, 36);
            label2.Name = "label2";
            label2.Size = new Size(141, 35);
            label2.TabIndex = 4;
            label2.Text = "OUTPUT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstTokens);
            Controls.Add(btnAnalyze);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnAnalyze;
        private ListBox lstTokens;
        private Label label1;
        private Label label2;
    }
}