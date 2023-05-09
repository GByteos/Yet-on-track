namespace Yet_on_track.Model;

public class TimeRecord
{
    public int Id { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public Activity Activity { get; set; }
}
