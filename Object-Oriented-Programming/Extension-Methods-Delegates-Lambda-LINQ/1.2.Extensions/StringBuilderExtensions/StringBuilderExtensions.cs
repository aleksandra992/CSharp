namespace Extensions.StringBuilderExtensions
{
    using System;
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            result.Append(str.ToString().Substring(index, length));
            return result;
        }
    }
}
