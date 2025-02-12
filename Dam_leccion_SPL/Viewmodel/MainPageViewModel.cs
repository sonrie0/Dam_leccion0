using Dam_leccion_SPL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dam_leccion_SPL.Viewmodel
{
    public class MainPageViewModel
    {
        public PersonasModel personasModel { get; set; }

        public MainPageViewModel()
        {
            Consultar(); 

        }



        public void Consultar()
        {
            

            personasModel = new PersonasModel()
            {
                Nombre = "Hola soy yoo",
                Apellido = "Perez",
                Edad = "19"


            };

            

        }





    }
}

