using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.NewFolder1
{
    public abstract class Person : Object
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
