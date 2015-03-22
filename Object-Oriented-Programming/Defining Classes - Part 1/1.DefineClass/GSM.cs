using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DefineClass
{
    class GSM
    {
        private string model;
        private string manifacturer;
        private decimal price;
        private string owner;
        private Battery batteryCharacteristic;
        private BatteryType batteryType;
        private Display displayCharacteristic;
        private List<Call> calls = new List<Call>();

        public static GSM iPhone4S = new GSM("Iphone 4 s", "Apple", 500, "Someone", new Battery("NiCd"), BatteryType.NiCd, new Display(5));

        public string Model
        {
            get
            {
                if (this.model.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.model;

            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The model of GSM cannot be empty");

                }
                this.model = value;


            }
        }
        public string Manifacturer
        {
            get
            {
                return this.manifacturer;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The manifacturer of GSM cannot be empty");

                }
                this.model = value;
            }
        }
        public decimal Price { get; set; }
        public string Owner { get; set; }
        public Battery BatteryCharacteristic
        {
            get
            {
                if (this.batteryCharacteristic.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.batteryCharacteristic;
            }
            set
            {
                this.BatteryCharacteristic = value;
            }
        }
        public Display DisplayCharacteristic
        {
            get
            {
                if (this.displayCharacteristic.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.displayCharacteristic;

            }
            set
            {
                this.displayCharacteristic = value;
            }
        }
        public BatteryType BatteryType {
            get
            {
                if (this.batteryType.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }

        public List<Call> CallHistory
        {
            get {
                return new List<Call>(this.calls);
            }
          
        }
        public GSM(string model, string manifacturer, decimal price, string owner, Battery bC, BatteryType batType, Display dC)
        {
            this.model = model;
            this.manifacturer = manifacturer;
            this.price = price;
            this.owner = owner;
            this.batteryCharacteristic = new Battery(bC.Model);
            this.displayCharacteristic = new Display(dC.Size);

        }
        public GSM(string model, string manifacturer)
        {
            this.model = model;
            this.manifacturer = manifacturer;


        }
        public override string ToString()
        {
            return
            "The model is " + this.model +
            "\n The manifacturer is" + this.manifacturer +
            "\nThe price is " + this.price +
          "\nThe owner is " + this.owner +
           "\n" + this.batteryCharacteristic.ToString() +
              "\n" + this.batteryType.ToString() +
              "\n" + this.displayCharacteristic.ToString();
        }
        public void AddCalls(Call c)
        {
            this.calls.Add(c);
        }
        public void DeleteCalls(Call c)
        {
            this.calls.Remove(c);
        }
        public void DeleteCallHistory()
        {
            this.calls.Clear();
        }
        public decimal Callprice(double pricePerMin)
        {
            return (decimal)(this.calls.Select(x => x.Duration).Sum())/(decimal)pricePerMin;
        }

    }
}
