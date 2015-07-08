using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsOrganizerModel.BO
{
     public class Event

    {
        public int ID  { get; set; }
        public string Event_Type_ID { get; set; }

        public string Period { get; set; }
        public string Departament { get; set; }
        public string Tasks { get; set; }
        public string Remarks { get; set; }


        public System.Data.SqlDbType Name { get; set; }

        public string ID_Event { get; set; }
    }
}
