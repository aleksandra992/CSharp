namespace FurnitureManufacturer
{
    using Engine;
    using System;
    using System.IO;

    public class FurnitureProgram
    {
        public static void Main()
        {
           // StreamReader reader=new StreamReader("..\\..\\Input.txt");
           // Console.SetIn(reader);
          //  StreamWriter writer = new StreamWriter("..\\..\\Output.txt");
           // Console.SetOut(writer);
            FurnitureManufacturerEngine.Instance.Start();
        }
    }
}
