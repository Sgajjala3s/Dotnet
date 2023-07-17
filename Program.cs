using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program  
    {
        static void Main(string[] args) //Entry Point for Console Application
        {
            //creating instance of the employee class
            Employees emp = new Employees();
            emp.EmployeeName = "Sai Gajjala";

            string result = emp.PrintEmployeeName(emp.EmployeeName);
            Console.WriteLine("Result is: " + result);
            Console.ReadLine();
        }
    }
    public class Employees
    {
        //constructor-Every class should have one Constructor.
        public Employees() 
        { 
            Console.WriteLine("Constructor is called"); 
        }    
        public int Employeeid { get; set; }
        public string EmployeeName { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public int Salary { get; set; }

        public string PrintEmployeeName(string employeeName)//string in this line a return type for employeename.
        {
            Console.WriteLine("method is called");
            string name = string.Empty;
            if(employeeName !=null)
            {
                name = employeeName;
            }
            return name;
        }
    }
    //Class -Blue print of a Type.
    //method -Consits of public(public is a access modifier were any one can access)
}
