using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmesRecherche
{
    internal class RechercheLineaire:IRecherche
    {
        public int Rechercher(List<int> list, int cible)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == cible)
                {
                    return i;
                }
            }
            return -1;
        }
        

    }
}
