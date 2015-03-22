


namespace VersionAttribute
{
    using System;
    [Version("2.1")]
   public class TestingAttribute
    {
       public static void Main()
        {
            Type type = typeof(TestingAttribute);
          var allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute  attr in allAttributes)
            {
                Console.WriteLine("This class has version {0}", attr.Version);
                
            }
        }
    }
}
