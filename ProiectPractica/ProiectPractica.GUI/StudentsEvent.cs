using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPractica
{
   public class StudentsEvent
    {
        public int id { get; set; }
        public int idstudent { get; set; }
        public int idevent { get; set; }
        public DateTime period { get; set; }
        public string department { get; set; }
        public string tasks { get; set; }
        public string remarks { get; set; }
    }
}
