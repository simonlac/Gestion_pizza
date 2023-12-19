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
    /// Classe Pizza
    /// </summary>

    public class Pizza
    {
        //Attributs privés 
        private string pizzaID;
        private string typePizza;
        private int prixPizza;
        // Propriétés
        public string PizzaID
        {
            get { return this.pizzaID; }
            set { if (verifier_regex_ID(value) == true) this.pizzaID = value; }
        }
        public string TypePizza
        {
            get { return this.typePizza; }
            // Pour s'assurer que la pizza soit un des trois types
            set { if (value == "Neapolitan") if(value =="Chicago") if (value == "Greek") this.typePizza = value; }
        }

        public int PrixPizza
        {
            get { return this.prixPizza; }
            // Pour s'assurer que la pizza a une valeur
            set { if (value < 0) this.prixPizza = value; }
        }
        //Le constructeur 
        /// <summary>
        /// Instancie un objet de la classe Pizza
        /// </summary>
        /// <param name="p_pizzaID">identifiant de la pizza</param>
        /// <param name="p_typepizza">type de la pizza</param>
        /// <param name="p_prixpizza">prix de la pizza</param>
        public Pizza(string p_pizzaID = "123", string p_typepizza = "Chicago", int p_prixpizza = 5)
        {
            this.pizzaID = p_pizzaID;
            this.typePizza = p_typepizza;
            this.prixPizza = p_prixpizza;
        }
        /// <summary>
        /// Vérifie qu'une chaîne est conforme à une expression régulìère
        /// </summary>
        /// <param name="ID">La chaine à vérifier</param>
        /// <returns>true si la chaîne est conforme et false sinon</returns>
        public bool verifier_regex_ID(string ID)
        {
            Regex Reg = new Regex("^[0-9]{3}$");
            return Reg.IsMatch(ID);
        }
    }
}