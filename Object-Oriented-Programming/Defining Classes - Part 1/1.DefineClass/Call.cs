using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DefineClass
{
    class Call
    {
        // It should contain date, time, dialled phone number and duration (in seconds).
        private DateTime date = new DateTime();
        private string dialledPhone;
        private double duration;

        public Call(DateTime date, string dialledPhone, double duration)
        {
            this.date = date;
            this.dialledPhone = dialledPhone;
            this.duration = duration;
        }

        public DateTime Date
        {
            get
            {
                if (this.date.Equals(null))
                {
                    throw new ArgumentNullException();
                }
                return date;
            }
            set
            {
                this.date = value;
            }
        }
        public string DialledPhone
        {
            get
            {
                return this.dialledPhone;
            }
            set
            {
                this.dialledPhone = value;
            }
        }
        public double Duration
        {
            get
            {
                return this.duration;
            }
            set { this.duration = value; }
        }
        public override string ToString()
        {
            return "The call was on " + this.Date.ToString() +
                " with duration " + this.Duration +
                " seconds and the dialled number was " + this.DialledPhone;
        }
    }
}