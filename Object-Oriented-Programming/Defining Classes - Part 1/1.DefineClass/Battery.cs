using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DefineClass
{
    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }
    class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be empty");
                }
                this.model = value;
            }



        }
        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;

            }
            set
            {
                this.hoursIdle = value;
            }
        }
        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }


        public Battery(string model)
        {
            this.model = model;


        }
        public Battery(string model, int hoursIdle, int hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;

        }
        public override string ToString()
        {
            return "The model of the battery is " + this.model + " and it has " + this.HoursIdle + " hours of Idle and " + this.hoursTalk + "hours of talk";
        }
    }
}
