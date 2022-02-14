using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker 
  {
    class Program 
      {
        static void Main(string[] args) 
          {
            List<Employee> employees = new List<Employee>();


            Console.WriteLine("Would you like to fetch data from the API? (yes/no)");
            string answer = Console.ReadLine();
            if (answer == "yes") {
              employees = PeopleFetcher.GetFromApi();
            } else {
              employees = PeopleFetcher.GetEmployees();

            }
            
            Util.MakeBadges(employees);
            Util.MakeCSV(employees);
          }

      }
  }