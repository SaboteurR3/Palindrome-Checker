using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome2
{
    class Program
    {
        // The method of a palindrome checker 
        static void PalindromeChecker(string myname, List<char> mylist)
        {
            myname.ToCharArray();
            Console.WriteLine("Your string length is: ");
            Console.WriteLine(myname.Length);
            int index = 1;
            for (int i = 0; i < myname.Length; i++)
            {
                mylist.Add(myname[myname.Length - index]);
                index++;
            }
            string word = string.Empty;
            Console.WriteLine("Your string but reversed: ");
            for (int i = 0; i < mylist.Count; i++)
            {
                Console.Write(mylist[i]);
            }
            for (int i = 0; i < mylist.Count; i++)
            {
                word += mylist[i];
            }
            if (myname.Equals(word))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nThis word is a palindrom");
                Console.ResetColor();
            }
            else if (!(myname.Equals(word)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nThis word is not a palindrom");
                Console.ResetColor();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome checker (=^_^=) \n"); 
            bool mainBool = true;
            while (mainBool)
            {
                try
                {                   
                    Console.Write("Enter your string to check a palindrome: ");
                    string savedString = Console.ReadLine();
                    List<char> list = new List<char>();
                    PalindromeChecker(savedString, list);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
                finally
                {
                    Console.WriteLine("Do you want to continue again (Y/N)?");
                    bool question = true;
                    while (question)
                    {
                        char Continue = Console.ReadLine()[0];
                        if (Continue == 'y' || Continue == 'Y')
                        {
                            question = false;
                        }
                        else if (Continue == 'n' || Continue == 'N')
                        {
                            question = false;
                            mainBool = false;
                            Console.WriteLine("Bye <3");
                        }
                        else
                        {
                            Console.WriteLine("Choose 'Y' or 'N' ");
                        }
                    }
                }
            }
        }
    }
}