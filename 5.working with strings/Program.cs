using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.working_with_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" this will be on one line ");
            Console.WriteLine(" skies are red \n roses are red \n i love you");
            Console.WriteLine(" ndaa dzina langa ndipfi \"phato\" ");

            //declarations
            string firstname = "phato";
            string lastname = "mukhuba";
            Console.WriteLine(firstname + " " + lastname); //the + is used to concstinate

            Console.WriteLine("the length of the name is " + firstname.Length); //functions on strings

            // chane name to uppercase, change last name to lower case
            Console.WriteLine(firstname.ToUpper()+ " " + lastname.ToLower());
            Console.WriteLine("does firstname contain at " + firstname.Contains("at"));
            Console.WriteLine("The first letter of the name is " + firstname[3]);
            Console.WriteLine("the index of h is " + firstname.IndexOf('o'));
            Console.WriteLine(" the substing from 2 " + lastname.Substring(2));
            Console.WriteLine("the substring from 0 to 4 " + lastname.Substring(0, 3));

            //freeze console
            Console.ReadLine();
        }
    }
}
