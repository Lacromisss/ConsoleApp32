using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    internal class Departament
    {
        private string _name;
        private int employeLimit;
        private int salaryLimit;
        public string []employees;
        public Employee [] students = new Employee[0];
       



        public void AddEmployee()
        {
            try
            {
                if (employees.Length < employeLimit)
                {
                    Array.Resize(ref employees, employees.Length + 1);



                }

            }
            catch (Exception)
            {
                Console.WriteLine("wrong");

                throw;
            }
            
          




        }


    }
}
