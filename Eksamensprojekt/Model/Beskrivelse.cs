using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamensprojekt
{
    public class Beskrivelse
    {
        private int _artefaktId;
        private string _artefaktNavn;
        private string _artefaktBeskrivelse;

        public Beskrivelse(int id, string navn, string beskrivelse)
        {
            _artefaktId = id;
            _artefaktNavn = navn;
            _artefaktBeskrivelse = beskrivelse;
        }

        public int ArtefaktId
        {
            get { return _artefaktId; }
            set { _artefaktId = value; }
        }

        public string ArtefaktNavn
        {
            get { return _artefaktNavn; }
            set { _artefaktNavn = value; }
        }

        public string ArtefaktBeskrivelse
        {
            get { return _artefaktBeskrivelse; }
            set { _artefaktBeskrivelse = value; }
        }
    }
}
