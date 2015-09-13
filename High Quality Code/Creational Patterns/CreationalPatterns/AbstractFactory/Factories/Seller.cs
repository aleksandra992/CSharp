namespace AbstractFactory.Factories
{
    using AbstractFactory.Computers;

    public abstract class Seller
    {
        public abstract HP SaleHP();

        public abstract Toshiba SaleToshiba();
    }
}
