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
    public partial class SingleRE : Form
    {
        public SingleRE()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            // Create DataGridView and set properties
            dataGridView1 = new DataGridView();
            dataGridView1.Location = new System.Drawing.Point(12, 40);
            dataGridView1.Size = new System.Drawing.Size(300, 200);

            // Add DataGridView to the form
            this.Controls.Add(dataGridView1);

            // Add a single column for the DataGridView
            dataGridView1.Columns.Add("ScientificNotation", "Valid Scientific Notation");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            string input = InputTextBox.Text;
            string pattern = @"^[+-]?\d+(\.\d+)?[eE][+-]?\d+$";

            if (Regex.IsMatch(input, pattern))
            {
                // Add the valid input to the DataGridView
                dataGridView1.Rows.Add(input);
            }
            else
            {
                MessageBox.Show("Not a valid scientific notation.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            REtm f = new REtm();
            f.Show();
        }
       
    }
}
