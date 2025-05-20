namespace FichaDeRPGACoroaDeGhanor
{
    partial class JogoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewJornada = new DataGridView();
            lbJornada = new Label();
            btVoltarMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJornada).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewJornada
            // 
            dataGridViewJornada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJornada.Location = new Point(548, 61);
            dataGridViewJornada.Name = "dataGridViewJornada";
            dataGridViewJornada.Size = new Size(240, 377);
            dataGridViewJornada.TabIndex = 0;
            dataGridViewJornada.CellContentClick += dataGridViewJornada_CellContentClick;
            // 
            // lbJornada
            // 
            lbJornada.AutoSize = true;
            lbJornada.Location = new Point(646, 25);
            lbJornada.Name = "lbJornada";
            lbJornada.Size = new Size(48, 15);
            lbJornada.TabIndex = 1;
            lbJornada.Text = "Jornada";
            // 
            // btVoltarMenu
            // 
            btVoltarMenu.Location = new Point(465, 12);
            btVoltarMenu.Name = "btVoltarMenu";
            btVoltarMenu.Size = new Size(75, 41);
            btVoltarMenu.TabIndex = 2;
            btVoltarMenu.Text = "Voltar ao Menu";
            btVoltarMenu.UseVisualStyleBackColor = true;
            btVoltarMenu.Click += btVoltarMenu_Click;
            // 
            // JogoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btVoltarMenu);
            Controls.Add(lbJornada);
            Controls.Add(dataGridViewJornada);
            Name = "JogoForm";
            Text = "JogoForm";
            Load += JogoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewJornada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewJornada;
        private Label lbJornada;
        private Button btVoltarMenu;
    }
}