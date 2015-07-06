using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOrganiser.Model.BO
{
    public class EventParticipants
    {
        public int ID { get; set; }
        public int StudentID {get; set;}
        public int EventID {get; set;}
        public string EventPeriod {get; set;}
        public string EventDept {get; set;}
        public string AssignedTask {get; set;}
        public string ParticipantRemarks {get; set;}

    }
}
