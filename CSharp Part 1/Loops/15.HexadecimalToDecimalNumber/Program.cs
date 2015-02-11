using System;

    class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            long sum = 0;
            string pom=" ";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                pom=s[i].ToString();
                switch (pom)
                {
                        
                    case "A":
                        {
                           pom="10";
                            break;
                        }
                    case "B":
                        {
                             
                           pom="11";
                            break;
                        }
                        case "C":
                        {
                             
                           pom="12";
                            break;
                        }
                        case "D":
                        {
                             
                           pom="13";
                            break;
                        }
                        case "E":
                        {
                             
                           pom="14";
                            break;
                        }
                        case "F":
                        {
                             
                           pom="15";
                            break;
                        }
                    default:break;

                        
                }
                sum += long.Parse(pom.ToString()) *(long) (Math.Pow(16,(s.Length - 1-i)));
            }
            Console.WriteLine(sum);
        }
    }

