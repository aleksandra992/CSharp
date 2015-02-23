using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.SolveTasks
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter");
            Console.WriteLine("1--Reversing number");
            Console.WriteLine("2--Average of numbers");
            Console.WriteLine("3--Linear Equation");
            int type = int.Parse(Console.ReadLine());
            switch (type)
            {
                case 1:
                    {
                        Console.WriteLine("Enter decimal number that is non-negative");
                        decimal num = decimal.Parse(Console.ReadLine());
                        if (num < 0)
                        {
                            Console.WriteLine("The number should be positive");
                            Main();
                        }
                        Console.WriteLine("The reversed number is" + Reverse(num));
                        Main();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter integer numbers separated with comma");
                        int[] num = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(x => int.Parse(x)).ToArray();
                        if (num.Length == 0)
                        {
                            Console.WriteLine("You should enter one element at least");
                            Main();
                        }
                        Console.WriteLine("The average of the numbers is" + Average(num));
                        Main();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter ax+b=0 equation");
                        string equation = Console.ReadLine();
                        List<string> numbers = new List<string>();
                        StringBuilder number = new StringBuilder();
                        if (!equation.Contains("x"))
                        {
                            Console.WriteLine("You must enter a>0");
                            Main();
                            return;
                        }
                        for (int i = 0; i < equation.Length; i++)
                        {
                            if (equation[i] == '-')
                            {
                                number.Append("-");
                            }
                            else
                                if (equation[i] == '+')
                                {
                                    number.Append("+");
                                }
                                else
                                    if (char.IsDigit(equation[i]))
                                    {
                                        number.Append(equation[i]);

                                    }
                                    else
                                        if (equation[i] == 'x')
                                        {
                                            numbers.Add(number.ToString());
                                            number.Clear();
                                        }
                                        else
                                            if (equation[i] == '=')
                                            {
                                                break;
                                            }



                        }
                        if (numbers[0] == "0")
                        {
                            Console.WriteLine("a shoulsd not be zero");
                            Main();
                            return;
                            
                        }
                        if (number.Length != 0)
                        {
                            numbers.Add(number.ToString());
                        }
                        float a = float.Parse(numbers[0]);
                        float b;
                        if (numbers.Count == 1)
                        {
                            b = 0;
                        }
                        else
                            b = float.Parse(numbers[1]);
                        Console.WriteLine("x={0}",b/a);
                        Main();
                        break;

                    }
                default:
                    {
                        Main();
                        break;
                    }
            }
        }
        static decimal Reverse(decimal number)
        {
            string s = number.ToString();
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            s = new String(arr);
            return decimal.Parse(s);

        }
        static double Average(int[] numbers)
        {
            return numbers.Average();
        }
        static double LinearEquation(int a, int b)
        {
            return (-1) * b / a;


        }
    }
}
