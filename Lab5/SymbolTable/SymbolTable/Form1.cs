using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymbolTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Dictionary<int, string> symbolTable = new Dictionary<int, string>();
        private int HashFunction(string symbol)
        {
            // Simple hash function using the sum of ASCII values
            int hash = 0;
            foreach (char c in symbol)
            {
                hash += (int)c;
            }
            return hash;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string symbol = txtSymbol.Text;
            int hash = HashFunction(symbol);

            if (!symbolTable.ContainsKey(hash))
            {
                symbolTable[hash] = symbol;
                UpdateSymbolTableListBox();
                txtSymbol.Clear();
            }
            else
            {
                MessageBox.Show("Symbol already exists in the table.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string symbol = txtRetrieve.Text;
            int hash = HashFunction(symbol);

            if (symbolTable.ContainsKey(hash))
            {
                MessageBox.Show(string.Format("Symbol found: {0}", symbol));

            }
            else
            {
                MessageBox.Show("Symbol not found in the table.");
            }
        }
         private void UpdateSymbolTableListBox()
        {
            listBoxSymbolTable.Items.Clear();
            foreach (var entry in symbolTable)
            {
                listBoxSymbolTable.Items.Add(string.Format("Hash: {0}, Symbol: {1}", entry.Key, entry.Value));

            }
        }
    }
}
