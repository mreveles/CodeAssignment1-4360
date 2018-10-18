using System;

namespace testCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Employee 
    {
        string eName;
        int age;
        float salary;
        public Employee(string eName, float salary, int age)
        {
            this.eName = new string(eName);
            this.salary = salary;
            this.age = age;
        }
        public void displayEmpInfo(){
            Console.WriteLine("Empl. Name = {0} \n Empl Age = {1} \n Empl Salary = {2}", eName, age, salary);
        }
    }
}
