using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Person
    {
        public Guid ID { get; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }
        public Person(Guid id)
        {
            ID = id;
        }
        public Person(Guid id, string name)
        { 
            ID = id;
            Name = name;
        }
        public Person(string name , int age)
        {
            Name= name;
            Age = age;
        }


        public void GetName()
        {
            //TODO:change type to string and implement method.
        }
        public void SetName(string name)
        {
            //TODO:implemment method.
        }
    }
}
