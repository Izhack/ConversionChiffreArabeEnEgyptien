namespace ConversionChiffreArabeEnEgyptien
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.Resultat = new System.Windows.Forms.Label();
            this.tbResultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(102, 40);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(226, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(388, 33);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // Resultat
            // 
            this.Resultat.AutoSize = true;
            this.Resultat.Location = new System.Drawing.Point(32, 108);
            this.Resultat.Name = "Resultat";
            this.Resultat.Size = new System.Drawing.Size(46, 13);
            this.Resultat.TabIndex = 3;
            this.Resultat.Text = "Resultat";
            // 
            // tbResultat
            // 
            this.tbResultat.Location = new System.Drawing.Point(102, 105);
            this.tbResultat.Multiline = true;
            this.tbResultat.Name = "tbResultat";
            this.tbResultat.Size = new System.Drawing.Size(230, 250);
            this.tbResultat.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 367);
            this.Controls.Add(this.tbResultat);
            this.Controls.Add(this.Resultat);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label Resultat;
        private System.Windows.Forms.TextBox tbResultat;
    }
}

