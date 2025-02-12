using Dam_leccion_SPL.Model;
using Dam_leccion_SPL.Viewmodel;

namespace Dam_leccion_SPL
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        
        MainPageViewModel mainPageViewModel = new MainPageViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;
            
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
        


        private void btAceptar_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Asistente del sistema", "SE HA GUARDADO EL REGISTRO EN LA BD", "Acepta");
            //personasModel.Nombre = "Sara";
            //personasModel.Apellido = "Desain xd";
            //personasModel.Edad = "19";


        }
    }

}
