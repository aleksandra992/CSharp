using System;


namespace _11.NumberAsWords
{
    class Program
    {
        static void Main()
        {
            string[] hundreds = new string[] { "One hundred", "Two hundred", "Three hundred", "Four hundred", "Five hundred", "Six hundred", "Seven hundred", "Eight hundred", "Nine hundred" };
            string[] tens = new string[] { "twenty", "thirthy", "fourthy", "fifthy", "sixty", "seventy", "eighty", "ninety" };
            string[] ones = new string[] { "zero","one", "two", "three", "four", "five", "six", "seven", "eight", "nine","ten","eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen" };
            string and = " and ";
            int number = 0;
            int stotki=0;
            int desetki=0;
            int edinici=0;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number < 20)
                        Console.WriteLine(ones[number]);
                    if (number >= 20 && number < 100)
                    {
                        Console.WriteLine(tens[number / 10 - 2] + " " + ((number % 10 == 0) ? "" : ones[number % 10]));
                    }
                    if (number >= 100 && number < 1000)
                    {

                        stotki = number / 100;
                        desetki = (number % 100) / 10;
                        edinici = (number % 100)%10;
                        if (desetki==1)
                        {
                            Console.WriteLine(hundreds[stotki - 1] +and +  ones[number%100]);
                        }
                        else
                        Console.WriteLine(hundreds[stotki - 1] + and+ ((desetki) == 0 ? "" : tens[desetki - 2]) + " " + ((edinici == 0) ? "" : ones[edinici]));
                    }

                }
            }


        }



       
    }
}
