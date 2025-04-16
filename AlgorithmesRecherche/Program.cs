namespace AlgorithmesRecherche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> liste = new List<int> { 9, 3, 6, 1, 8 };
            int valeurRecherchee = 6;

            IRecherche Lieaire = new RechercheLineaire();
            Console.WriteLine("Liste : " + string.Join(",", liste));
            Console.WriteLine("Recherche de la valeur " + valeurRecherchee);
            Recherche.Test(Lieaire, liste, valeurRecherchee, "Recherche Lineaire");
            //Recherche.Test(Binaire, liste, valeurRecherchee, "Recherche Binaire");
            //Recherche.Test(Dictionnaire, liste, valeurRecherchee, "Recherche Dictionnaire");
        }
    }
}
