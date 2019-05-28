using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamensprojekt
{
   public class Artefaktarray
   {
       Artefakt[] artefakts ;

        public Artefaktarray()
       {
           artefakts = new Artefakt[10];

            artefakts[0] = new Artefakt("Lysshow maskinen fremstiller forskellige former for lysshow. Denne maskine er interaktiv, så man kan prøve at lege med lyseffekter, som er til en koncert.");
            artefakts[1] = new Artefakt("Det gamle kamera blev brugt til at lave lysshow i fysisk form før det blev digitaliseret. Farverne bliver dannet ved opvarmning af diverse olier.");


       }

        public Artefakt[] Artefacts
        {
            get { return artefakts; }
        }


   }
}
