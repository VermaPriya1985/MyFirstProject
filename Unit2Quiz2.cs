using System;
using System.Collections.Generic; 
namespace MyFirstproject
{
    class Unit2Quiz2
    {
       // static void Main(string[] args) 
       public static void Run()
        {
            // We can have list of arrays and arrays of list
            // var mylist = new List<int[]>();
            var myarray = new List<int>[4];

            var mylist = new List<int>(){1,2,3};
            Console.WriteLine("My list: " + mylist[0]);
            MyFunction(mylist);
            Console.WriteLine("My list: " + mylist[0]);
             int a =1;
           FuncA(a);

           int b=2;
           b = FuncB(b);
          // Console.WriteLine(b);

           var c = new List<int> {8,-9,12};
           c.Add(15);
           FuncC(c);
           //PrintList(c);

           var d = new List<int> {-5,6,4};
          
           FuncD(d);
           PrintList(d);

           var e = new List<int> {-5,6,4};
          
           FuncE(e);
           PrintList(e);


        }
        static void FuncA(int x)
        {
            x++;
        }
        static int FuncB(int x)
        {
            x++;
            return x;
        }
        static void FuncC(List<int> x)
        {
            x.Add(49);
        }
        static void FuncD(List<int> x)
        {
              var temp = new List<int>();
              temp = x;
              temp.Add(5);
    
        }
        static void FuncE(List<int> x)
        {
              var temp = new List<int>();
              for(int i=0;i<x.Count;i++)
              {
                  temp.Add(x[i]);
              }
        temp.Add(122);
        }
        
        static void PrintList(List<int> mylist)
    {

         for(int i=0;i<mylist.Count;i++)
            {
                Console.WriteLine(mylist[i]);
            } 
    }

    static void MyFunction(List<int> somelist)
    {
        somelist[0] = -99;

    }

    }
}
