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
    public partial class REtm : Form
    {
        public REtm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Create DataGridView and set properties
            dataGridView1 = new DataGridView();
            dataGridView1.Location = new System.Drawing.Point(12, 100);
            dataGridView1.Size = new System.Drawing.Size(200, 100);

            // Add DataGridView to the form
            this.Controls.Add(dataGridView1);

            // Add a single column for the DataGridView
            dataGridView1.Columns.Add("MatchedWords", "Matched Words");
        }
        private void REtm_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string documentText = richTextBox1.Text;
            string pattern = @"\b[tTmM]\w*\b"; // Regular expression to match words starting with 't' or 'm'

            MatchCollection matches = Regex.Matches(documentText, pattern);

            dataGridView1.Rows.Clear(); // Clear previous results

            foreach (Match match in matches)
            {
                dataGridView1.Rows.Add(match.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

      

    }
}
