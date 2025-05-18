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
    public partial class JogoForm : Form
    {
        public JogoForm()
        {
            InitializeComponent();
        }

        private void dataGridViewJornada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void JogoForm_Load(object sender, EventArgs e)
        {
            dataGridViewJornada.Columns.Clear();

            var colReferencia = new DataGridViewTextBoxColumn();
            colReferencia.Name = "colReferencia";
            colReferencia.HeaderText = "Referência";
            colReferencia.ReadOnly = false;
            dataGridViewJornada.Columns.Add(colReferencia);

            dataGridViewJornada.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewJornada.ReadOnly = false;                  // Permite edição
            dataGridViewJornada.AllowUserToAddRows = true;         // Permite adicionar linhas
            dataGridViewJornada.AllowUserToDeleteRows = true;      // Permite apagar linhas
            dataGridViewJornada.SelectionMode = DataGridViewSelectionMode.CellSelect; // Seleciona células individuais
            dataGridViewJornada.MultiSelect = false;               // Só uma célula selecionada por vez
            dataGridViewJornada.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2; // Edita ao digitar ou pressionar F2
        }
    }
}
