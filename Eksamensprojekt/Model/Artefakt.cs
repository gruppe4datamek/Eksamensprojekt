using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamensprojekt
{
    
    public class Artefakt
    {
        private string _navn;
        private string _beskrivelse;

       
        public Artefakt(string navn, string beskrivelse)
        {
            Navn = _navn;
            beskrivelse = _beskrivelse;
        }
        public string Navn { get => _navn; set => _navn = value; }

        public string Beskrivelse
        {
            get => _beskrivelse;
            set => _beskrivelse = value;
        }

    }
}
