using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logement
{
    class Maison : Logement
    {
        private int surfterrain;

        public Maison(int monid, string monadresse, int monnbpieces, int monloyer) : base(monid, monadresse, monnbpieces, monloyer)
        {

        }

        public new int afficher()
        {
            return (base.afficher() + this.surfterrain);
        }
    }
}
