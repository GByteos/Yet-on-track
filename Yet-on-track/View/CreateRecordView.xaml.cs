using Yet_on_track.ViewModel;

namespace Yet_on_track.View;

public partial class CreateRecordView : ContentPage
{
	public CreateRecordView(CreateRecordViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}