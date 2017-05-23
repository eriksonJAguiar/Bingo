using Bingo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class Bingo : Form
    {
        public Bingo()
        {
            InitializeComponent();
        }

        private void btn_entraJogo_Click(object sender, EventArgs e)
        {
            if (verificaCampo())
            {
                Conf_Player confPlayer = new Conf_Player();
                confPlayer.ip = textBox_ip.Text;
                confPlayer.porta = Int32.Parse(textBox_porta.Text);
                confPlayer.nome = textBox_jogador.Text;
                conectarJogo(confPlayer);
            }
            
        }

        private bool verificaCampo()
        {
            if (textBox_ip.Text == String.Empty)
            {
                MessageBox.Show("Campo ip está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }else if (textBox_porta.Text == String.Empty)
            {
                MessageBox.Show("Campo porta está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }else if (textBox_jogador.Text == String.Empty)
            {
                MessageBox.Show("Campo nome do jogador está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void conectarJogo(Conf_Player conf)
        {

            //Criar método de conectar

            if (true)
            {
                Jogo jogo = new Jogo();
                jogo.Show();
            }
            else
            {
                MessageBox.Show("Erro ao entra no jogo.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
