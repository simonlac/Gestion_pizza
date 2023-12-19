namespace Gestion_pizza.Formulaire
{
    partial class FormParent
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
            this.Menustripprin = new System.Windows.Forms.MenuStrip();
            this.afficherToutesLesCommandesAprèsUneDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUneCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterOuSupprimerUnePizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLaListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menustripprin.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menustripprin
            // 
            this.Menustripprin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menustripprin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherToutesLesCommandesAprèsUneDateToolStripMenuItem,
            this.modifierUneCommandeToolStripMenuItem,
            this.ajouterOuSupprimerUnePizzaToolStripMenuItem,
            this.afficherLaListeToolStripMenuItem});
            this.Menustripprin.Location = new System.Drawing.Point(0, 0);
            this.Menustripprin.Name = "Menustripprin";
            this.Menustripprin.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.Menustripprin.Size = new System.Drawing.Size(934, 24);
            this.Menustripprin.TabIndex = 1;
            this.Menustripprin.Text = "menuStrip1";
            // 
            // afficherToutesLesCommandesAprèsUneDateToolStripMenuItem
            // 
            this.afficherToutesLesCommandesAprèsUneDateToolStripMenuItem.Name = "afficherToutesLesCommandesAprèsUneDateToolStripMenuItem";
            this.afficherToutesLesCommandesAprèsUneDateToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // modifierUneCommandeToolStripMenuItem
            // 
            this.modifierUneCommandeToolStripMenuItem.Name = "modifierUneCommandeToolStripMenuItem";
            this.modifierUneCommandeToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.modifierUneCommandeToolStripMenuItem.Text = "Modifier une commande";
            this.modifierUneCommandeToolStripMenuItem.Click += new System.EventHandler(this.modification);
            // 
            // ajouterOuSupprimerUnePizzaToolStripMenuItem
            // 
            this.ajouterOuSupprimerUnePizzaToolStripMenuItem.Name = "ajouterOuSupprimerUnePizzaToolStripMenuItem";
            this.ajouterOuSupprimerUnePizzaToolStripMenuItem.Size = new System.Drawing.Size(184, 20);
            this.ajouterOuSupprimerUnePizzaToolStripMenuItem.Text = "Ajouter ou supprimer une pizza";
            this.ajouterOuSupprimerUnePizzaToolStripMenuItem.Click += new System.EventHandler(this.Affichers);
            // 
            // afficherLaListeToolStripMenuItem
            // 
            this.afficherLaListeToolStripMenuItem.Name = "afficherLaListeToolStripMenuItem";
            this.afficherLaListeToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.afficherLaListeToolStripMenuItem.Text = "Afficher la liste";
            this.afficherLaListeToolStripMenuItem.Click += new System.EventHandler(this.pub);
            // 
            // FormParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 504);
            this.Controls.Add(this.Menustripprin);
            this.IsMdiContainer = true;
            this.Name = "FormParent";
            this.Text = "Commande de pizza";
            this.Menustripprin.ResumeLayout(false);
            this.Menustripprin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menustripprin;
        private System.Windows.Forms.ToolStripMenuItem afficherToutesLesCommandesAprèsUneDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUneCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterOuSupprimerUnePizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLaListeToolStripMenuItem;
    }
}