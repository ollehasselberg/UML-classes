using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLclasses
{
    public class Staff                  //Detta är superklassen som ska ärvas av två subklasser (doctor och nurse)
    {
        public int StaffID { get; set; } 
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

   
}
