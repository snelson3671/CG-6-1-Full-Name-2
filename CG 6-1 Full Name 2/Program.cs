using System;
using System.Text;

namespace CG_6_1_Full_Name_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Type your first name and press enter.  ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Type your last name and press enter.   ");
            string lastName = Console.ReadLine();

            string fullName = NewString(firstName, lastName);
            Console.WriteLine(fullName);

            Console.ReadLine();
        }

        private static string NewString(string nameA, string nameB)
        {
            StringBuilder fullName = new StringBuilder();


            fullName.Append("Hello ").Append(nameA).Append(" ").Append(nameB);


             string name = fullName.ToString();
            return name;
        }
        
    }
}
