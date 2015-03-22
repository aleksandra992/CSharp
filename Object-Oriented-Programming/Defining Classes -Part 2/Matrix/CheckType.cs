using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_
{
   public class CheckType<T>
    {
       public static bool CheckTypeOf()
       {
           if (typeof(T) == typeof(Int32) || typeof(T) == typeof(Double))
           {
               return true;
           }
          
           return false;
       }

    }
}
