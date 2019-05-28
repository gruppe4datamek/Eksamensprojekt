using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamensprojekt
{
    
    public class Artefakt
    {
        private string _lydfil;
        private string _lydfilTekst;

        public Artefakt(string lydfil, string lydfilTekst)
        {
            _lydfil = lydfil;
            _lydfilTekst = lydfilTekst;
        }

        public string Lydfil
        {
            get { return _lydfil; }
            set { _lydfil = value; }
        }

        public string LydfilTekst
        {
            get { return _lydfilTekst; }
            set { _lydfilTekst = value; }
        }

    }
}
