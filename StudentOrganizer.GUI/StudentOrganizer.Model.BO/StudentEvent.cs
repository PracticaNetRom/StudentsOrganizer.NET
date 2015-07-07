using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOrganizer.Model.BO
{
    public class StudentEvent
    {
        public int ID { get; set; }
        public int Id_Student { get; set; }
        public int Id_Event { get; set; }
        public DateTime Period { get; set; }
        public string Departament { get; set; }
        public string TASK { get; set; }
        public string Remarks { get; set; }
    }
}
