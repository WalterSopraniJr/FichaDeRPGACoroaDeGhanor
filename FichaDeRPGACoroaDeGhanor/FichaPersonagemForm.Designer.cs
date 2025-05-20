namespace FichaDeRPGACoroaDeGhanor
{
    partial class FichaPersonagemForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nome = new Label();
            txtBoxNome = new TextBox();
            Raca = new Label();
            Classe = new Label();
            comboBoxRaca = new ComboBox();
            comboBoxClasse = new ComboBox();
            Forca = new Label();
            Habilidade = new Label();
            PV = new Label();
            PM = new Label();
            numericUpDownForca = new NumericUpDown();
            numericUpDownHabilidade = new NumericUpDown();
            numericUpDownPV = new NumericUpDown();
            numericUpDownPM = new NumericUpDown();
            ListBoxPericiasPoderes = new ListBox();
            LabelPericiasPoderes = new Label();
            LabelEquipamento = new Label();
            listBoxEquipamento = new ListBox();
            numericUpDownDinheiro = new NumericUpDown();
            label2 = new Label();
            btSalvar = new Button();
            btVoltaMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownForca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHabilidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDinheiro).BeginInit();
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(12, 18);
            Nome.Name = "Nome";
            Nome.Size = new Size(43, 15);
            Nome.TabIndex = 0;
            Nome.Text = "Nome:";
            Nome.Click += label1_Click;
            // 
            // txtBoxNome
            // 
            txtBoxNome.Location = new Point(61, 12);
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.Size = new Size(410, 23);
            txtBoxNome.TabIndex = 1;
            // 
            // Raca
            // 
            Raca.AutoSize = true;
            Raca.Location = new Point(20, 59);
            Raca.Name = "Raca";
            Raca.Size = new Size(35, 15);
            Raca.TabIndex = 2;
            Raca.Text = "Raça:";
            Raca.Click += label2_Click;
            // 
            // Classe
            // 
            Classe.AutoSize = true;
            Classe.Location = new Point(256, 59);
            Classe.Name = "Classe";
            Classe.Size = new Size(43, 15);
            Classe.TabIndex = 4;
            Classe.Text = "Classe:";
            Classe.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBoxRaca
            // 
            comboBoxRaca.FormattingEnabled = true;
            comboBoxRaca.Location = new Point(61, 51);
            comboBoxRaca.Name = "comboBoxRaca";
            comboBoxRaca.Size = new Size(170, 23);
            comboBoxRaca.TabIndex = 6;
            comboBoxRaca.SelectedIndexChanged += comboBoxRaca_SelectedIndexChanged;
            // 
            // comboBoxClasse
            // 
            comboBoxClasse.FormattingEnabled = true;
            comboBoxClasse.Location = new Point(305, 51);
            comboBoxClasse.Name = "comboBoxClasse";
            comboBoxClasse.Size = new Size(166, 23);
            comboBoxClasse.TabIndex = 7;
            comboBoxClasse.SelectedIndexChanged += comboBoxClasse_SelectedIndexChanged;
            // 
            // Forca
            // 
            Forca.AutoSize = true;
            Forca.Location = new Point(61, 102);
            Forca.Name = "Forca";
            Forca.Size = new Size(36, 15);
            Forca.TabIndex = 8;
            Forca.Text = "Força";
            // 
            // Habilidade
            // 
            Habilidade.AutoSize = true;
            Habilidade.Location = new Point(158, 102);
            Habilidade.Name = "Habilidade";
            Habilidade.Size = new Size(64, 15);
            Habilidade.TabIndex = 9;
            Habilidade.Text = "Habilidade";
            // 
            // PV
            // 
            PV.AutoSize = true;
            PV.Location = new Point(297, 102);
            PV.Name = "PV";
            PV.Size = new Size(21, 15);
            PV.TabIndex = 10;
            PV.Text = "PV";
            PV.Click += label6_Click;
            // 
            // PM
            // 
            PM.AutoSize = true;
            PM.Location = new Point(405, 102);
            PM.Name = "PM";
            PM.Size = new Size(25, 15);
            PM.TabIndex = 11;
            PM.Text = "PM";
            // 
            // numericUpDownForca
            // 
            numericUpDownForca.Location = new Point(61, 134);
            numericUpDownForca.Name = "numericUpDownForca";
            numericUpDownForca.Size = new Size(47, 23);
            numericUpDownForca.TabIndex = 12;
            numericUpDownForca.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDownHabilidade
            // 
            numericUpDownHabilidade.Location = new Point(166, 134);
            numericUpDownHabilidade.Name = "numericUpDownHabilidade";
            numericUpDownHabilidade.Size = new Size(47, 23);
            numericUpDownHabilidade.TabIndex = 13;
            // 
            // numericUpDownPV
            // 
            numericUpDownPV.Location = new Point(285, 134);
            numericUpDownPV.Name = "numericUpDownPV";
            numericUpDownPV.Size = new Size(47, 23);
            numericUpDownPV.TabIndex = 14;
            // 
            // numericUpDownPM
            // 
            numericUpDownPM.Location = new Point(405, 134);
            numericUpDownPM.Name = "numericUpDownPM";
            numericUpDownPM.Size = new Size(47, 23);
            numericUpDownPM.TabIndex = 15;
            // 
            // ListBoxPericiasPoderes
            // 
            ListBoxPericiasPoderes.FormattingEnabled = true;
            ListBoxPericiasPoderes.ItemHeight = 15;
            ListBoxPericiasPoderes.Location = new Point(12, 224);
            ListBoxPericiasPoderes.Name = "ListBoxPericiasPoderes";
            ListBoxPericiasPoderes.Size = new Size(239, 214);
            ListBoxPericiasPoderes.TabIndex = 16;
            // 
            // LabelPericiasPoderes
            // 
            LabelPericiasPoderes.AutoSize = true;
            LabelPericiasPoderes.Location = new Point(74, 195);
            LabelPericiasPoderes.Name = "LabelPericiasPoderes";
            LabelPericiasPoderes.Size = new Size(101, 15);
            LabelPericiasPoderes.TabIndex = 17;
            LabelPericiasPoderes.Text = "Perícias e Poderes";
            // 
            // LabelEquipamento
            // 
            LabelEquipamento.AutoSize = true;
            LabelEquipamento.Location = new Point(309, 266);
            LabelEquipamento.Name = "LabelEquipamento";
            LabelEquipamento.Size = new Size(83, 15);
            LabelEquipamento.TabIndex = 19;
            LabelEquipamento.Text = "Equipamentos";
            // 
            // listBoxEquipamento
            // 
            listBoxEquipamento.FormattingEnabled = true;
            listBoxEquipamento.ItemHeight = 15;
            listBoxEquipamento.Location = new Point(257, 299);
            listBoxEquipamento.Name = "listBoxEquipamento";
            listBoxEquipamento.Size = new Size(214, 139);
            listBoxEquipamento.TabIndex = 18;
            // 
            // numericUpDownDinheiro
            // 
            numericUpDownDinheiro.Location = new Point(338, 224);
            numericUpDownDinheiro.Name = "numericUpDownDinheiro";
            numericUpDownDinheiro.Size = new Size(133, 23);
            numericUpDownDinheiro.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 228);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 20;
            label2.Text = "Dinheiro:";
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(506, 18);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 22;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // btVoltaMenu
            // 
            btVoltaMenu.Location = new Point(506, 59);
            btVoltaMenu.Name = "btVoltaMenu";
            btVoltaMenu.Size = new Size(75, 40);
            btVoltaMenu.TabIndex = 23;
            btVoltaMenu.Text = "Volta ao Menu";
            btVoltaMenu.UseVisualStyleBackColor = true;
            btVoltaMenu.Click += btVoltarMenu_Click;
            // 
            // FichaPersonagemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btVoltaMenu);
            Controls.Add(btSalvar);
            Controls.Add(numericUpDownDinheiro);
            Controls.Add(label2);
            Controls.Add(LabelEquipamento);
            Controls.Add(listBoxEquipamento);
            Controls.Add(LabelPericiasPoderes);
            Controls.Add(ListBoxPericiasPoderes);
            Controls.Add(numericUpDownPM);
            Controls.Add(numericUpDownPV);
            Controls.Add(numericUpDownHabilidade);
            Controls.Add(numericUpDownForca);
            Controls.Add(PM);
            Controls.Add(PV);
            Controls.Add(Habilidade);
            Controls.Add(Forca);
            Controls.Add(comboBoxClasse);
            Controls.Add(comboBoxRaca);
            Controls.Add(Classe);
            Controls.Add(Raca);
            Controls.Add(txtBoxNome);
            Controls.Add(Nome);
            Name = "FichaPersonagemForm";
            Text = "Form1";
            Load += FichaPersonagemForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownForca).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHabilidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPV).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPM).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDinheiro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nome;
        private TextBox txtBoxNome;
        private Label Raca;
        private Label Classe;
        private ComboBox comboBoxRaca;
        private ComboBox comboBoxClasse;
        private Label Forca;
        private Label Habilidade;
        private Label PV;
        private Label PM;
        private NumericUpDown numericUpDownForca;
        private NumericUpDown numericUpDownHabilidade;
        private NumericUpDown numericUpDownPV;
        private NumericUpDown numericUpDownPM;
        private ListBox ListBoxPericiasPoderes;
        private Label LabelPericiasPoderes;
        private Label LabelEquipamento;
        private ListBox listBoxEquipamento;
        private NumericUpDown numericUpDownDinheiro;
        private Label label2;
        private Button btSalvar;
        private Button btVoltaMenu;
    }
}
