namespace FichaDeRPGACoroaDeGhanor
{
    partial class CemiterioForm
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
            btVoltarMenu = new Button();
            SuspendLayout();
            // 
            // btVoltarMenu
            // 
            btVoltarMenu.Location = new Point(605, 57);
            btVoltarMenu.Name = "btVoltarMenu";
            btVoltarMenu.Size = new Size(75, 48);
            btVoltarMenu.TabIndex = 0;
            btVoltarMenu.Text = "Voltar ao Menu";
            btVoltarMenu.UseVisualStyleBackColor = true;
            btVoltarMenu.Click += btVoltarMenu_Click;
            // 
            // CemiterioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btVoltarMenu);
            Name = "CemiterioForm";
            Text = "CemiterioForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btVoltarMenu;
    }
}