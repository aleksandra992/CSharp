using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] integers = Console.ReadLine().Split(' ');
        int first = int.Parse(integers[0]);
        int second = int.Parse(integers[1]);
        int third = int.Parse(integers[2]);
        int fourth = int.Parse(integers[3]);
        int fifth = int.Parse(integers[4]);
        int sum=0;
        int subsets = 0;
        string str=" ";
        string s = " ";
        
       
        for (int i = 1; i < 32; i++)
        {

            s = Convert.ToString(i, 2).PadLeft(5,'0');
            
            int proba = s.Length;
            for (int j = 0; j < s.Length; j++)
            {
                sum +=int.Parse( integers[j]) * int.Parse(s[j].ToString());
                

                
            }
            if (sum == 0)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    
                    if (s[j] == '1')
                    {
                        str += integers[j] + "+";
                        //Console.Write(integers[j] + ((j==s.Length-1)?"":"+"));
                    }
                   

                }
                
                Console.WriteLine("=0\n");
                    subsets++;
                sum = 0;
            }
            sum = 0;

        }
        Console.WriteLine(subsets);


    }
}

