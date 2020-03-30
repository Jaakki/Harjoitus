using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus
{
    class Person
    {
        public string name;
        public int age;
        public int salary;
        public Person friend;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person()
        {

        }
    }
}
