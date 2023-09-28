namespace SymbolTable
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
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxSymbolTable = new System.Windows.Forms.ListBox();
            this.txtRetrieve = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(225, 12);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(189, 26);
            this.txtSymbol.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "RETRIEVE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxSymbolTable
            // 
            this.listBoxSymbolTable.FormattingEnabled = true;
            this.listBoxSymbolTable.ItemHeight = 20;
            this.listBoxSymbolTable.Location = new System.Drawing.Point(207, 171);
            this.listBoxSymbolTable.Name = "listBoxSymbolTable";
            this.listBoxSymbolTable.Size = new System.Drawing.Size(227, 264);
            this.listBoxSymbolTable.TabIndex = 3;
            // 
            // txtRetrieve
            // 
            this.txtRetrieve.Location = new System.Drawing.Point(225, 64);
            this.txtRetrieve.Name = "txtRetrieve";
            this.txtRetrieve.Size = new System.Drawing.Size(189, 26);
            this.txtRetrieve.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 447);
            this.Controls.Add(this.txtRetrieve);
            this.Controls.Add(this.listBoxSymbolTable);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSymbol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxSymbolTable;
        private System.Windows.Forms.TextBox txtRetrieve;
    }
}

