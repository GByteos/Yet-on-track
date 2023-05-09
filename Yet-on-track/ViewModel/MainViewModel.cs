using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using Yet_on_track.Model;

namespace Yet_on_track.ViewModel;

public partial class MainViewModel : BaseViewModel
{

    public MainViewModel()
    {
        Title = "Yet On Track - Time Tracker";

        // add some sample data for now
        for (int i = 1; i < 10; i++)
        {
            TimeRecords.Add(new TimeRecord
            {
                Id = i,
                Start = DateTime.Now.AddMinutes(-100 + i * 10),
                End = DateTime.Now.AddMinutes(-100 + i * 11)
            });
        }
    }

    public ObservableCollection<TimeRecord> TimeRecords { get; set; } = new();

    [RelayCommand]
    public void PushNotification()
    {
        Shell.Current.DisplayAlert("Button Clicked", "The button was clicked", "OK");
    }
}
