using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLclasses
{
    public class Nurse : Staff      //Ärver attribut & metoder från "Staff"
    {
        public string Specialization {  get; set; }
        public string Department { get; set; }
    }
}
