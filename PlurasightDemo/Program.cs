using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Collections.Generic;

namespace PlurasightDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer> {
            new Customer {Name="Simon",City="xuzhou", Age = 33, Id=100},
            new Customer{ Name="Hao",City="Yichang", Age=30, Id=200}
            };
            var xcity = customers.Where(c => c.City.StartsWith("x"));
           
            foreach (var c in xcity)
            {
                Console.WriteLine(c.Name);
            }
            Console.ReadLine();
        }
    }
}
