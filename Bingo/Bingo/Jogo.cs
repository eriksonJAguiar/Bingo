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

        private List<int> cartelaList;

        public Jogo()
        {
            InitializeComponent();
            bloquearBtn();
            cartela();
            bloquearBotaoBingo();
        }

        private void bloquearBotaoBingo()
        {
            btn_bingo.Enabled = false;
        }

        private void verificarBingo()
        {
            if (cartelaList.Count == 0)
            {
                btn_bingo.Enabled = true;
            }
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
            cartelaList = new List<int>();
            for (int i=0; i<16; i++)
            {
                cartelaList.Add(i + 1);
            }

            button1.Text = Convert.ToString(cartelaList[0]);
            button2.Text = Convert.ToString(cartelaList[1]);
            button3.Text = Convert.ToString(cartelaList[2]);
            button4.Text = Convert.ToString(cartelaList[3]);
            button5.Text = Convert.ToString(cartelaList[4]);
            button6.Text = Convert.ToString(cartelaList[5]);
            button7.Text = Convert.ToString(cartelaList[6]);
            button8.Text = Convert.ToString(cartelaList[7]);
            button9.Text = Convert.ToString(cartelaList[8]);
            button10.Text = Convert.ToString(cartelaList[9]);
            button11.Text = Convert.ToString(cartelaList[10]);
            button12.Text = Convert.ToString(cartelaList[11]);
            button13.Text = Convert.ToString(cartelaList[12]);
            button14.Text = Convert.ToString(cartelaList[13]);
            button15.Text = Convert.ToString(cartelaList[14]);
            button16.Text = Convert.ToString(cartelaList[15]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.Enabled = false;
            cartelaList.Remove(Int32.Parse(button1.Text));
            verificarBingo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            button2.Enabled = false;
            cartelaList.Remove(Int32.Parse(button2.Text));
            verificarBingo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            button3.Enabled = false;
            cartelaList.Remove(Int32.Parse(button3.Text));
            verificarBingo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            button4.Enabled = false;
            cartelaList.Remove(Int32.Parse(button4.Text));
            verificarBingo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            button5.Enabled = false;
            cartelaList.Remove(Int32.Parse(button5.Text));
            verificarBingo();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Red;
            button6.Enabled = false;
            cartelaList.Remove(Int32.Parse(button6.Text));
            verificarBingo();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Red;
            button7.Enabled = false;
            cartelaList.Remove(Int32.Parse(button7.Text));
            verificarBingo();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Red;
            button8.Enabled = false;
            cartelaList.Remove(Int32.Parse(button8.Text));
            verificarBingo();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Red;
            button9.Enabled = false;
            cartelaList.Remove(Int32.Parse(button9.Text));
            verificarBingo();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Red;
            button10.Enabled = false;
            cartelaList.Remove(Int32.Parse(button10.Text));
            verificarBingo();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.Red;
            button11.Enabled = false;
            cartelaList.Remove(Int32.Parse(button11.Text));
            verificarBingo();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Red;
            button12.Enabled = false;
            cartelaList.Remove(Int32.Parse(button12.Text));
            verificarBingo();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Red;
            button13.Enabled = false;
            cartelaList.Remove(Int32.Parse(button13.Text));
            verificarBingo();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.Red;
            button14.Enabled = false;
            cartelaList.Remove(Int32.Parse(button14.Text));
            verificarBingo();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.Red;
            button15.Enabled = false;
            cartelaList.Remove(Int32.Parse(button15.Text));
            verificarBingo();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Red;
            button16.Enabled = false;
            cartelaList.Remove(Int32.Parse(button16.Text));
            verificarBingo();

        }

        private void btn_bingo_Click(object sender, EventArgs e)
        {

        }

        private void addcionarNumero(int num)
        {
            listBox_num_sort.Items.Add(num);
            habilitarBtn(Convert.ToString(num));
        }

        private void gerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            addcionarNumero(random.Next(1, 17));
        }

        private void habilitarBtn(String num)
        {
            if(button1.Text == num)
            {
                button1.Enabled = true;
                button1.BackColor = Color.ForestGreen;
            }
            else if (button2.Text == num)
            {
                button2.Enabled = true;
                button2.BackColor = Color.ForestGreen;
            }
            else if (button3.Text == num)
            {
                button3.Enabled = true;
                button3.BackColor = Color.ForestGreen;
            }
            else if (button4.Text == num)
            {
                button4.Enabled = true;
                button4.BackColor = Color.ForestGreen;
            }
            else if (button5.Text == num)
            {
                button5.Enabled = true;
                button5.BackColor = Color.ForestGreen;
            }
            else if (button6.Text == num)
            {
                button6.Enabled = true;
                button6.BackColor = Color.ForestGreen;
            }
            else if (button7.Text == num)
            {
                button7.Enabled = true;
                button7.BackColor = Color.ForestGreen;
            }
            else if (button8.Text == num)
            {
                button8.Enabled = true;
                button8.BackColor = Color.ForestGreen;
            }
            else if (button9.Text == num)
            {
                button9.Enabled = true;
                button9.BackColor = Color.ForestGreen;
            }
            else if (button10.Text == num)
            {
                button10.Enabled = true;
                button10.BackColor = Color.ForestGreen;
            }
            else if (button11.Text == num)
            {
                button11.Enabled = true;
                button11.BackColor = Color.ForestGreen;
            }
            else if (button12.Text == num)
            {
                button12.Enabled = true;
                button12.BackColor = Color.ForestGreen;
            }
            else if (button13.Text == num)
            {
                button13.Enabled = true;
                button13.BackColor = Color.ForestGreen;
            }
            else if (button14.Text == num)
            {
                button14.Enabled = true;
                button14.BackColor = Color.ForestGreen;
            }
            else if (button15.Text == num)
            {
                button15.Enabled = true;
                button15.BackColor = Color.ForestGreen;
            }
            else if (button16.Text == num)
            {
                button16.Enabled = true;
                button16.BackColor = Color.ForestGreen;
            }
        }

        
    }
}
