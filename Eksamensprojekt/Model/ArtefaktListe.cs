using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamensprojekt
{
   public class ArtefaktListe
   {
       private List<Artefakt> _artefakts;

       public ArtefaktListe()
       {
           _artefakts = new List<Artefakt>();
           _artefakts.Add(new Artefakt());
       }


   }
}
