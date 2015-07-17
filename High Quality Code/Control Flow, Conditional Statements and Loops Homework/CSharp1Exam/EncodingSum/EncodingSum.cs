namespace CSharpt1Exam
{
    using System;
    using System.Numerics;

    public class EncodingSum
    {
        public static void Main()
        {
            const char CharacterForEnd = '@';
            ulong module = ulong.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            BigInteger result = 0;

            for (int i = 0; i < text.Length; i++)
            {
                var currentCharacter = text[i];
                if (currentCharacter == CharacterForEnd)
                {
                    break;
                }
                else
                    if (char.IsDigit(currentCharacter))
                    {
                        result *= int.Parse(currentCharacter.ToString());
                    }
                    else
                    {
                        char currentCharUpperCase = char.ToUpper(currentCharacter);
                        if (char.IsLetter(currentCharUpperCase))
                        {
                            result += (int)currentCharUpperCase - 65;
                        }
                        else
                        {
                            result %= module;
                        }
                    }
            }

            Console.WriteLine(result);
        }
    }
}