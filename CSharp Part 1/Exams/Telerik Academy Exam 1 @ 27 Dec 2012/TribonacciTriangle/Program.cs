using System;
   class Program
    {
        static void Main()
        {
            Int64 first = Int64.Parse(Console.ReadLine());
            Int64 second = Int64.Parse(Console.ReadLine());
            Int64 third = Int64.Parse(Console.ReadLine());
            Int64 heightTriangle=Int64.Parse(Console.ReadLine());
            Int64[] str=new Int64[(heightTriangle*(heightTriangle+1))/2];
            str[0] = first;
            str[1] = second;
            str[2] = third;
            Int64 pom1 = 0,fourth,pom2=0;
            int n=1,k=0;
            for (int i = 3; i < str.Length; i++)
            {
                fourth = first + second + third;
                str[i] = fourth;
                pom1 = third;
                pom2 = second;
                third = fourth;
                second = pom1;
                first = pom2;
                
            }
            for (int i = 0; i < heightTriangle; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write((j==n-1)?str[k]+"\n":str[k]+" ");
                    k++;
                }
               // Console.WriteLine("\n");
                n++;
            }
        }
    }

