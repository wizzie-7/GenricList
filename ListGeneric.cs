using System;
using System.Collections.Generic;

namespace GenricList
{
    class ListGeneric
    {
        static void Main(string[] args)
        {
            List<Employee> LT = new List<Employee>();
            LT.Add(new Employee { Empid = 101, EmpName = "Vivek" });
            LT.Add(new Employee { Empid = 1001, EmpName = "Krunal" });
            LT.Add(new Employee { Empid = 10001, EmpName = "Nirbhay" });
            LT.Add(new Employee { Empid = 100001, EmpName = "Abhi" });

            GenereicList GL = new GenereicList();
            GL.PrintList(LT);

        }
    }

    public class Employee
    {
        public int Empid { get; set; }
        public String EmpName { get; set; }
    }
    public class GenereicList
    {
        public void PrintList(IList<Employee> E1)
        {
            foreach(Employee emp in E1)
            {
                Console.WriteLine(emp.Empid + " " + emp.EmpName);
            }
        }

    }
}
