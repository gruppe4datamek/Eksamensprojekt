using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamensprojekt
{
    
    public class Artefakt
    {
        private string _lydfilText;
        private string _lydfil;

        public Artefakt(string lydfilText, string lydfil)
        {
            _lydfilText = lydfilText;
            _lydfil = lydfil;
        }

        public string LydfilText
        {
            get { return _lydfilText; }
            set { _lydfilText = value; }
        }

        public string lydfil
        {
            get { return _lydfil; }
            set { _lydfil = value; }
        }

    }
}
