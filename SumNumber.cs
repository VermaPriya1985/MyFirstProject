using System;
namespace MyFirstproject
{
    class SumNumber
    {
        public static void Run()
        {
            
           try  
           {

            double sum = 0;
            double diff = 0;
            Console.WriteLine("Enter first number");
            double first_num=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double second_num=Convert.ToDouble(Console.ReadLine());
            diff = second_num-first_num;
            for(int i=0;i<=diff;i++)
            {
                 
                  sum = first_num + sum;        
                  first_num = first_num + 1; 
                  // Console.WriteLine("The Sum is: " + sum);
                  // Console.WriteLine("The first_num is: " + first_num);
             } 
            Console.WriteLine("The Sum is: " + sum);
           }
           catch(Exception ex)
           {

               Console.WriteLine("Kindly provide correct value");
           }
        }
    }
}
