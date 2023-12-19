using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
// Simon Lacaille 2129107

namespace Gestion_pizza
{
    /// <summary>
    /// utilise la classe Pizza pour payer une pizza 
    /// </summary>
    public class Commande : Pizza
    {
        //Attributs privés
        private string commandeID;
        private DateTime dateCommande;
        private int quantite;
        private Pizza unepizza;
        // Propriétés
        public string CommandeID
        {
            get { return this.commandeID; }
            set { if (verifier_regex_commande_ID(value) == true) this.commandeID = value; }
        }
        public DateTime DateCommande
        {
            get { return this.dateCommande; }
            // Pour s'assurer que la commande ne soit pas crée avant la date de création
            set { if (value >= DateTime.Now) this.dateCommande = value; }
        }
        public int Quantite
        {
            get { return this.quantite; }
            // Pour s'assurer qu'il y aille au moins une pizza sur la commande
            set { if (value < 0) this.quantite = value; }
        }
        public Pizza Unepizza
        {
            get { return this.unepizza; }
            // Pour s'assurer qu'il y aille une pizza dessus la commande avec un identifiant
            set { if (PizzaID != "") this.unepizza = value; }
        }
        // Constructeur avec paramètres et valeurs par défaut
        /// <summary>
        /// Intancie un objet de la classe Commande.
        /// </summary>
        /// <param name="p_pizzaID">identifiant de la pizza</param>
        /// <param name="p_typepizza">type de la pizza</param>
        /// <param name="p_prixpizza">prix de la pizza</param>
        /// <param name="p_commandeID">l'identifiant de la commande</param>
        /// <param name="p_dateCommande">le temps que la commande a été crée</param>
        /// <param name="p_Quantite">la quantite de pizza crée</param>
        public Commande(string p_pizzaID = "111", string p_typepizza = "greek", int p_prixpizza = 10, string p_commandeID = "a12345", DateTime p_dateCommande = default(DateTime), int p_quantite = 1) : base(p_pizzaID, p_typepizza, p_prixpizza)
        {
            this.commandeID = p_commandeID;
            this.dateCommande = p_dateCommande;
            this.quantite = p_quantite;
        }
        /// <summary>
        /// Vérifie qu'une chaîne est conforme à une expression régulìère
        /// </summary>
        /// <param name="commande">La chaine à vérifier</param>
        /// <returns>true si la chaîne est conforme et false sinon</returns>
        public bool verifier_regex_commande_ID(string commande)
        {
            Regex Reg = new Regex("^[A-Za-z]{1}[0-9]{5}$");
            return Reg.IsMatch(commande);
        }
        /// <summary>
        /// Calcule et retourne le prix pour la commande
        /// </summary>
        /// <returns>Le prix de la commande</returns>
        //public int calculer_prix_commande()
        //{
            //Calculer le prix de la commande
            //int prixcommande = (Pizza prixPizza * 0.14975);
            //int prixtotal = PrixPizza + prixcommande;
            //return prixtotal;
        
    }
}