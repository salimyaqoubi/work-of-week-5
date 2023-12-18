using tus_day;

namespace myDbManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region classwork
            /*
             create Employee class and convert it into a table
            EmployeeId
            EmployeeName maxlength = 50,
            EmployeeAge range between 18 to 50 
            EmployeeSalary --> Currency
             */

            /*
             Department Class
            -------------------
            DepId ==> primaryKey and Auto Incremental
            Department name ==> maxlength 50 , minimum length 15
            dep flooor ==> rang 1 to 5
              
             */
            #endregion


            #region Adding to Database
            //AppDbManager _db = new AppDbManager();
            //int x = 5;
            //while (x-- > 0)
            //{
            //    Console.WriteLine("Enter your Name: ");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Enter your address: ");
            //    string address = Console.ReadLine();
            //    Console.WriteLine("Enter your age: ");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter your salary: "); // Fix the prompt
            //    decimal salary = decimal.Parse(Console.ReadLine()); // Fix the parsing
            //    Employee emp = new Employee
            //    {
            //        Name = name,
            //        Salary = salary,
            //        Age = age,
            //        Address = address,
            //    };

            //    _db.Employees.Add(emp);
            //    _db.SaveChanges();
            //}

            //Employee emp1 = new Employee // Fix the variable name to avoid conflict
            //{
            //    Name = "salim",
            //    Salary = 200000,
            //    Age = 23,
            //    Address = "seeb"
            //};
            //_db.Employees.Add(emp1);  // Fix the variable name to avoid conflict
            //_db.SaveChanges();

            #endregion

            #region using block
            //using (AppDbManager Context = new AppDbManager())
            //{
            //    Employee employee = new Employee() { Name = "salim", Address = "muscat", Age = 23, Salary = 55555 };
            //    Employee employee1 = new Employee() { Name = "akram", Address = "seeb", Age = 27, Salary = 40005 };
            //    //locally
            //    //Context.Employee.Add(employee);
            //    //Context.Em.Add(employee1);
            //    Context.Employees.Add(employee);
            //    Context.Employees.Add(employee1);
            //    //save changes happend locally
            //    Context.SaveChanges();
            //}
            #endregion

            #region using keyword only
            //using AppDbManager context = new AppDbManager();
            //Employee employee = new Employee() { Name = "salim", Address = "muscat", Age = 23, Salary = 55555 };
            //Employee employee1 = new Employee() { Name = "akram", Address = "seeb", Age = 27, Salary = 40005 };

            ////locally

            //context.Employees.Add(employee);
            //context.Employees.Add(employee1);

            ////save changes happend locally

            //context.SaveChanges();
            //Console.WriteLine(employee.EmployeeId);
            //Console.WriteLine(employee1.EmployeeId);


            #endregion


            #region adding to database using try finally
            try
            {
                AppDbManager context = new AppDbManager();
                Employee employee = new Employee() { Name = "salim", Address = "muscat", Age = 23, Salary = 55555 };
                Employee employee1 = new Employee() { Name = "akram", Address = "seeb", Age = 27, Salary = 40005 };

                //locally
                context.Employees.Add(employee);
                context.Employees.Add(employee1);
            }

            #endregion



            // entity frame work package
            // entity framework is a package so we need nuget package manager
            //var _Context = new ApplicationDbContext();
            //var emp = new Employee
            //{
            //    Name = "salim juma",
            //    salary = 5000
            //};
            //_Context.Employees.Add(emp);
            //_Context.SaveChanges();


        }
    }
}