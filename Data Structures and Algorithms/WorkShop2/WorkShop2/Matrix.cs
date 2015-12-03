namespace WorkShop2
{
   public class Matrix
    {
        private const int Module = 1000000007;

        public long[,] Table { get; set; }

        public Matrix(Matrix a, Matrix b)
        {
            this.Table = new long[2, 2];

            this.Table[0, 0] = a.Table[0, 0] * b.Table[0, 0] +
                               a.Table[0, 1] * b.Table[1, 0];

            this.Table[0, 1] = a.Table[0, 0] * b.Table[0, 1] +
                               a.Table[0, 1] * b.Table[1, 1];

            this.Table[1, 0] = a.Table[1, 0] * b.Table[0, 0] +
                               a.Table[1, 1] * b.Table[1, 0];

            this.Table[1, 1] = a.Table[1, 0] * b.Table[0, 1] +
                               a.Table[1, 1] * b.Table[1, 1];

            this.Table[0, 0] %= Module;
            this.Table[0, 1] %= Module;
            this.Table[1, 0] %= Module;
            this.Table[1, 1] %= Module;
        }

        public Matrix(long a, long b, long c, long d)
        {
            this.Table = new long[2, 2];

            this.Table[0, 0] = a;
            this.Table[0, 1] = b;
            this.Table[1, 0] = c;
            this.Table[1, 1] = d;
        }
    }
}
