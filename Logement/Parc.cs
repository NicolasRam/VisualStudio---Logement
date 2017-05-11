using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logement
{
    class Parc
    {
        List<Logement> liste = new List(logement);

        private String[] Collection;

        public String[] afficher()
        {
            foreach(Logement l in liste)
            {
                message = l.afficher();
            }

            return Collection;

        }

        public double AugmenterLoyer(double a)
        {

        }

        public void Rechercher(int id)
        {

            //locataire.getnom();
        }

    }
}
