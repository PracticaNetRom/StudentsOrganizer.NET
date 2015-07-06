using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsOrganizerModel.BO
{
    class Student_Event

    {
        public int ID { get; set; }
        public int ID_Students { get; set; }
        public int ID_Event { get; set; }
        public DateTime Period {get; set;}
        public string Departament { get; set; }
        public string Task { get; set; }
        public string Remarks { get; set; }

    }
}
