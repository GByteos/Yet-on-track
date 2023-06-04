using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using Yet_on_track.Model;
using Yet_on_track.View;

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

        // adding sample group data
        TimeRecordsGrouped.Add(new TimeRecordGroup("Today", new List<TimeRecord>
        {
            new TimeRecord { Id = 1, Start = DateTime.Today, End = DateTime.Today },
            new TimeRecord { Id = 2, Start = DateTime.Today, End = DateTime.Today },
            new TimeRecord { Id = 3, Start = DateTime.Today, End = DateTime.Today }
        }));

        TimeRecordsGrouped.Add(new TimeRecordGroup("Yesterday", new List<TimeRecord>
        {
            new TimeRecord { Id = 1, Start = DateTime.Today.AddDays(-1), End = DateTime.Today.AddDays(-1) },
            new TimeRecord { Id = 2, Start = DateTime.Today.AddDays(-1), End = DateTime.Today.AddDays(-1) },
            new TimeRecord { Id = 3, Start = DateTime.Today.AddDays(-1), End = DateTime.Today.AddDays(-1) }
        }));
    }

    public ObservableCollection<TimeRecord> TimeRecords { get; set; } = new();

    public List<TimeRecordGroup> TimeRecordsGrouped { get; set; } = new();

    [RelayCommand]
    public void PushNotification()
    {
        Shell.Current.DisplayAlert("Button Clicked", "The button was clicked", "OK");
    }

    [RelayCommand]
    public async Task GoToAddTimeRecord()
    {
        await Shell.Current.GoToAsync($"{nameof(CreateRecordView)}");
    }
}
