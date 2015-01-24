using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            //var list = new List<string>();
            String [] s=new String[n];
             List<int> list = new List<int>();
             
            
            int j=0;
            int pom = n;
            Random rnd = new Random();
            for (int k = 1; k <= n; k++)
            {
                list.Add(k);
 
            }
            
                for (int i = 0; i <n; i++)
                {
                    
                    j = rnd.Next(1, pom+1);
                    Console.Write(list[j-1] + " ");
                    list.RemoveAt(j-1);
                    pom--;
                   

                    
                    
                }

            
        }
    }

