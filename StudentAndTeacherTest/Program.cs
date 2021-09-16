using System;

namespace StudentAndTeacherTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Greet();
            
            var student = new Student();
            student.SetAge(21);
            student.Greet();
            student.ShowAge();
            student.Study();
            
            var teacher = new Professor();
            teacher.SetAge(33);
            teacher.Greet();
            teacher.Explain();
        }
    }
}