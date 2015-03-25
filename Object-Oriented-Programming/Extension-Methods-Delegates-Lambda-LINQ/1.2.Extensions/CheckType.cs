namespace CheckType
{
    using System;

    public class CheckType
    {
        public static bool CheckTypeOf<T>()
        {
            if (typeof(T) == typeof(string))
            {
                return true;
            }

            if (typeof(T) == typeof(string[]))
            {
                return true;
            }

            if (typeof(T) == typeof(char))
            {
                return true;
            }

            return false;
        }
    }
}
