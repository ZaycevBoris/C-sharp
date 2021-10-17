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
        public string age;
        public int num;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> work = new List<Employee>(0);
            work.Add(new Employee() { Name = "s", surname = "s", patronymic = "f", age = "g", num = 1 });
            work.Add(new Employee() { Name = "d", surname = "s", patronymic = "f", age = "g", num = 2 });
            work.Add(new Employee() { Name = "s", surname = "s", patronymic = "f", age = "g", num = 3 });


            List<Department> rock = new List<Department>(0);
            rock.Add(new Department() { name = "rock1", number = 1, director = "Pavel" });
            rock.Add(new Department() { name = "rock2", number = 2, director = "Elisey" });
            rock.Add(new Department() { name = "rock3", number = 3, director = "Natasha" });

            Dictionary<string, List<Employee>> yoga = new Dictionary<string, List<Employee>>();
            foreach (Department i in rock)
            {
                var selectedWorkers = from w in work
                                      where w.num == i.number
                                      orderby w.Name
                                      select w;

                yoga.Add(i.name, selectedWorkers.ToList());
            }
        }
    }
}

