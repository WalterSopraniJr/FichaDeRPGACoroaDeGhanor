namespace FichaDeRPGACoroaDeGhanor
{
    partial class MenuPrincipalForm
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
            label1 = new Label();
            label2 = new Label();
            btCriarPersonagem = new Button();
            btJogar = new Button();
            btCemiterio = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 36);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "A Coroa de Ghanor";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 110);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Menu Principal";
            // 
            // btCriarPersonagem
            // 
            btCriarPersonagem.Location = new Point(281, 161);
            btCriarPersonagem.Name = "btCriarPersonagem";
            btCriarPersonagem.Size = new Size(208, 23);
            btCriarPersonagem.TabIndex = 2;
            btCriarPersonagem.Text = "Criar Personagem";
            btCriarPersonagem.UseVisualStyleBackColor = true;
            btCriarPersonagem.Click += btCriarPersonagem_Click;
            // 
            // btJogar
            // 
            btJogar.Location = new Point(281, 211);
            btJogar.Name = "btJogar";
            btJogar.Size = new Size(208, 23);
            btJogar.TabIndex = 3;
            btJogar.Text = "Jogar";
            btJogar.UseVisualStyleBackColor = true;
            btJogar.Click += btJogar_Click;
            // 
            // btCemiterio
            // 
            btCemiterio.Location = new Point(281, 264);
            btCemiterio.Name = "btCemiterio";
            btCemiterio.Size = new Size(208, 23);
            btCemiterio.TabIndex = 4;
            btCemiterio.Text = "Cemitério";
            btCemiterio.UseVisualStyleBackColor = true;
            btCemiterio.Click += btCemiterio_Click;
            // 
            // MenuPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btCemiterio);
            Controls.Add(btJogar);
            Controls.Add(btCriarPersonagem);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MenuPrincipalForm";
            Text = "MenuPrincipalForm";
            Load += MenuPrincipalForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btCriarPersonagem;
        private Button btJogar;
        private Button btCemiterio;
    }
}