

using System;
namespace _3.RangeException
{
    public class InvalidRangeException<T> : Exception
    {
        private string errorMsg;
        private T start;
        private T end;
        public InvalidRangeException(string message,T start,T end)
           :this(message,start,end,null)
        {

        }
        public InvalidRangeException(string message,T start,T end,Exception ex)
            :base(message,ex)
        {
            this.Start = start;
            this.End = end;
        }
        public string ErrorMsg
        {
            get
            {
                return this.errorMsg;
            }
            set
            {
                this.errorMsg = value;
            }
        }
        public T Start
        {
            get
            {
                return this.start;
            }
            set
            {
                this.start = value;
            }
        }
        public T End
        {
            get
            {
                return this.end;
            }
            set
            {
                this.end = value;
            }
        }
    }
}
