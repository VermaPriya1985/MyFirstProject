using System;

namespace MyFirstproject
{
    class FizzBuzz
    {
       public static void Run()
        {
            // Console.WriteLine("Hello World!");
            int myint = 100;
            ushort myushort =50;
            /* byte mybyte = 105;
            for(byte i=0;i<200;i++)
            {

                mybyte++;
                Console.WriteLine(mybyte);
            }  */  

            // sbyte mysbyte = 105;
            // for(byte i=0;i<200;i++)
            // {

            //     mysbyte++;
            //     Console.WriteLine(mysbyte);
            // }   

            // break 
            string mystring = "..Hello. How. are you";
            int counter = 0;
            for (int i=0; i<mystring.Length;i++)
            {

                   char nextletter = mystring[i];
                   Console.WriteLine("Next Letter is:" +  nextletter); 
                   
                //    if(nextletter == '.')
                //    {
                //        break;
                //    }
                if(nextletter!='.')
                {  

                continue;
                
                }
                
               counter++;
            }
            Console.WriteLine(counter);


        }   
    }

}
