namespace BinaryPasswords
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            string password = Console.ReadLine();
            int starsCount = 0;
            for (var i = 0; i < password.Length; i++)
            {
                if (password[i] == '*')
                {
                    starsCount++;
                }
            }

            long result = 1;
            for (int i = 0; i < starsCount; i++)
            {
                result *= 2;
            }

            Console.WriteLine(result);

        }
    }
}
