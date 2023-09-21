using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REFloating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            string input = InputTextBox.Text;
            string pattern = @"^-?\d{0,3}(?:\.\d{0,3})?$";

            if (Regex.IsMatch(input, pattern))
            {
               // ValidationLabel.Text = "Valid floating-point number.";
                MessageBox.Show("Valid floating-point number.","validation result",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
               // ValidationLabel.Text = "Not a valid floating-point number.";
                MessageBox.Show("Not a valid floating-point number.", "validation result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SingleRE f = new SingleRE();
            f.Show();
        }
    }
}
