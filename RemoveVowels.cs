using System;
using System.Collections.Generic; 
namespace MyFirstproject
{
    class RemoveVowels
    {
       public static void Run()
        {
            string newstr = "";
            Console.WriteLine("Enter String to remove vowels");
            string str = Console.ReadLine();
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]!='a' && str[i]!='e' && str[i]!='i' && str[i]!='o' && str[i]!='u')
                {
                    newstr += str[i];
                }
            }
            Console.WriteLine("The New String is: " + newstr);
        }
    }
}
