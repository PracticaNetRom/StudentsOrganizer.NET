﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.BO
{
    public class StudentsBO
    {
        public int ID {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Gender {get; set;}
        public DateTime BirthDate {get; set;}
        public int PhoneNumber {get; set;}
        public string Faculty {get; set;}
        public DateTime FacultyStartYear { get; set; }
    }

    
}
