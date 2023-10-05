using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavaLang
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> productionRules = new Dictionary<string, List<string>>();
        private Dictionary<string, HashSet<string>> firstSets = new Dictionary<string, HashSet<string>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            firstSets.Clear();
            ResultRichTextBox.Clear();

            // Parse grammar and calculate First Sets
            ParseGrammar();
            CalculateFirstSets();

            // Display First Sets in the ResultRichTextBox
            foreach (var nonTerminal in firstSets.Keys)
            {
                var firstSet = string.Join(", ", firstSets[nonTerminal]);
                ResultRichTextBox.AppendText(string.Format("First({0}) = {{{1}}}\n", nonTerminal, firstSet));

            }
        }
         private void ParseGrammar()
        {
            productionRules.Clear();
            var rules = GrammarTextBox.Lines;

            foreach (var rule in rules)
            {
                var parts = rule.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    var nonTerminal = parts[0].Trim();
                    var productions = parts[1].Trim().Split('|').Select(p => p.Trim()).ToList();
                    productionRules[nonTerminal] = productions;
                }
            }
        }

        private void CalculateFirstSets()
        {
            foreach (var nonTerminal in productionRules.Keys)
            {
                CalculateFirstSet(nonTerminal);
            }
        }

        private void CalculateFirstSet(string nonTerminal)
        {
            if (!firstSets.ContainsKey(nonTerminal))
            {
                firstSets[nonTerminal] = new HashSet<string>();
            }

            foreach (var production in productionRules[nonTerminal])
            {
                var symbols = production.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (symbols.Length == 0)
                {
                    // Empty production
                    firstSets[nonTerminal].Add("");
                }
                else if (char.IsUpper(symbols[0][0]))
                {
                    // Non-terminal symbol
                    CalculateFirstSet(symbols[0]);
                    firstSets[nonTerminal].UnionWith(firstSets[symbols[0]]);
                }
                else
                {
                    // Terminal symbol
                    firstSets[nonTerminal].Add(symbols[0]);
                }
            }
        }
    }
}
