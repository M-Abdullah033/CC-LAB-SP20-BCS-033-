using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace CC_TERMINAL_005_LEXICAL_ANALYZER_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            List<Token> tokens = Analyze(input);

            // Display the tokens in the list box
            lstTokens.Items.Clear();
            foreach (Token token in tokens)
            {
                lstTokens.Items.Add(token);
            }

        }
        private List<Token> Analyze(string input)
        {
            List<Token> tokens = new List<Token>();

            // Define regular expressions for various token types
            var keywordRegex = new Regex(@"\b(if|else|while)\b");
            var identifierRegex = new Regex(@"\b[a-zA-Z_]\w*\b");
            var numberRegex = new Regex(@"\b\d+\b");
            var stringLiteralRegex = new Regex(@"""([^""\\]|\\.)*""");
            var operatorRegex = new Regex(@"[\+\-\*/=]");
            var punctuationRegex = new Regex(@"[{};,()]");
            var commentRegex = new Regex(@"\/\/.*|\/\*[\s\S]*?\*\/");
            var whitespaceRegex = new Regex(@"\s+");

            // Remove comments and whitespaces
            input = commentRegex.Replace(input, string.Empty);
            input = whitespaceRegex.Replace(input, " ");

            // Tokenize the input and keep track of positions
            var matches = keywordRegex.Matches(input);
            foreach (Match match in matches)
            {
                tokens.Add(new Token(match.Value, TokenType.Keyword, match.Index));
            }

            matches = identifierRegex.Matches(input);
            foreach (Match match in matches)
            {
                tokens.Add(new Token(match.Value, TokenType.Identifier, match.Index));
            }

            matches = numberRegex.Matches(input);
            foreach (Match match in matches)
            {
                tokens.Add(new Token(match.Value, TokenType.Number, match.Index));
            }

            matches = stringLiteralRegex.Matches(input);
            foreach (Match match in matches)
            {
                tokens.Add(new Token(match.Value, TokenType.StringLiteral, match.Index));
            }

            matches = operatorRegex.Matches(input);
            foreach (Match match in matches)
            {
                tokens.Add(new Token(match.Value, TokenType.Operator, match.Index));
            }

            matches = punctuationRegex.Matches(input);
            foreach (Match match in matches)
            {
                tokens.Add(new Token(match.Value, TokenType.Punctuation, match.Index));
            }

            // Sort tokens based on their positions
            tokens = tokens.OrderBy(t => t.Position).ToList();

            return tokens;
        }


    }
    public class Token
    {
        public string Lexeme { get; }
        public TokenType Type { get; }
        public int Position { get; }  // Added position

        public Token(string lexeme, TokenType type, int position)
        {
            Lexeme = lexeme;
            Type = type;
            Position = position;
        }

        public override string ToString()
        {
            return $"{Type}: {Lexeme}";
        }
    }

    public enum TokenType
    {
        Keyword,
        Identifier,
        Number,
        StringLiteral,
        Operator,
        Punctuation,
        Comment
    }
}