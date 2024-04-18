using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;

            switch (Convert.ToInt32(cmbEscolha.SelectedItem))
            {
                case 1:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + ", você nasceu em Janeiro";
                    break;

                case 2:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + ", você nasceu em Favereiro";
                    break;

                case 3:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + ", você nasceu em Março";
                    break;

                case 4:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + ", você nasceu em Abril";
                    break;

                case 5:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + ", você nasceu em Maio";
                    break;

                case 6:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + ", você nasceu em Junho";
                    break;

                case 7:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + ", você nasceu em Julho";
                    break;

                case 8:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + ", você nasceu em Agosto";
                    break;

                case 9:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + ", você nasceu em Setembro";
                    break;

                case 10:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + "você nasceu em Outubro";
                    break;

                case 11:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + "você nasceu em Novembro";
                    break;

                case 12:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + "você nasceu em Dezembro";
                    break;

                default:
                    lblMensagem.Text = "Por favor escolha uma opção de números, mês não encontrado";
                    break;



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
