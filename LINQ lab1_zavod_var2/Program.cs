using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_zavod
{
    internal class Program
    {
        public class Employee
        {
            protected int id;
            public int Id { get { return id; } set { id = value; } }
            protected string name;
            public string Name { get { return name; } set { name = value; } }
            protected double number;
            public double Number { get { return number; } set { number = value; } }
            protected string position;
            public string Position { get { return position; } set { position = value; } }
            protected float experience;
            public float Experience { get { return experience; } set { experience = value; } }
            protected float salary;
            public float Salary { get { return salary; } set { salary = value; } }
            public Employee(int id, string name, string position,double number, float experience, float salary)
            {
                this.id = id;
                this.name = name;
                this.number = number;
                this.position = position;
                this.experience = experience;
                this.salary = salary;
            }
            public override string ToString()
            {
                return $"Empoyee {name} working in {position} at {number} departmanet and have {experience} year experince and {salary}$";
            }
        }
        public interface IListEmployees
        {
            void Add(Employee employee);
            void Delete(int id);
            void EditExperience(int id, float experience);
            void EditSalary(int id, float salary);
            void Show();
        }
        public class ListEmployees : IListEmployees
        {
            protected List<Employee> employees;
            public List<Employee> Employees { get { return employees; } set { employees = value; } }
            public ListEmployees(List<Employee> employees)
            {
                this.employees = employees;
            }
            public void Add(Employee employee)
            {
                employees.Add(employee);
            }
            public void Delete(int id)
            {
                try
                {
                    employees = employees.Where(item => item.Id != id).ToList();
                }
                catch (Exception exexception)
                {
                    Console.WriteLine(exexception.Message);
                    Console.WriteLine("Smth wrong, check the id.");
                }
            }
            public void EditExperience(int id, float experience)
            {
                try
                {
                    employees.First(item => item.Id == id).Experience = experience;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Smth wrong, check the id.");
                }
            }
            public void EditSalary(int id, float salary)
            {
                try
                {
                    employees.First(item => item.Id == id).Salary = salary;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Smth wrong, check the id.");
                }
            }
            public void Show()
            {
                foreach (Employee employee in employees)
                {
                    Console.WriteLine(employee);
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            ListEmployees workers = new ListEmployees(
              new List<Employee>
              {
                        new Employee(1,"John","Director",3,15,30000),
                        new Employee(10,"John","qa",3,15,304000),
                        new Employee(2,"Vasyl","Janitor",3,1,300),
                        new Employee(3,"Olexii","CEO",7,13,25000),
                        new Employee(4,"Sofia","Head UI/UX and HR",3,8,14550),
                        new Employee(5,"Oleg","DEV team lead",10,25,25555)

              }
              );
            workers.Show();
            workers.Add(new Employee(6,"Igor","Data science",12,4,7600));
            workers.Show();
            workers.Delete(7);
            workers.Delete(42);
            workers.Show();
            workers.EditExperience(3, 13);
            workers.Show();
            workers.EditSalary(3, 13000);
            workers.Show();
            workers.EditExperience(42, 42);
            workers.EditSalary(42, 42);

            var task1 = workers.Employees.Where(item => item.Name == "John");

            Console.WriteLine("John");
            foreach (var item in task1)
            {
                Console.WriteLine($"Department: {item.Number}, position: {item.Position}, " +
                    $"experiene: {item.Experience}, salary: {item.Salary}");
            }
            var task2 = workers.Employees.GroupBy(group => group.Number).Select(item => new { item.Key, Value = item.Count() });

            foreach (var item in task2)
            {
                Console.WriteLine($"Department: {item.Key}, number of employees: {item.Value}");
            }
            Console.ReadLine();
            Console.WriteLine();
        }
    }
}