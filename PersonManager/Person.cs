using System;

namespace PersonManager
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public void PrintPersonData()
        {
            Console.WriteLine($"Name of a person: {Name}");
            Console.WriteLine($"Age of a person:{Age}");
            Console.WriteLine($"Email of a person:{Email}");
            Console.WriteLine($"Phone of a PErson:{Phone}");
        }

        public void SetPersonData(string name, string email, int age, string phone)
        {
            Name = name;
            Age = age;
            Email = email;
            Phone = phone;
        }
    }
}
