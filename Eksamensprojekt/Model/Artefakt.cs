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

       
        public Artefakt(string navn)
        {
            Navn = navn;
        }
        public string Navn { get => _navn; set => _navn = value; }


    }
}
