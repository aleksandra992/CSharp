using System;

    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int pom1=0;
           int pom2=0;
            
            if (a < b)
            {
                pom2=a;
                a=b;
                b=pom2;
            }
                
                while(a%b!=0)
                {
                    pom1=(a%b);
                 
                    a = b;
                    b = pom1;
                    
                }
                Console.WriteLine(b);
 
            
            
        }
    }

