using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Domashna
{
    public abstract class Person
    {
        string name;
        int age;
        public string Name { get { return name;  } set { value = name; } }
        public int Age { get { return age; } set { age = value; } }
        public Person(string name, int age )
        {
            Name = name;
            Age = age;
            
            
        }
    }
}
