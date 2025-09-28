using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLclasses
{
    public class Doctor : Staff         //Ärver attribut & metoder från "Staff"
    {
        public string specialization { get; set; }        
    }
}
