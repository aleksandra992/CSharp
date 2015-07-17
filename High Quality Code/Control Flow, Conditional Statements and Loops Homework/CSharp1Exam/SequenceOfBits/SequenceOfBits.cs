namespace CSharp1Exam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SequnceOfBits
    {
        public static List<ulong> GetAllCountsOfBitsInSequence(char inputBit, string binaryArray)
        {
            List<ulong> allCountsOfBits = new List<ulong>();
            allCountsOfBits.Add(0);
            ulong countOfBitsInSequnce = 0;

            for (int i = 0; i < binaryArray.Length; i++)
            {
                char bit = binaryArray[i];
                while (bit == inputBit)
                {
                    countOfBitsInSequnce++;
                    i++;
                    if (i >= binaryArray.Length)
                    {
                        break;
                    }

                    bit = binaryArray[i];
                }
                allCountsOfBits.Add(countOfBitsInSequnce);
                countOfBitsInSequnce = 0;
               
            }

            return new List<ulong>(allCountsOfBits);
        }

        public static void Main()
        {
            uint countOfInputNumbers = uint.Parse(Console.ReadLine());
            string binaryNumber = "", binaryArray = "";
            uint number = 0;

            for (int i = 0; i < countOfInputNumbers; i++)
            {
                number = uint.Parse(Console.ReadLine());
                binaryNumber = Convert.ToString(number, 2).PadLeft(30, '0');
                binaryNumber = binaryNumber.Substring(binaryNumber.Length - 30);
                binaryArray += binaryNumber;
            }

            List<ulong> countsOfOnesInSequence = new List<ulong>();
            countsOfOnesInSequence = GetAllCountsOfBitsInSequence('1', binaryArray);
            Console.WriteLine(countsOfOnesInSequence.Max());

            List<ulong> countsOfZerosInSequence = new List<ulong>();
            countsOfZerosInSequence = GetAllCountsOfBitsInSequence('0', binaryArray);
            Console.WriteLine(countsOfZerosInSequence.Max());
            

        




        }
    }
}