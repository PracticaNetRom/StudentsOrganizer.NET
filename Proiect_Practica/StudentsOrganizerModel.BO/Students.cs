using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsOrganizerModel.BO
{
    public class Students
    {
        public int id { get; set; }
        public int ID_Student { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Gender { get; set; }
        public DateTime Birth_date { get; set; }
        public string Email { get; set; }
        public string Phone_Numbers { get; set; }
        public string Faculty { get; set; }
        public string Faculty_start_year { get; set; }


    }
}
