using System;

    class Program
    {
        static void Main()
        {
            string n = Console.ReadLine();

            char[] arr = n.ToCharArray();
            Array.Reverse(arr);
            ulong sum = 0;
           string number= new string(arr);

            for (int i = 0; i < number.Length; i++)
            {
                if (char.IsDigit(number[i]))
                {
                    if (i % 2 == 0)
                    {
                        sum += ulong.Parse(number[i].ToString()) * (ulong)((i+1) * (1+i));
                    }
                    else
                        sum +=ulong.Parse(number[i].ToString()) * ulong.Parse(number[i].ToString()) * (ulong)(i + 1);
                }
            }
            Console.WriteLine(sum);
            if (sum % 10 == 0)
            {
                Console.WriteLine(n + " has no secret alpha-sequence");
                return;
            }
            ulong r = 0;
            r = sum % 26;
            char u;
            ulong length=r+1+sum%10;
            ulong j = 0;
            j = r  + 65;
            for (ulong i =r+1; i <length ; i++)
            {
                
                
                if (j > 90)
                {
                    j = 65;
                }
                Console.Write((char)j);
                j++;
               
            }
        }
    }
