using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Eksamensprojekt.ViewModel
{
  public class ClassViewModel
  {
      private Artefaktarray _artefakts;

      public ClassViewModel()
      {
          _artefakts = new Artefaktarray();
      }

      public Artefakt[] Artefakt
        {
          get { return _artefakts.Artefacts; }
      }

      
    }
}
