using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Person
    {
        public string Name { get; set; }    
        public int Age { get; set; }
        public string Gender { get; set; }

        public Person(string Name , int Age , string Gender)
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;

        }

        public void DisplayInfo() 
        
        {
            Console.WriteLine($"Name : {Name} | Age : {Age} | Gender {Gender}");
                   
        }
    }
}
