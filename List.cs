using System;
using System.Collections.Generic; 
namespace MyFirstproject
{
    class List
    {
       static void Run()
        {
            // Dynamic Size in List

             List<int> mylist =  GatherInput(); 
             
/*            List<int> mylist = new List<int>(); 
            // Fill List    
            while(true)
            {

                Console.WriteLine("Enter next number or enter 'q' when you have done");
                string userinput = Console.ReadLine();
                if(userinput=="q")
                {
                        break;
                }
                
                int nextint = Convert.ToInt32(userinput);
                mylist.Add(nextint);

            }        
   */         
           /* for(int i=0;i<4;i++)
           {
                Console.WriteLine("Enter nmumber");
                string userinput = Console.ReadLine();
                int nextint = Convert.ToInt32(userinput);
                mylist.Add(nextint);

           }*/ 

            // PRINT LIST
            // PrintList(mylist);
           

            // Sum in LIST
           int sum=0;
           for (int i=0;i<mylist.Count;i++)
            {
                sum +=mylist[i];
            }

            // find MAX in LIST
           // int max=0;
           int max = GetMaxFromList(mylist);
             
            Console.WriteLine("MAX is: " + max);
            // Console.WriteLine("sum is: " + sum);
        }

    
 static List<int> GatherInput() {
            List<int> theListToReturn = new List<int>();

            while (true) {
                Console.WriteLine("Enter the next number. Or enter 'quit' when you're done.");
                string userInput = Console.ReadLine();

                if (userInput == "quit") {
                    break;
                }

                int nextInt = Convert.ToInt32(userInput);
                theListToReturn.Add(nextInt);
            }
            return theListToReturn;
        }

    static void PrintList(List<int> mylist)
    {

         for(int i=0;i<mylist.Count;i++)
            {
                Console.WriteLine(mylist[i]);
            } 
    }

    static int GetMaxFromList(List<int> somelist)
    {
         int max = somelist[0];
           for (int i=0;i<somelist.Count;i++)
           {
                if(somelist[i]>max)

           
            {
                max =somelist[i];
            }
           } 
           return max;

    }
        

    }

}
