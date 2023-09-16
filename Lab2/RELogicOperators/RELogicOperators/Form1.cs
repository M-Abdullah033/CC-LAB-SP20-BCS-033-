using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RELogicOperators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String var = richTextBox1.Text;

            // Initialize richTextBox2 text
            richTextBox2.Text = "";

            // Regular Expression for operators
            Regex regex1 = new Regex(@"\b(&&|\|\||!|<|>|<=|>=|==|!=)+\b");
           
            // Find matches for the pattern
            MatchCollection matches = regex1.Matches(var);

            // Display the matches in richTextBox2
            foreach (Match match in matches)
            {
                richTextBox2.Text += match.Value + "  ";
            }
        }
    }
}
