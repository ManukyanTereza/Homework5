using System;

namespace Homework5
{

   public class Person
    {
        public int age;
        public string  gender;
        public string name;
        public bool ex_age(Person person)
        {
            if (person.age > 0 && person.age <= 100) return true;
            return false;
        }
        public Person(int age, string gender,string name)
        {
            this.age = age;
            this.gender = gender;
            this.name = name;
        }

        public virtual void print()
        {
            Console.WriteLine(name +" "+"is a person");
            Console.ReadLine();
        }
    };

          class Doctor : Person
        {
            public Doctor(int age, string gender,string name) : base(age, gender,name) { }
        
            public override void print()
            {
                Console.WriteLine( name+" " +" is a doctor");
                Console.ReadLine();
            }
        };
        class Singer : Person
        {
        public Singer(int age, string gender,string name) : base(age, gender,name) { }
        public override void print()
            {
                Console.WriteLine(name+" "+"is  a singer");
                Console.ReadLine();
            }
        };
         class Programmer : Person
        {
        public Programmer(int age, string gender,string name) : base(age, gender,name) { }
        public override void print()
            {
                Console.WriteLine(name+" "+"is a programmer");
                Console.ReadLine();
            }
        };
    }


