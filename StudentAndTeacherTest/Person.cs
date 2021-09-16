using System;

namespace StudentAndTeacherTest
{
    public class Person
    {
        protected int Age { get; private set; }
        
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }

        public void SetAge(int age)
        {
            Age = age;
        }
    }
}