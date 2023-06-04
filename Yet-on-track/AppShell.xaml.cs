using Yet_on_track.View;

namespace Yet_on_track;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(CreateRecordView), typeof(CreateRecordView));
    }
}
