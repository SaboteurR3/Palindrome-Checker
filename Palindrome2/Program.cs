using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Palindrome checker
            Console.Write("Enter your string to check a palindrome: ");
            string myname = Console.ReadLine();
            myname.ToCharArray();
            Console.WriteLine("Your string length is: ");
            Console.WriteLine(myname.Length);
            List<char> mylist = new List<char>();
            int index = 1;
            for (int i = 0; i < myname.Length; i++)
            {
                mylist.Add(myname[myname.Length - index]);
                index++;
            }
            string word = "";
            Console.WriteLine("Your string but reversed: ");
            for (int i = 0; i < mylist.Count; i++)
            {
                Console.Write(mylist[i]);
            }
            for (int i = 0; i < mylist.Count; i++)
            {
                word += mylist[i];
            }
            Console.ReadLine();
            if (myname == word)
            {
                Console.WriteLine("This word is a palindrom");
            }
            else if (myname != word)
            {
                Console.WriteLine("This word is not a palindrom");
            }
        }
    }
}
