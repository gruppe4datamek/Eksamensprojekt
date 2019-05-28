using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamensprojekt
{
    
    public class Artefakt
    {
        private string _lydfilTekst;

        public Artefakt(string lydfilTekst)
        {
            _lydfilTekst = lydfilTekst;
        }

        public string LydfilTekst
        {
            get { return _lydfilTekst; }
            set { _lydfilTekst = value; }
        }

    }
}
