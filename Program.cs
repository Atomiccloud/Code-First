using System;

namespace Soph_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context.SchoolContext())
            {
                var stud = new Student() { StudentName = "Sophia is the cutest!" };
        
                context.Students.Add(stud);
                context.SaveChanges();     

                Console.Write("Saved Student to Database!");
                
            }
        }
    }
}
