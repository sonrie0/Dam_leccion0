using Dam_leccion_SPL.Model;

namespace Dam_leccion_SPL
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        //Aqui se declara global, en este caso na propiedad del perona model 
        private PersonaModel personaModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Ejecutar();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        public void Ejecutar()
        {
            // PersonaModel personaModel = new PersonaModel();
            // personaModel.Nombre = "Holi"; 
            // txtNombre.Text= personaModel.Nombre;

            personaModel = new PersonaModel
            {
                Nombre = "Hola soy yoo",
                Apellido = "Perez",
                Edad= "19"


            };

            BindingContext = personaModel;

            //txtNombre.Text = personaModel.Nombre(); 
            
            //Binding personabinding = new Binding(); 

            //PersonaBinding.Sourse = personaModel;  // origen 
            //PersonaBinding.Path = "Nombre"; //RUta 
            //txtNombre.SetBindig(Entry.TexrProperty, personaBinding);//Destinofinal

        }


        private void btAceptar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Asistente del sistema", "SE HA GUARDADO EL REGISTRO EN LA BD", "Acepta");
        }
    }

}
