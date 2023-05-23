using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Domashna
{
    public abstract class player:Person
    {
        int number;
        int height;
        public int Height { get { return height; } set { value = height; } }
        public int Number { get { return number; } set { number = value; } }
        protected player(string name, int age, int number, int height) : base(name, age)
        {

        }
        }
}
