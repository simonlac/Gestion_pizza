using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_pizza.Formulaire
{
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
        }
        private void Affichers(object sender, EventArgs e)
        {
            Ajoutpizza formEtudiant = new Ajoutpizza(); // Création d'une instance 
            formEtudiant.MdiParent = this; // définir le formulaire parent
            formEtudiant.Show(); // affichage du formulaire enfant
        }

        private void modification(object sender, EventArgs e)
        {
            Modifiercommande formEtudiant = new Modifiercommande(); // Création d'une instance 
            formEtudiant.MdiParent = this; // définir le formulaire parent
            formEtudiant.Show(); // affichage du formulaire enfant
        }

        private void pub(object sender, EventArgs e)
        {
            Affichercommande formEtudiant = new Affichercommande(); // Création d'une instance 
            formEtudiant.MdiParent = this; // définir le formulaire parent
            formEtudiant.Show(); // affichage du formulaire enfant
        }
    }
}
