using System;

    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string s1, s2;
            int brTockiStrana=number+1;
            int brTockiSredina = number + 1;
            s1 = new String('.',brTockiStrana);
            brTockiStrana -= 2;
            s2=new String('*',number-1);
            Console.WriteLine(s1 + s2 + s1);
            int pomI=0;
            if (number != 2)
            {
                for (int i = 0; i <= (number - i) - 1; pomI++, i++)
                {

                    s1 = new String('.', brTockiStrana);
                    s2 = new String('.', brTockiSredina);
                    brTockiStrana -= 2;
                    brTockiSredina += 4;
                    Console.WriteLine(s1 + "*" + s2 + "*" + s1);


                }
            }
            brTockiStrana+=2;
            brTockiSredina-=4;
            for (int i = 0; i < number - pomI - 2;i++ )
            {
                s1 = new String('.', brTockiStrana);
                s2 = new String('.', brTockiSredina);
                Console.WriteLine(s1 + "*" + s2 + "*" + s1);
            }

            Console.Write(".*");
            int widthMajmuniTocki=((3 * number + 1) - 4)/2;
            for (int i = 0; i <widthMajmuniTocki ; i++)
            {
                Console.Write("@.");
            }
            Console.Write("@");
            Console.Write("*.\n");
            Console.Write(".*");
            for (int i = 0; i < widthMajmuniTocki; i++)
            {
                Console.Write(".@");
            }
            Console.Write(".");
            Console.Write("*.\n");
            for (int i = 0; i < number - pomI - 2; i++)
            {
                s1 = new String('.', brTockiStrana);
                s2 = new String('.', brTockiSredina);
                Console.WriteLine(s1 + "*" + s2 + "*" + s1);
            }
            if (number != 2)
            {
                for (int i = 0; i <= (number - i) - 1; pomI++, i++)
                {

                    s1 = new String('.', brTockiStrana);
                    s2 = new String('.', brTockiSredina);
                    brTockiStrana += 2;
                    brTockiSredina -= 4;
                    Console.WriteLine(s1 + "*" + s2 + "*" + s1);


                }
            }
            s1 = new String('.', brTockiStrana);
            s2 = new String('*', number - 1);
            Console.WriteLine(s1 + s2 + s1);
        }
    }

