namespace BiDictionary
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var biDictionary = new BiDictionary<string, int, decimal>();

            biDictionary.Add("Pesho", 5, 10);
            biDictionary.Add("Pesho", 5, 30);
            biDictionary.Add("Pesho", 7, 30);
            biDictionary.Add("Pesho", 7, 40);
            biDictionary.Add("Gosho", 7, 70);
            biDictionary.Add("John", 5, 20);


            Console.WriteLine(string.Join(",",biDictionary.Find(5)));
            Console.WriteLine(string.Join(",", biDictionary.Find("Pesho", 7)));
            Console.WriteLine(string.Join(",", biDictionary.Find(7)));
            Console.WriteLine(string.Join(",", biDictionary.Find("Pesho")));
        }
    }
}
