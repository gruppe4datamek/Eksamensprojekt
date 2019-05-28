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
            artefakts[2] = new Artefakt("Med montre videoer af dansestile, kan der ses de forskellige dansestile gennem tiderne.");
            artefakts[3] = new Artefakt("Ved dansemaskinen kan du selv prøve de forskellige dansestile, og  få respons på hvor godt du danser.");
            artefakts[4] = new Artefakt("I de forskellige montre er der artefakter fra før i tiden som har relevans til de forskellige subkulturer.");
            artefakts[5] = new Artefakt("På væggen er der vist forskellige genre og bands fra et bestemt tidsperiode, hvor du selv kan koble dig på med USB stik til hovedtelefoner der er til stede, og høre sangene fra de forskellige genre.");
            artefakts[6] = new Artefakt("Bag ved glasmontrene er der forskellige artefakter, som fans har enten lavet selv for at vise deres hengivenhed til stjernerne eller har samlet ved specielle begivenheder. ");
            artefakts[7] = new Artefakt("Her kan du se hvor højt du kan råbe ind i maskinen og få det sammenlignet med fans lydniveau ved forskellige koncerter. ");
            artefakts[8] = new Artefakt("I dette tema fortæller museet historien om de unges dagligdag, drømme og kærlighed i fokus – med musikken som omdrejningspunkt.");
            artefakts[9] = new Artefakt("I de forskellige montre kan der ses de forskellige artefakter, som sangerne havde på. Her ses det tøj og udstyr de brugte under deres optræden.");

       }

        public Artefakt[] Artefacts
        {
            get { return artefakts; }
        }


   }
}
