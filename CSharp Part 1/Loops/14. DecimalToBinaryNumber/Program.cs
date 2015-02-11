using System;



    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            string s=null;
            int i = 0;
            while (n != 0)
            {
                s+=(n % 2).ToString();
                n = n / 2;
                i++;
                
            }
            var temp = s.ToCharArray();
            Array.Reverse(temp);
            
           Console.WriteLine( new String(temp));
            
          /*  for (int j = s.Length-1; j >=0; j--)
            {
                Console.Write(s[j]);
 
            }
           * */
        }
    }

