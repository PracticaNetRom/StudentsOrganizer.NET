using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOrganizer.Model.BO
{
    public class Event
    {
        public int ID { get; set; }
        public int EventTypes_ID { get; set; }
        public DateTime Period { get; set; }
        public string Departament { get; set; }
        public string Task { get; set; }
        public string Remarks { get; set; }
    }
}
