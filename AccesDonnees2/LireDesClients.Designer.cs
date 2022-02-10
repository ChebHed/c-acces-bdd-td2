namespace AccesDonnees2
{
    partial class LireDesClients
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
            this.lblChoixCategorie = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblClientCat = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblChoixCategorie
            // 
            this.lblChoixCategorie.AutoSize = true;
            this.lblChoixCategorie.Location = new System.Drawing.Point(66, 69);
            this.lblChoixCategorie.Name = "lblChoixCategorie";
            this.lblChoixCategorie.Size = new System.Drawing.Size(86, 13);
            this.lblChoixCategorie.TabIndex = 0;
            this.lblChoixCategorie.Text = "Choix catégorie :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(184, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lblClientCat
            // 
            this.lblClientCat.AutoSize = true;
            this.lblClientCat.Location = new System.Drawing.Point(66, 135);
            this.lblClientCat.Name = "lblClientCat";
            this.lblClientCat.Size = new System.Drawing.Size(111, 13);
            this.lblClientCat.TabIndex = 2;
            this.lblClientCat.Text = "Clienst de la catégorie";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(69, 169);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 82);
            this.listBox1.TabIndex = 3;
            // 
            // LireDesClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblClientCat);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblChoixCategorie);
            this.Name = "LireDesClients";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoixCategorie;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblClientCat;
        private System.Windows.Forms.ListBox listBox1;
    }
}

