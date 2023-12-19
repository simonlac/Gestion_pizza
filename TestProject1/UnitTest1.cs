using System;
using Xunit;
//Simon Lacaille 2129107
// j'ai des probl�mes avec le syst�me alors j'ai fait le code pour qu'il resemble � se qu'il doit m�me s'il ne marche pas
namespace Gestiom_Pizza
{
    public class UnitTest1
    {
//void pour v�rifier si les r�sultats sont vrais
        [Fact]
        public void tester_verifier_chercher_commande()
        {
            Commande comm = new Commande();
            bool resultat = chercher_commande();
            Assert.True(resultat);
        }
//Les donn�es � tester
        [Theory]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("-1", false)]
        [InlineData("-1234", false)]
        [InlineData("1234.8", false)]
        [InlineData("!?&*", false)]
        [InlineData("Emilye", false)]
    }

    internal class Commande
    {
        int quantite = 3;
    }
}