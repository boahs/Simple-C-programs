using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreeterNoticeArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int number;

            string firstName = "Jordan";
            string lastName = "Parsons";

            string fullName = firstName + " " + lastName;
            string myFullName = string.Format("my name is {0} {1}", firstName, lastName);

            string[] names = new string[3] { "Jack", "John", "Tom" };
            string formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            string text = @"Hi Jordan 
            Look into the following paths
            c:\folder1\folder2
            c:\folder3\folder4";
            Console.WriteLine(text);




        }

    }
}
