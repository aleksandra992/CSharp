using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string first;
            string second;
            string fourth;
            string fifth;
            int pom = n;
            int pom1=0;
            double sizeUpperPart=(2/3.0)*(6+((n-3)/2*3));
            double sizeLowerPart=(1/3.0)*(6+((n-3)/2*3));
            first = new String('.', pom);
            Console.WriteLine(first+"*"+first);
            for(int i=1;i<sizeUpperPart-1;i++)
            {
                pom--;
                first=new String('.',pom);
                second=new String('.',pom1);
                pom1++;
                Console.WriteLine(first+"*"+second+"*"+second+"*"+first);


            }
            pom1--;
            fourth = new String('*', 2 * n +1);
            Console.WriteLine(fourth);
            for (int i = 0; i < sizeLowerPart-1; i++)
            {
                
                first = new String('.', pom);
                second = new String('.', pom1);
                pom++;
                pom1--;
                Console.WriteLine(first + "*" + second + "*" + second + "*" + first);
            }
            first = new String('.', pom);
            fourth=new String('*',n);
            Console.WriteLine(first + fourth + first);

            

        }
    }

