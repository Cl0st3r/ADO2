using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppDatenbank1
{
    class Verpackung
    {
        private int verpackungsID;

        public Verpackung(int verpackungsID)
        {
            this.VerpackungsID = verpackungsID;
        }

        public int VerpackungsID
        {
            get
            {
                return verpackungsID;
            }

            set
            {
                verpackungsID = value;
            }
        }
    }
}
