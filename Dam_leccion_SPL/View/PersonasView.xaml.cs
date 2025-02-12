using Dam_leccion_SPL.Model;
using Dam_leccion_SPL.Viewmodel;

namespace Dam_leccion_SPL.View;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();

		BindingContext = new PersonasViewModel();
	}
}