using System;
namespace _1.StringsInCSharp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("A string is an object of type String whose value is text. Internally, the text is stored as a sequential read-only collection of Char objects. There is no null-terminating character at the end of a C# string; therefore a C# string can contain any number of embedded null characters ('\0'). The Length property of a string represents the number of Char objects it contains, not the number of Unicode characters. To access the individual Unicode code points in a string, use the StringInfo object.");
            Console.WriteLine();
            Console.WriteLine("Compare(String, String)- Compares two specified String objects and returns an integer that indicates their relative position in the sort order.");
            Console.WriteLine();
            Console.WriteLine("Contains -	Returns a value indicating whether a specified substring occurs within this string.");
            Console.WriteLine();
            Console.WriteLine("Equals(String)-	Determines whether this instance and another specified String object have the same value.");
            Console.WriteLine();
            Console.WriteLine("Format(String, Object) -	Replaces one or more format items in a specified string with the string representation of a specified object.");
            Console.WriteLine();
            Console.WriteLine("IndexOf(Char) -	Reports the zero-based index of the first occurrence of the specified Unicode character in this string.");
            Console.WriteLine();
            Console.WriteLine("Join(String, Object[]) -	Concatenates the elements of an object array, using the specified separator between each element.");
            Console.WriteLine();
            Console.WriteLine("Split(Char[]) -	Returns a string array that contains the substrings in this instance that are delimited by elements of a specified Unicode character array.");
            Console.WriteLine();
            Console.WriteLine("Substring(Int32, Int32) -	Retrieves a substring from this instance. The substring starts at a specified character position and has a specified length.");

        }
    }
}