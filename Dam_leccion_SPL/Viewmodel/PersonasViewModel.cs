using Dam_leccion_SPL.Model;
using FoundationStandard.ObjectHydrator;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dam_leccion_SPL.Viewmodel
{
    public class PersonasViewModel
    {
        // De manera generica <> 
        public ObservableCollection<PersonasModel>Personas { get; set; }
        public PersonasViewModel() 
        {
            Consultar(); 
            
        }

        public void Consultar()
        {
            var listado = new Hydrator<PersonasModel>().WithFirstName(n=>n.Nombre);
            Personas = new ObservableCollection<PersonasModel>(listado.GetList(28));
        }
    }
}
