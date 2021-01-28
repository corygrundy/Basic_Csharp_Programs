using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPage244
{  
    //Begin part 1
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Begin part 2
        public abstract void SayName();
        
    }
}
