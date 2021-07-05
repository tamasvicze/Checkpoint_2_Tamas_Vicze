using System;

namespace Checkpoint_2_Tamas_Vicze
{
    public class Employee : Person
    {
        private string _hireDate;
        public string HireDate
        {
            get => _hireDate;
            set => _hireDate = value;
        }

        public Employee(string hireDate, string name = null, int age = 0) : base(name,age)
        {
            _hireDate = hireDate;
        }

         public static void Describe()
        {
            Console.WriteLine("This is a description of the Employee class:\n\nThe Employee class has a private field called _hireDate,\na public property called HireDate,\nand a public constructor called Employee.\nIn the constructor, the Employee class inherits the fields called name and age from the Person class.\n\nThe point of inheritance is that an Employee is also a Person,\nso I don't have to declare the name and age fields twice.");
        }
    }
}