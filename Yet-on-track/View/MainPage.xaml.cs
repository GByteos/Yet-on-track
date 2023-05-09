using Yet_on_track.ViewModel;

namespace Yet_on_track;

public partial class MainPage : ContentPage
{
	

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}

