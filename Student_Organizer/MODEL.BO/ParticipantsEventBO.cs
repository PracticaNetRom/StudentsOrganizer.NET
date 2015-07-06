using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.BO
{
    class ParticipantsEventBO
    {
        public int ID { get; set; }
        public int ID_S  { get; set; }
        public int ID_E { get; set; }
        public DateTime Period  { get; set; }
        public string Department { get; set; }
        public string Task { get; set; }
    }
}
