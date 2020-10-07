using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Conversion_Operators_In_LINQ.Models;

namespace Conversion_Operators_In_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

        //ToList() -> Convert the collection to a List
            string[] countries = {"US", "UK","India", "Russia", "China", "Australia", 
            "Argentina"};

            //List<string> result = countries.ToList();
            //var result = countries.ToList();

            //Example of LINQ ToList() in Query Syntax
            //var result = (from x in countries select x).ToList();


        //ToArray()
            //string[] countryarray = countries.ToArray();

        //ToLookUp()
            // List<Employee> objEmployee = new List<Employee>()
            // {
            //     new Employee(){ Name="Ashish Sharma", Department="Marketing", Country="India"},
            //     new Employee(){ Name="John Smith", Department="IT", Country="Australia"},
            //     new Employee(){ Name="Kim Jong", Department="Sales", Country="China"},
            //     new Employee(){ Name="Marcia Adams", Department="HR", Country="USA"},
            //     new Employee(){ Name="John Doe", Department="Operations", Country="Canada"}
            // };

            // var emp = objEmployee.ToLookup(x => x.Department);

            // Console.WriteLine("Grouping Employees by Department");
            // Console.WriteLine("---------------------------------");

            // foreach (var KeyValurPair in emp)
            // {
            //     Console.WriteLine(KeyValurPair.Key);
            //     // Lookup employees by Department
            //     foreach (var item in emp[KeyValurPair.Key])
            //     {
            //         Console.WriteLine("\t" + item.Name + "\t" + item.Department + "\t" + item.Country);
            //     }
            // }

            // ArrayList obj = new ArrayList();

            // obj.Add("India");

            // obj.Add("USA");

            // obj.Add("UK");

            // obj.Add("Australia");

            // IEnumerable<string> result = obj.Cast<string>();

            // foreach(var item in result)
            // {
            //     Console.WriteLine(item);
            // }

        //AsQueryable -> Convert the List to a Query Type
            List<Students> objStudent = new List<Students>()
            {

                new Students() { Id = 1 ,Name = "Suresh Dasari", Gender = "Male",Location="Chennai" },

                new Students() { Id = 2, Name = "Rohini Alavala", Gender = "Female", Location="Chennai" },

                new Students() { Id = 3, Name = "Praveen Alavala", Gender = "Male",Location="Bangalore" },

                new Students() { Id = 4, Name = "Sateesh Alavala", Gender = "Male", Location ="Vizag"},

                new Students() { Id = 5, Name = "Madhav Sai", Gender = "Male", Location="Nagpur"}

            };

            //These calls are the same, both convert to a IQueryable object
            // IQueryable<Students> query = objStudent.AsQueryable().Where(x => 
            // x.Name.Contains("Alavala"));

            //var query = objStudent.Where(x=> x.Name.Contains("Alavala"));
            
        //ToDictionary Operator
            var student = objStudent.ToDictionary(x=> x.Id, x => x.Name);

            foreach (var stud in student)
            {
                Console.WriteLine(stud.Key + "\t" + stud.Value);
            }
        }
    }
}
