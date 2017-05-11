using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logement
{
    class Locataire
    {
        private List<Logement> logements;
        private String nom;
        private int revenuMens;

        public Locataire()
        {
            this.nom = nom;
            this.revenuMens = revenuMens;
            logements = new List<Logement>();

        }

        public List<Logement> Logements
        {
            get { return logements; }
        }

        public String getNom()
        {
            return nom;
        }

        public int getRevenu()
        {
            return revenuMens;
        }

        public void setRevenu(int monrevenu)
        {
            revenuMens = monrevenu;
        }

    }
}
