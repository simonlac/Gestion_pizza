using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Simon Lacaille 2129107

namespace Gestion_pizza
{
    public static class Commande_Outils
    {
        //Attribut privé
        private static List<Commande> list_commandes;
        //Propriété
        public static List<Commande> List_commandes
        {
            get { return list_commandes; }
            set { list_commandes = value; }
        }
        //Constructeur
        /// <summary>
        /// Constructeur statique. Est appelé une seule fois.
        /// S'execute avant le référencement de la
        /// liste statique listcommande afin de l'initialiser. 
        /// </summary>
        static Commande_Outils()
        {
            List_commandes = new List<Commande>();
        }
        public static class Pizza_Outils
        {
            //Attribut privé
            private static List<Pizza> list_pizza;
            //Propriété
            public static List<Pizza> List_pizza
            {
                get { return list_pizza; }
                set { list_pizza = value; }
            }
            //Constructeur
            /// <summary>
            /// Constructeur statique. Est appelé une seule fois.
            /// S'execute avant le référencement de la
            /// liste statique listcommande afin de l'initialiser. 
            /// </summary>
            static Pizza_Outils()
            {
                List_pizza = new List<Pizza>();
            }
            //Méthodes
            /// <summary>
            /// Calcule et retourne la liste des commandes dont la quantite est supérieur à p_quantite
            /// </summary>
            /// <returns>Nombre d'étudiants dans la liste</returns>
            public static int chercher_commandes()
            {
                int count = 0;
                foreach (Commande et in list_commandes)
                    if (et.Quantite > 2) count++;
                return count;

            }
        }

    }
}
