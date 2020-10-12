using System;

namespace MyFirstproject
{
    class Array
    {
       public static void Run()
        {
            string[] myarray = new string[3];
           myarray[0] = "Array";
           myarray[1] = "hello";
           myarray[2] = "Bye";
           Console.WriteLine(myarray[0]);
           Console.WriteLine(myarray[1]);
           Console.WriteLine(myarray[2]);

           string[] myarr = new string[3] {"hi","by","thanks"};
           Console.WriteLine(myarr[0]);
       
           string[] mynewarr = {"a","b","c"};
           Console.WriteLine(mynewarr[1]);
       
         double[] studentgrade = new double[4] {1.0,2.0,3.0,4.0};
         double sum=0;
         for(int i=0;i<studentgrade.Length;i++)
         {
                Console.WriteLine(studentgrade[i]);
                sum += studentgrade[i];
          }
         double finalAverage = sum / studentgrade.Length;
         Console.WriteLine(finalAverage);
         
         
           // int[] arr = new int[4];
                   // FILLING ARRAY
           /* for (int i=0;i<arr.Length;i++)
dotnet            {
                Console.WriteLine("Enter nmumber");
                string userinput = Console.ReadLine();
                int nextint = Convert.ToInt32(userinput);
                arr[i] = nextint;

           } */

           // sum
           /* int sum=0;
           for (int i=0;i<arr.Length;i++)
            {
                sum +=arr[i];
            } */

            // display values
            /* for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            } */

         
    }

   }

}
