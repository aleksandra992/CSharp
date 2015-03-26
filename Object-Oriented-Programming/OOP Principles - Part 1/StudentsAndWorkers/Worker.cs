namespace StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private double weekSalary;
        private int workHoursPerDay;



        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("The week salary cannot be less than 0");
                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("The week salary cannot be less than 0");
                this.workHoursPerDay = value;
                
            }
        }
        public double MoneyPerHour()
        {
            return this.weekSalary /(this.WorkHoursPerDay * 5);
        }
        public override string ToString()
        {
            return base.ToString()+String.Format(" money per hour {0}",this.MoneyPerHour());
        }
    }
}
