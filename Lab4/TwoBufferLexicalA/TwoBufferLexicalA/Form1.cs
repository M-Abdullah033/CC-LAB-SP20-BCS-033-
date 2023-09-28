using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TwoBufferLexicalA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            string inputText = rtbInput.Text;
            List<string> tokens = Tokenize(inputText);

            rtbBuffer1.Clear();
            rtbBuffer2.Clear();

            foreach (string token in tokens)
            {
                if (IsOperator(token))
                {
                    rtbBuffer1.AppendText(token + Environment.NewLine);
                }
                else
                {
                    string tokenType = GetTokenType(token);
                    rtbBuffer2.AppendText(string.Format("<{0}, {1}>{2}", tokenType, token, Environment.NewLine));
                }
            }
        }
        private List<string> Tokenize(string inputText)
        {
            // Regular expression for tokenizing words, literals, symbols, and comments
            Regex tokenRegex = new Regex(@"(/\*[\s\S]*?\*/)|\b(while|for|if|else|int|float|new)\b|\b[a-zA-Z_][a-zA-Z0-9_]*\b|\b\d+(\.\d+)?\b|==|!=|>=|<=|[+\-*/%=(){}[\],;]|//[^\n]*");

            MatchCollection matches = tokenRegex.Matches(inputText);
            List<string> tokens = new List<string>();

            foreach (Match match in matches)
            {
                tokens.Add(match.Value);
            }

            return tokens;
        }

        private bool IsOperator(string token)
        {
            return Regex.IsMatch(token, @"^[+\-*/%=(){}[\],;]$");
        }

        private string GetTokenType(string token)
        {
            if (Regex.IsMatch(token, @"^(while|for|if|else|int|float|new)$"))
            {
                return "Keyword";
            }
            else if (Regex.IsMatch(token, @"^[a-zA-Z_][a-zA-Z0-9_]*$"))
            {
                return "Identifier";
            }
            else if (Regex.IsMatch(token, @"^\d+(\.\d+)?$"))
            {
                return "Literal/Constant";
            }
            else if (Regex.IsMatch(token, @"^(==|!=|>=|<=|[+\-*/%=(){}[\],;])$"))
            {
                return "Operator";
            }
            else if (Regex.IsMatch(token, @"^(/\*[\s\S]*?\*/|//[^\n]*)$"))
            {
                return "Comment";
            }
            else
            {
                return "Unknown";
            }
        }

    }
}