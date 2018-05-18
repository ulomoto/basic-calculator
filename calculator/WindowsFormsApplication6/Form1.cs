using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
       
        float num, ans;
        int count;
       

        public void close()
        {
            
            Close();
        }

        public void enable()
        {
            AnswerTxb.Enabled = true;
            ONbtn.Show();
            ONbtn.Hide();
            OneBtn.Enabled = true;
            TwoBtn.Enabled = true;
            ThreeBtn.Enabled = true;
            FourBtn.Enabled = true;
            FiveBtn.Enabled = true;
            SixBtn.Enabled = true;
            SevenBtn.Enabled = true;
            EightBtn.Enabled = true;
            NineBtn.Enabled = true;
            ZeroBtn.Enabled = true;
            AddBtn.Enabled = true;
            MinusBtn.Enabled = true;
            MultiplyBtn.Enabled = true;
            QuotientBtn.Enabled = true;
            ClearBtn.Enabled = true;
            DotBtn.Enabled = true;
            EqualBtn.Enabled = true;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            AnswerTxb.Text = AnswerTxb.Text + ".";
            AnswerTxb.ForeColor = Color.Red;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            AnswerTxb.Text = AnswerTxb.Text + 0;
            AnswerTxb.ForeColor = Color.Red;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AnswerTxb.Text = AnswerTxb.Text +1;
            AnswerTxb.ForeColor = Color.Red;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AnswerTxb.Text = AnswerTxb.Text + 2;
            AnswerTxb.ForeColor = Color.Red;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AnswerTxb.Text = AnswerTxb.Text + 3;
            AnswerTxb.ForeColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AnswerTxb.Text = AnswerTxb.Text + 4;
            AnswerTxb.ForeColor = Color.Red;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AnswerTxb.Text = AnswerTxb.Text + 5;
            AnswerTxb.ForeColor = Color.Red;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AnswerTxb.Text = AnswerTxb.Text + 6;
            AnswerTxb.ForeColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnswerTxb.Text = AnswerTxb.Text + 7;
            AnswerTxb.ForeColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AnswerTxb.Text = AnswerTxb.Text + 8;
            AnswerTxb.ForeColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AnswerTxb.Text = AnswerTxb.Text + 9;
            AnswerTxb.ForeColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            close(); 
        }
        private void ONbtn_Click(object sender, EventArgs e)
        {
            enable(); 

        }
        public void compute()
        {
            switch (count)
            {
                case 1:
                    ans = num + float.Parse(AnswerTxb.Text);
                    AnswerTxb.Text = ans.ToString();
                    break;
                 case 2:
                    ans = num - float.Parse(AnswerTxb.Text);
                    AnswerTxb.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(AnswerTxb.Text);
                    AnswerTxb.Text = ans.ToString();
                    break; 
                case 4:
                    ans = num / float.Parse(AnswerTxb.Text);
                    AnswerTxb.Text = ans.ToString();
                    break; 
                
                default:
               break;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            num = float.Parse(AnswerTxb.Text);
            AnswerTxb.Focus();
            AnswerTxb.Clear();
            count = 1;
            label1.Text = num.ToString() + "+";
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            num = float.Parse(AnswerTxb.Text);
            AnswerTxb.Focus();
            AnswerTxb.Clear();
            count = 2;
            label1.Text = num.ToString() + "-";
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            num = float.Parse(AnswerTxb.Text);
            AnswerTxb.Focus();
            AnswerTxb.Clear();
            count = 3;
            label1.Text = num.ToString() + "x";
        }

        private void QuotientBtn_Click(object sender, EventArgs e)
        {
            num = float.Parse(AnswerTxb.Text);
            AnswerTxb.Focus();
            AnswerTxb.Clear();
            count = 4;
            label1.Text = num.ToString() + "/";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            compute();
            label1.Text = "";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            AnswerTxb.Text = "";

        }
    }
}
