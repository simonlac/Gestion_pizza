using System;
using Xunit;
//Simon Lacaille 2129107
// j'ai des problèmes avec le système alors j'ai fait le code pour qu'il resemble à se qu'il doit même s'il ne marche pas
namespace Gestiom_Pizza
{
    public class UnitTest1
    {
//void pour vérifier si les résultats sont vrais
        [Fact]
        public void tester_verifier_chercher_commande()
        {
            Commande comm = new Commande();
            bool resultat = chercher_commande();
            Assert.True(resultat);
        }
//Les données à tester
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