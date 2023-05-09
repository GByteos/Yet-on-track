using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yet_on_track.Model;

public class TimeRecordGroup : List<TimeRecord>
{
    public string Name { get; set; }

    public TimeRecordGroup(string name, List<TimeRecord> timeRecords) : base(timeRecords)
    {
        Name = name;
    }
}
