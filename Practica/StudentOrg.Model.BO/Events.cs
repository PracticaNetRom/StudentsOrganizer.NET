using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOrg.Model.BO
{
    public class Events
    {
        public int ID { get; set; }
        public string Perioada { get; set; }
        public string Departament { get; set; }
        public string Task { get; set; }
        public string Remarks { get; set; }
        public int EventTypeID { get; set; }



    }
}