using System;

namespace CsharpProjc
{
    public class Person
    {
        public string Name;
        public void introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
        public Person Parse(string str)
        {
            var person = new Person();
            person.Name=str;
            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /** You Can Use This by declare static Person Parse()
            var person = Person.Parse("John");
            person.introduce("Mosh");
            **/
            var person = new Person();
            var p = person.Parse("Sutapa");
            p.introduce("Mosh");
        }
        }
    }