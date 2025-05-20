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

        private void comboBoxRaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarAtributos();
        }
        private void comboBoxClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarAtributos();
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

            SalvarPersonagem(personagem);

            MessageBox.Show("Personagem salvo com sucesso!");
        }

        private void FichaPersonagemForm_Load(object sender, EventArgs e)
        {
            // Raças
            comboBoxRaca.Items.AddRange(new string[] { "Humano", "Gigante", "Aberrante", "Anão" });

            // Classes
            comboBoxClasse.Items.AddRange(new string[] { "Bárbaro", "Bardo", "Caçador", "Druida", "Ladino", "Mago" });
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

        private void AtualizarAtributos()
        {
            // Primeiro, ajuste base pela raça selecionada
            switch (comboBoxRaca.SelectedItem?.ToString())
            {
                case "Humano":
                    numericUpDownForca.Value = 7;
                    numericUpDownHabilidade.Value = 7;
                    numericUpDownPV.Value = 10;
                    numericUpDownPM.Value = 10;
                    break;
                case "Gigante":
                    numericUpDownForca.Value = 9;
                    numericUpDownHabilidade.Value = 5;
                    numericUpDownPV.Value = 15;
                    numericUpDownPM.Value = 5;
                    break;
                case "Aberrante":
                    numericUpDownForca.Value = 7;
                    numericUpDownHabilidade.Value = 8;
                    numericUpDownPV.Value = 10;
                    numericUpDownPM.Value = 5;
                    break;
                case "Anão":
                    numericUpDownForca.Value = 8;
                    numericUpDownHabilidade.Value = 6;
                    numericUpDownPV.Value = 15;
                    numericUpDownPM.Value = 5;
                    break;
                default:
                    // Se nada selecionado, limpar
                    numericUpDownForca.Value = 0;
                    numericUpDownHabilidade.Value = 0;
                    numericUpDownPV.Value = 0;
                    numericUpDownPM.Value = 0;
                    break;
            }

            // Depois, ajuste os atributos de acordo com a classe
            switch (comboBoxClasse.SelectedItem?.ToString())
            {
                case "Bárbaro":
                    numericUpDownPV.Value += 5;
                    break;
                case "Bardo":
                    numericUpDownHabilidade.Value += 1;
                    break;
                case "Caçador":
                    numericUpDownForca.Value += 1;
                    break;
                case "Druida":
                    numericUpDownPM.Value += 5;
                    break;
                case "Ladino":
                    numericUpDownHabilidade.Value += 1;
                    break;
                case "Mago":
                    numericUpDownPM.Value += 5;
                    break;
            }
        }

        private void btVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha a tela atual e volta o Menu Principal
        }
    }
}
