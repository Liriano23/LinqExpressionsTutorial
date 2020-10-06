using System;
using System.Linq;
using System.Collections.Generic;

namespace Partition_Operator_In_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] countries = {"India", "USA", "Russia", "China", "Australia","Argentina", "United Kingdom"};

            //IEnumerable<string> result = countries.Take(3);

            //LINQ Take Operator in Query Syntax Example
            //IEnumerable<string> result = (from x in countries select x).Take(3);

            /*
                Take While -> This one make a partition chosing the elements than 
                comply with the conditions 
            */

            string[] countries = { "US", "UK", "Russian", "China", "Australia", "Argentina" };
            //IEnumerable<string> result = countries.TakeWhile(x =>  x.StartsWith("U"));

            //Example of LINQ TakeWhile in Query Syntax
            //IEnumerable<string> result = (from x in countries select x).TakeWhile(x => x.StartsWith("U"));
            
            /*
                //Skip -> Avoid the number of elements in the paramater and 
                return the remaining ones
            */

           //IEnumerable<string> result = countries.Skip(3);

           //Query Sintax
           //IEnumerable<string> result = (from x in countries select x).Skip(3);

            //Skip while 
            IEnumerable<string> result = countries.SkipWhile(x => x.StartsWith("U"));
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }


        }
    }
}
