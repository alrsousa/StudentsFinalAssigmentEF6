using System;
using StudentsFinalAssigmentEF6;

namespace EF6Console
{

    public class Program
        {
            public static void Main(string[] args)
            {
            
                using (var ctx = new SchoolContext())
                {
                Console.Write("Enter StudentName1, then hit enter:    ");

                var stud = new Student() { StudentName = Console.ReadLine() };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
                Console.WriteLine("********************************************************************");
                Console.WriteLine("********************************************************************");
                Console.WriteLine("********************************************************************");
                Console.WriteLine("Student " + stud.StudentName +  " saved successfully!");
                Console.WriteLine("********************************************************************");
                Console.WriteLine("********************************************************************");
                Console.WriteLine("********************************************************************");

                Console.Write("Enter StudentName2, then hit enter:    ");
                stud = new Student() { StudentName = Console.ReadLine() };
                //   stud = new Student() { StudentName = "Ayrton Senna" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
                Console.WriteLine("********************************************************************");
                Console.WriteLine("********************************************************************");
                Console.WriteLine("********************************************************************");
                Console.WriteLine("Student " + stud.StudentName + " saved successfully!");
                Console.WriteLine("********************************************************************");
                Console.WriteLine("********************************************************************");
                Console.WriteLine("********************************************************************");

            }
        }
        }
}
