using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public Person (string name, string surname, int age, double weight, double height)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Weight = weight;
            Height = height;
        }
        public override string ToString()
        {
            return $" Name: {Name} , Surname: {Surname} , Age:  {Age} , Weight:  {Weight} kg , Height: {Height} metres";
        }
    }
}
