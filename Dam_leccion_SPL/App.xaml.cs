using Dam_leccion_SPL.Model;
using Dam_leccion_SPL.Viewmodel;

namespace Dam_leccion_SPL
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new AppShell();

            MainPage= new PersonasView();
        }
    }
}
