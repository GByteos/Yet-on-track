using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Yet_on_track.ViewModel;

public partial class MainViewModel : BaseViewModel
{

    public MainViewModel()
    {
        Title = "Yet On Track - Time Tracker";
    }

    [RelayCommand]
    public void PushNotification()
    {
        Shell.Current.DisplayAlert("Button Clicked", "The button was clicked", "OK");
    }
}
