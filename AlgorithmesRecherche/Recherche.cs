using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmesRecherche
{
    internal class Recherche
    {
        public static void Test(IRecherche alogo, List<int> list, int cible, string nom)
        {
            int index = alogo.Rechercher(new List<int>(list), cible);//Copie de l'original de la liste
            if (index != -1)
            {
                Console.WriteLine($"{nom} : Élément trouvé à l'indice {1 + index}");
            }
            else
            {
                Console.WriteLine($"{nom} : Élément introuvable");
            }
        }
    }
}
