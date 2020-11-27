using System;

namespace CreateStruct
{
    struct Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public Person(string _firstName, string _lastName, int _age)
        {
            firstName = _firstName;  
            lastName = _lastName;
            age = _age;
        }
        public override string ToString()
        {
            return firstName + " " + lastName + ", age " + age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Alex", "Zayc", 19); 
            Console.WriteLine(p);
        }
    }
}
