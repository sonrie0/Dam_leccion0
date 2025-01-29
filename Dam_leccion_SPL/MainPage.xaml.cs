namespace Dam_leccion_SPL
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public object TextNombre { get; private set; }

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
            TextNombre.Text = "Hola Soy yooo";
        }

        private void btAceptar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Asistente del sistema", "SE HA GUARDADO EL REGISTRO EN LA BD", "Acepta");
        }
    }

}
