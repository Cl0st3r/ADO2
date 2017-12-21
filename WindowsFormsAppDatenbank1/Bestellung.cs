using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppDatenbank1
{
    class Bestellung
    {
        private string bestellNr;
        private string kundeOID;
        private string datum;

        public string BestellNr
        {
            get
            {
                return bestellNr;
            }

            set
            {
                bestellNr = value;
            }
        }

        public string KundeOID
        {
            get
            {
                return kundeOID;
            }

            set
            {
                kundeOID = value;
            }
        }

        public string Datum
        {
            get
            {
                return datum;
            }

            set
            {
                datum = value;
            }
        }

        public Bestellung(string bestellNr, string kundeOID, string datum)
        {
            this.bestellNr = bestellNr;
            this.datum = datum;
            this.kundeOID = kundeOID;
        }
    }
}
