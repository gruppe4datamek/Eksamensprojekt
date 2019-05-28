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
           _artefakts.Add(new Artefakt("Lad der være lys.m4a", "Velkommen til rummet Lad Der Være Lys. Herinde er der informationer om lysshow igennem tiderne i forhold til musikken.."));
       }


   }
}
