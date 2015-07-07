using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPractica
{
   public class StudentEvent
    {
        public int id { get; set; }
        public int id_student { get; set; }
        public int id_event { get; set; }
        public DateTime period { get; set; }
        public string department { get; set; }
        public string tasks { get; set; }
        public string remarks { get; set; }
    }
}
