using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class Jogo : Form
    {
        public Jogo()
        {
            InitializeComponent();
            bloquearBtn();
            cartela();
        }

        private void bloquearBtn()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
        }

        private void cartela()
        {
            List<int> cartela = new List<int>();
            for (int i=0; i<16; i++)
            {
                cartela.Add(i + 1);
            }

            button1.Text = Convert.ToString(cartela[0]);
            button2.Text = Convert.ToString(cartela[1]);
            button3.Text = Convert.ToString(cartela[2]);
            button4.Text = Convert.ToString(cartela[3]);
            button5.Text = Convert.ToString(cartela[4]);
            button6.Text = Convert.ToString(cartela[5]);
            button7.Text = Convert.ToString(cartela[6]);
            button8.Text = Convert.ToString(cartela[7]);
            button9.Text = Convert.ToString(cartela[8]);
            button10.Text = Convert.ToString(cartela[9]);
            button11.Text = Convert.ToString(cartela[10]);
            button12.Text = Convert.ToString(cartela[11]);
            button13.Text = Convert.ToString(cartela[12]);
            button14.Text = Convert.ToString(cartela[13]);
            button15.Text = Convert.ToString(cartela[14]);
            button16.Text = Convert.ToString(cartela[15]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Red;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Red;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Red;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.Red;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Red;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Red;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.Red;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.Red;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Red;
        }

        private void btn_bingo_Click(object sender, EventArgs e)
        {

        }
    }
}
