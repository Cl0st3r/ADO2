using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppDatenbank1
{
    class ArtikelGruppe
    {
        private int artikelGruppeID;
        private string gruppenBezeichnung;

        public int ArtikelGruppeID
        {
            get
            {
                return artikelGruppeID;
            }

            set
            {
                artikelGruppeID = value;
            }
        }

        public string GruppenBezeichnung
        {
            get
            {
                return gruppenBezeichnung;
            }

            set
            {
                gruppenBezeichnung = value;
            }
        }

        public ArtikelGruppe(int artikelGruppeID, string gruppenBezeichnung)
        {
            this.artikelGruppeID = artikelGruppeID;
            this.gruppenBezeichnung = gruppenBezeichnung;
        }
    }
}
