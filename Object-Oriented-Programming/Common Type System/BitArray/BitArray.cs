namespace BitArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BitArray : IEnumerable<int>
    {
        //private ulong number;
        private List<byte> numberAsArray;

        public BitArray(ulong number)
        {

            this.numberAsArray = Convert(number);
            foreach (var item in this.numberAsArray)
            {
                if (item != 0 && item != 1)
                {
                    throw new ArgumentException("The bits can be only 1 or 0");
                }
            }
        }

        public List<byte> NumberAsArray
        {
            get
            {
                return new List<byte>(this.numberAsArray);
            }

        }

        public static List<byte> Convert(ulong number)
        {
            List<byte> result = new List<byte>();
            while (number != 0)
            {
                result.Add((byte)(number % 10));
                number /= 10;
            }
            return result.AsEnumerable().Reverse().ToList();

        }


        public IEnumerator<int> GetEnumerator()
        {
            foreach (var bit in this.NumberAsArray)
            {
                yield return bit;

            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            BitArray array = obj as BitArray;
            if (this.numberAsArray.Count != array.numberAsArray.Count)
            {
                return false;
            }
            else
                for (int i = 0; i < array.numberAsArray.Count; i++)
                {
                    if (array.numberAsArray[i] != this.numberAsArray[i])
                    {
                        return false;
                    }
                }
            return true;
        }
        public override int GetHashCode()
        {
            return this.numberAsArray.GetHashCode() + this.numberAsArray.Count.GetHashCode();
        }

        public int this[int index]
        {
            get
            {
                if (index > this.numberAsArray.Count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index");
                }
                return this.numberAsArray[index];
            }
            set
            {
                if (index > this.numberAsArray.Count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index");
                }
                if (value != 0 && value != 1)
                {
                    throw new ArgumentException("The bits can be 1 or 0 only");
                }
                this.numberAsArray[index] = (byte)value;
            }
        }
    

    public static bool operator==(BitArray array1,BitArray array2)
    {
        return array1.Equals(array2);
    }

    public static bool operator !=(BitArray array1, BitArray array2)
    {
        return !(array1.Equals(array2));
    }
    public override string ToString()
    {
        return string.Join("", this.NumberAsArray);
    }
    }
}
