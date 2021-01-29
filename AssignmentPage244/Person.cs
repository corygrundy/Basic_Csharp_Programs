using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPage244
{  
    //Begin part 1 page 244
    public abstract class Person
    {
        //Another part of part 1 on page 252
        public List<Employee> Employees { get; set; }

        //Part of part 1 on page 244
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Begin part 2 page 244
        public abstract void SayName();

        
        
    }
}
