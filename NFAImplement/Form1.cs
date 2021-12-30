using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace NFAImplement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void txtStateNames_Enter(object sender, EventArgs e)
        {
            if (txtStateNames.Text == "(example : q0,q1)")
            {
                txtStateNames.ForeColor = SystemColors.WindowText;
                txtStateNames.Clear();
            }
            
        }
        private void txtStateNames_Leave(object sender, EventArgs e)
        {
            if (txtStateNames.Text.Length == 0 )
            {
                txtStateNames.ForeColor = SystemColors.GrayText;
                txtStateNames.Text = "(example : q0,q1)";
            }
            
        }
        private void txtAlphabet_Enter(object sender, EventArgs e)
        {
            if (txtAlphabet.Text == "(example : 0,1)")
            {
                txtAlphabet.ForeColor = SystemColors.WindowText;
                txtAlphabet.Clear();
            }
            
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtAlphabet.Text.Length == 0)
            {
                txtAlphabet.ForeColor = SystemColors.GrayText;
                txtAlphabet.Text = "(example : 0,1)";
            }
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            txtStateNames.ForeColor = SystemColors.GrayText;
            txtStateNames.Text = "(example : q0,q1)";

            txtAlphabet.ForeColor = SystemColors.GrayText;
            txtAlphabet.Text = "(example : 0,1)";
            

        }

        private void txtFinalStates_Enter(object sender, EventArgs e)
        {
            if (txtStateNames.TextLength > 0 )
            {
                AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                string[] states = txtStateNames.Text.Trim().Split(',');
                foreach (var item in states)
                {
                    data.Add(item);
                }
                txtFinalStates.AutoCompleteCustomSource = data;
            }
        }

        
    }
}
