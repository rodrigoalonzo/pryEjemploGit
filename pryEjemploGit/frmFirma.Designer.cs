﻿namespace pryEjemploGit
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
            this.SuspendLayout();
            // 
            // frmFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmFirma";
            this.Text = "frmFirma";
            this.Load += new System.EventHandler(this.frmFirma_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmFirma_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmFirma_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}