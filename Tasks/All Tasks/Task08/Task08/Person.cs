using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    public class Person //პერსონის კლასის შექმნა სახელი და ასაკი
    {
        public int Age { get; set; }
        public string Name { get; set; }


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
