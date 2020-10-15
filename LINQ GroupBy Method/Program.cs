using System;
using LINQ_GroupBy_Method.Models;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_GroupBy_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> objStudent = new List<Students>()
            {
                new Students() { Name = "Suresh Dasari", Gender = "Male",Location="Chennai" },
                new Students() { Name = "Rohini Alavala", Gender = "Female", Location="Chennai" },
                new Students() { Name = "Praveen Alavala", Gender = "Male",Location="Bangalore" },
                new Students() { Name = "Sateesh Alavala", Gender = "Male", Location ="Vizag"},
                new Students() { Name = "Madhav Sai", Gender = "Male", Location="Nagpur"}
            };

            var Student = objStudent.GroupBy(x=> x.Location);

            foreach (var item in Student)
            {
                Console.WriteLine(item.Key+"  "+ item.Count());
                Console.WriteLine();

                foreach(var item2 in item)
                {
                    Console.WriteLine(item2.Name + "\t" + item2.Location);
                    Console.WriteLine();
                }


            }
        }
    }
}
