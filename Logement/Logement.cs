using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logement
{
    class Logement
    {
       
        protected int id;
        protected String adresse;
        protected int nbpieces;
        protected int loyer;

        public Logement(int monid, String monadresse, int monnbpieces, int monloyer)
        {
            this.id = monid;
            this.adresse = monadresse;
            this.nbpieces = monnbpieces;
            this.loyer = monloyer;
        }

        public int afficher()
        {
            System.Diagnostics.Debug.WriteLine("Voici les infos du logement : " + id + " adresse " + adresse + " nbpieces " + nbpieces + " loyer " + loyer);
            return 0;
        }

        public int getId()
        {
            return id;
        }

        public int getLoyer()
        {
            return loyer;
        }

        public void setLoyer(int unloyer)
        {
            loyer = unloyer;
        }

        public void setLocataire(String uneadresse)
        {
            adresse = uneadresse;
        }

        public bool SetLocataire(Locataire personne)
        {
            //Du code à faire
            return true;
        }

    }
}
