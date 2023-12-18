using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyContext())
            {
                // Create and save new students
                Console.WriteLine("Adding new students");

                var student = new Student
                {
                    FirstMidName = "Alain",
                    LastName = "Bomer",
                    EnrollmentDate = DateTime.Today
                };

                context.Students.Add(student);

                var student1 = new Student
                {
                    FirstMidName = "Mark",
                    LastName = "Upston",
                    EnrollmentDate = DateTime.Today
                };

                context.Students.Add(student1);
                context.SaveChanges();

                // Display all Students from the database
                var students = (from s in context.Students
                                orderby s.FirstMidName
                                select s).ToList<Student>();

                Console.WriteLine("Retrieve all Students from the database:");

                foreach (var stdnt in students)
                {
                    string name = stdnt.FirstMidName + " " + stdnt.LastName;
                    Console.WriteLine("ID: {0}, Name: {1}", stdnt.ID, name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
