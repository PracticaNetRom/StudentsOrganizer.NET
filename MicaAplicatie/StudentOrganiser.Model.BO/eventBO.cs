using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOrganiser.Model.BO
{
    public class Event
    {
        public int ID { get; set; }
        public int EventTypeID {get; set;}
        public DateTime EventPeriod {get; set;}
        public string EventDept {get; set;}
        public string Task {get; set;}
        public string Remarks {get; set;}

    }
}
