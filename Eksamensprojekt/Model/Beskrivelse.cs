using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamensprojekt
{
    public class Beskrivelse
    {
        private int _beskrivelseId;
        private string _beskrivelseNavn;
        private string _beskrivelsesText;

        public Beskrivelse(int id, string navn, string beskrivelse)
        {
            _beskrivelseId = id;
            _beskrivelseNavn = navn;
            _beskrivelsesText = beskrivelse;
        }

        public int BeskrivelseId
        {
            get { return _beskrivelseId; }
            set { _beskrivelseId = value; }
        }

        public string BeskrivelseNavn
        {
            get { return _beskrivelseNavn; }
            set { _beskrivelseNavn = value; }
        }

        public string BeskrivelsesText
        {
            get { return _beskrivelsesText; }
            set { _beskrivelsesText = value; }
        }
    }
}
