using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Students;
namespace cs_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var group = new Group("ТА-71");
            var student = new Student("Adam", "Golota");
            group.addStudent(student);
            
            student.print();
            int year = student.studyYear();
            if (year == 0)
                Console.WriteLine("Not a student");
            else
                Console.WriteLine("Year: " + student.studyYear());
            Console.ReadKey();
        }
    }
}
