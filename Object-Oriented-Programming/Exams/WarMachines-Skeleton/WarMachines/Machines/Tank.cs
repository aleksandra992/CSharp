namespace WarMachines.Machines
{
    using System;
    using System.Text;
    using WarMachines.Interfaces;
    public class Tank : Machine, ITank, IMachine
    {
        private bool defenseMode;

        public Tank(string name, IPilot pilot, double attackPoints, double defensePoints)
            : base(name, pilot, attackPoints, defensePoints)
        {
            this.AttackPoints -= 40;
            this.DefensePoints += 30;
            this.DefenseMode = true;
            this.HealthPoints = 100;
        }
        public Tank(string name,double attackPoints,double defensePoints)
            :this(name,null,attackPoints,defensePoints)
        {

        }
      
        public bool DefenseMode
        {
            get { return this.defenseMode; }
            private set{
                this.defenseMode = value;
            }
        }

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;
            if (this.DefenseMode == true)
            {
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
            }
            else
            {
                this.DefensePoints -=30;
                this.AttackPoints += 40;
            }
        }
        public override string ToString()
        {
            StringBuilder tank = new StringBuilder();
            tank.Append(string.Format("\n *Defense: {0}", this.DefenseMode==true?"ON":"OFF"));
            return base.ToString() + tank.ToString();

        }
    }
}
