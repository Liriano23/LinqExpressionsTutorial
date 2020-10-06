using System;
using System.Linq;
using System.Collections.Generic;
using CursoLinqProject.Models;

namespace CursoLinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //     //Este projecto es para practicar LinqExpressions 
            
            //   //Where Comand
            //     string[] countries = {"Austria","Venice","Dominican Republic", "USA",
            //     "Argentina"};

            //     //Equal to Select name from Country where name like 'A%'
            //     //IEnumerable<string> result = countries.Where(x => x.StartsWith("A"));

            //     //Where Clause with Query Syntax Example
            //     // IEnumerable<string> result = from x in countries
            //     // where x.StartsWith("U") select x;

            //     //Multiple conditions 
            //     IEnumerable<string> result = countries.Where(x=> x.StartsWith("A")).ToList();

            //     foreach(var item in result)
            //     {
            //         Console.WriteLine(item);
            //     }


            //Sort Operator
            List<Students> ObjectStudents = new List<Students>()
            {
                new Students() {Id=1, Name = "Suresh Dasari", Gender="Male",
                Subjects = new List<string>() {"Mathematics", "Physic"}},

                new Students() {Id=2, Name = "Rohini Alavala", Gender = "Female", 
                Subjects = new List<string> { "Entomology", "Botany" }},

                new Students() { Id=3, Name = "Praveen Kumar", Gender = "Male", 
                Subjects = new List<string> { "Computers", "Operating System", "Java" } },

                new Students() { Id=4, Name = "Sateesh Chandra", Gender = "Male", 
                Subjects = new List<string> { "English", "Social Studies", "Chemistry" } },

                new Students() { Id=5, Name = "Madhav Sai", Gender = "Male", 
                Subjects = new List<string> { "Accounting", "Charted" } }
            };

            //Ascending 
            //var  students = ObjectStudents.OrderBy(x=> x.Name);

            //Descending
            //var students = ObjectStudents.OrderByDescending(x=> x.Name);

            //Then By sorting operator
            //var students = ObjectStudents.OrderBy(x=> x.Name).ThenBy(x=> x.Id);
            
            //SQL ThenBy Operator with Query Syntax
            // IOrderedEnumerable<Students> students = from x in ObjectStudents
            // orderby x.Name, x.Id select x;

             IOrderedEnumerable<Students> students = from x in ObjectStudents
             orderby x.Name, x.Id descending select x;

            

            foreach(var item in students)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}");
            }
        }
    }
}
