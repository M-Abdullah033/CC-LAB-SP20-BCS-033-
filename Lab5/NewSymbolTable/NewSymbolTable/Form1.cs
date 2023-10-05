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

namespace NewSymbolTable
{
    public partial class Form1 : Form
    {

        private Dictionary<string, string> symbolTable;

        public Form1()
        {
            InitializeComponent();
            symbolTable = new Dictionary<string, string>();
            InitializeDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("Key", "Key");
            dataGridView1.Columns.Add("Value", "Value");
        }

       

        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();

            foreach (var pair in symbolTable)
            {
                dataGridView1.Rows.Add(pair.Key, pair.Value);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)  //Add Button
        {
            string key = textBox1.Text;
            string value = textBox2.Text;

            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Key cannot be empty.");
            }
            else if (symbolTable.ContainsKey(key))
            {
                MessageBox.Show("Key already exists.");
            }
            else
            {
                symbolTable[key] = value;
                textBox1.Clear();
                textBox2.Clear();
                UpdateDataGridView();
            }
        }

        private void button2_Click_1(object sender, EventArgs e) //Search Button
        {
            string key = textBox1.Text;

            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Key cannot be empty.");
            }
            else if (symbolTable.ContainsKey(key))
            {
                string value = symbolTable[key];
                MessageBox.Show(string.Format("Value for key '{0}': {1}", key, value));

            }
            else
            {
                MessageBox.Show("Key not found.");
            }
        }
    }
}

