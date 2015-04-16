namespace Cosmetics.Products
{
    using System;
    public static class Validate
    {

        public static void Validation(string wordToValidate,int min,int max,string validationWord)
        {
            if (wordToValidate.Length < min || wordToValidate.Length > max)
            {
                throw new ArgumentException(string.Format("{0} must be between {1} and {2} symbols long!",validationWord,min, max));
            }
        }
    }
}
