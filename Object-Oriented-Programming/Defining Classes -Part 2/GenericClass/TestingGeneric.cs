namespace GenericClass
{
    using System;

     public class TestingGeneric
    {
        public static void Main()
        {
            GenericList<int> list = new GenericList<int>(4);
            list.AddElement(1);
            list.AddElement(2);
            list.AddElement(3);
            list.AddElement(4);
            list.AddElement(5);
            
            Console.WriteLine("The initial list is{0} ",list.ToString());
            list.RemoveAt(2);
            Console.WriteLine("The list after removing the second element is {0}",list.ToString());
            list.AddElement(5);
            list.AddElement(10);
            Console.WriteLine("The list after adding two more element is {0}", list.ToString());
            
          
            list[2] = 555;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The count of the list is {0}",list.Count);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The list after using indexer is {0}", list.ToString());
            Console.WriteLine("The second element is {0}", list[2]);
            Console.WriteLine("The max is {0}",list.Max());
            Console.WriteLine("The index of element 555  is {0}", list.FindByValue(555));
            list.DeleteList();
            Console.WriteLine("The list is empty {0}", list.ToString());

            
        }
    }
}
