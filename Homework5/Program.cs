using System;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person obj1 = new Person(13, "male", "Noy");
            obj1.print();
            Singer obj2 = new Singer(25, "female", "Jane");
            obj2.print();
            Programmer obj3 = new Programmer(18, "male", "Leo");
            obj3.print();
            Doctor obj4 = new Doctor(150, "male", "Edvard");
            try
            {
                ex_age(obj4);
            }
            catch
            {
                throw new InvalidAgeException("This person doesn't exist");
            }         
        }
        private static void ex_age(Doctor obj4)
        {
            throw new NotImplementedException();
        }
    }
}

