namespace pryEjemploGit
{
    partial class frmFirma
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
            btnPintar = new Button();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // btnPintar
            // 
            btnPintar.Location = new Point(632, 12);
            btnPintar.Name = "btnPintar";
            btnPintar.Size = new Size(75, 23);
            btnPintar.TabIndex = 0;
            btnPintar.Text = "Pintar";
            btnPintar.UseVisualStyleBackColor = true;
            btnPintar.Click += btnPintar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(713, 12);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 1;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // frmFirma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBorrar);
            Controls.Add(btnPintar);
            Name = "frmFirma";
            Text = "frmFirma";
            MouseDown += frmFirma_MouseDown;
            MouseMove += frmFirma_MouseMove;
            MouseUp += frmFirma_MouseUp;
            ResumeLayout(false);
        }

        #endregion

        private Button btnPintar;
        private Button btnBorrar;
    }
}