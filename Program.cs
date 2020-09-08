using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Employee emp = new Employee();

            Console.Write("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("\nEmployer #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp = new Employee(id, nome, salario);

                list.Add(emp);
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int idToIncreaseSalary = int.Parse(Console.ReadLine());

           emp = list.Find(x => x.Id == idToIncreaseSalary);

            if(emp != null)
            {
                Console.Write("\nEnter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("Id não existe!");
            }

           

            Console.WriteLine("\nUpdated list of employees");
            
            foreach(Employee x in list){
                Console.WriteLine(x);
            }
        }
    }
}
