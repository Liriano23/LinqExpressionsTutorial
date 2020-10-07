using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections;
using System.Collections.Generic;
using Element_Operators_in_LINQ.Models;

namespace Element_Operators_in_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //First
                //int[] objList = { 1, 2, 3, 4, 5 };
                // int result = objList.First();

                // Console.WriteLine("Element from de list {0} ", result);
            
            //FirstOrDefault
                // int[] objtList = new int[] {};
                // int result = objtList.FirstOrDefault();
                // Console.WriteLine(result);

            //Last -> Return the last element on a List
                // int[] objtList = {1,2,5,6,4};
                // int result = objtList.Last();
                // Console.WriteLine(result);
            
            //LastOrDefault -> Return the last element on a List or default value
                // int[] objtList = {};
                // var result = objtList.LastOrDefault();
                // Console.WriteLine(result);
            
            //ElementAt(value) -> return the index of the value pass as a parameter
                // int[] objList = { 1, 2, 3, 4, 5 };
                // int result = objList.ElementAt(1);
                // int val = objList.ElementAt(3);
                // Console.WriteLine("Element At Index 1: {0}", result);
                // Console.WriteLine("Element At Index 3: {0}", val);

            /*
                ElementAtOrDefault(value) -> return the index of the value 
                pass as a parameter or return default value if the element index
                does not exist
             */
                // int[] objList = { 1, 2, 3, 4, 5 };
                // int result = objList.ElementAtOrDefault(8);
                // int val = objList.ElementAtOrDefault(10);
                // Console.WriteLine("Element At Index 1: {0}", result);
                // Console.WriteLine("Element At Index 3: {0}", val);

            //Single -> Return single element or a single element that satisfy the condition given as an Argument

                // List<Students> objStudent = new List<Students>()
                // {

                // new Students() { Name = "Suresh Dasari", Gender = "Male",Location="Chennai" },

                // new Students() { Name = "Rohini Alavala", Gender = "Female", Location="Chennai" },

                // new Students() { Name = "Praveen Alavala", Gender = "Male",Location="Bangalore" },

                // new Students() { Name = "Sateesh Alavala", Gender = "Male", Location ="Vizag"},

                // new Students() { Name = "Madhav Sai", Gender = "Male", Location="Nagpur"}

                // };

                // int[] objList = { 1 };

                // var user = objStudent.Single(s => s.Name == "Suresh Dasari");

                // string result = user.Name;

                // int val = objList.Single();

                // Console.WriteLine("Element from objStudent: {0}", result);

                // Console.WriteLine("Element from objList: {0}", val);

            //SingleOrDefault ->  return a single element or default value in case if there are no elements present in the list / collection.
                // List<Students> objStudent = new List<Students>()
                // {
                //     new Students() { Name = "Suresh Dasari", Gender = "Male",Location="Chennai" },

                //     new Students() { Name = "Rohini Alavala", Gender = "Female", Location="Chennai" },

                //     new Students() { Name = "Praveen Alavala", Gender = "Male",Location="Bangalore" },

                //     new Students() { Name = "Sateesh Alavala", Gender = "Male", Location ="Vizag"},

                //     new Students() { Name = "Madhav Sai", Gender = "Male", Location="Nagpur"}
                // };

                // int[] objList = { 1,2,3,4,5 };

                // var user = objStudent.SingleOrDefault(s => s.Name == "Suresh Dasari");

                // string result = user.Name;

                // int val = objList.SingleOrDefault(j => j>5);

                // Console.WriteLine("Element from objStudent: {0}", result);

                // Console.WriteLine("Element from objList: {0}", val);
        }   
    }
}