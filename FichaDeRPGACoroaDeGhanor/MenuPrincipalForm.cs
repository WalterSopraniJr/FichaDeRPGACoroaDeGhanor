using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaDeRPGACoroaDeGhanor
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void btCriarPersonagem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta o menu principal
            var criarForm = new FichaPersonagemForm();
            criarForm.FormClosed += (s, args) => this.Show(); // Mostra o menu quando fechar a janela
            criarForm.Show();
        }

        private void btJogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var jogarForm = new JogoForm();
            jogarForm.FormClosed += (s, args) => this.Show();
            jogarForm.Show();
        }

        private void btCemiterio_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cemiterioForm = new CemiterioForm();
            cemiterioForm.FormClosed += (s, args) => this.Show();
            cemiterioForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Não utilizado por enquanto
        }

        private void MenuPrincipalForm_Load(object sender, EventArgs e)
        {
            // Inicialização se necessário
        }
    }
}
