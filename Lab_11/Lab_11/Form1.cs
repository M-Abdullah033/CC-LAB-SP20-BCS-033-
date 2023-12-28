﻿/*

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
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
    }
}

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Compile_Click(object sender, EventArgs e)
        {
            String Initial_State = "S0";
            String Final_State = "S3";
            var dict = new Dictionary<string, Dictionary<char,
           object>>();
            dict.Add("S0", new Dictionary<char, object>()
 {
 { 'a', "S1" },
 { 'b', "Se" },
 { 'c', "Se" }
 });
            dict.Add("S1", new Dictionary<char, object>()
 {

 { 'a', "Se" },
 { 'b', "S2" },
 { 'c', "Se" }
 });
            dict.Add("S2", new Dictionary<char, object>()
 {
 { 'a', "Se" },
 { 'b', "Se" },
 { 'c', "S3" }
 });
            dict.Add("S3", new Dictionary<char, object>()
 {
 { 'a', "Se" },
 { 'b', "Se" },
 { 'c', "S3" }
 });
            char check;
            String state;
            string strinput = Input.Text;
            char[] charinput = strinput.ToCharArray();
            check = charinput[0];
            state = Initial_State;
            int j = 0;
            while (check != '\\' && state != "Se")
            {
                state = dict[state][check] + "";
                j++;
                check = charinput[j];
            }
            if (state.Equals(Final_State))
            { Output.Text = "RESULT OKAY"; }
            else
            { Output.Text = "ERROR"; }

        }
    }
}
