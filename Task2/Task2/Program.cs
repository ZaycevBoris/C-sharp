using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Collections
{
    public class Department
    {
        public string name;
        public int number;
        public string director;
    }
    public class Employee
    {
        public string Name;
        public string surname;
        public string patronymic;
        public int age;
        public Department dep = new Department();
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> workers = new List<Employee>();
            workers.Add(new Employee { Name = "Oleg", surname = "Olegov", patronymic = "Olegovich", age = 23, dep = { name = "s", director = "Gleb", number = 1 } });
            workers.Add(new Employee { Name = "petr", surname = "Petrov", patronymic = "Petrovich", age = 32, dep = { name = "rock1", director = "Nikita", number = 2 } });

            workers.GroupBy(x => x.dep.name).ToDictionary(x => x.Key, x => x.ToList());
        }
    }
}

