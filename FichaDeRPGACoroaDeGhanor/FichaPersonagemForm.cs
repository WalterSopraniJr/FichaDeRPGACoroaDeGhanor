using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;


namespace FichaDeRPGACoroaDeGhanor
{
    public partial class FichaPersonagemForm : Form
    {
        public FichaPersonagemForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Personagem personagem = new Personagem
            {
                Nome = txtBoxNome.Text,
                Raca = comboBoxRaca.Text,
                Classe = comboBoxClasse.Text,
                Forca = (int)numericUpDownForca.Value,
                Habilidade = (int)numericUpDownHabilidade.Value,
                PV = (int)numericUpDownPV.Value,
                PM = (int)numericUpDownPM.Value,
                Dinheiro = numericUpDownDinheiro.Value,
                Equipamento = string.Join(", ", listBoxEquipamento.Items.Cast<string>()),
                Pericias = ListBoxPericiasPoderes.Items.Cast<string>().ToList(),
                Poderes = new List<string>()
            };

            MessageBox.Show("Personagem salvo com sucesso!");
        }

        private void FichaPersonagemForm_Load(object sender, EventArgs e)
        {

        }

        private void SalvarPersonagem(Personagem personagem)
        {
            string caminho = "personagens.json";
            List<Personagem> personagens = new List<Personagem>();

            // Se o arquivo já existe, carregamos os personagens anteriores
            if (File.Exists(caminho))
            {
                string jsonExistente = File.ReadAllText(caminho);
                if (!string.IsNullOrWhiteSpace(jsonExistente))
                {
                    personagens = JsonSerializer.Deserialize<List<Personagem>>(jsonExistente);
                }
            }

            // Adiciona o novo personagem à lista
            personagens.Add(personagem);

            // Salva todos de volta no arquivo
            var opcoes = new JsonSerializerOptions { WriteIndented = true };
            string novoJson = JsonSerializer.Serialize(personagens, opcoes);
            File.WriteAllText(caminho, novoJson);
        }
    }
}
