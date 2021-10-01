using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonEntryForm
{
    class PersonClass
    {
        string name;
        float mass;
        public PersonClass(string n, float m)
        {
            name = n;
            mass = m;
        }
        public string Name
        {
            get { return name; }
        }
        public float Mass
        {
            get { return mass; }
        }
    }
}
