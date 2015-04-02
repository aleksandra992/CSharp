namespace WarMachines.Machines
{
    using System;
    using System.Text;
    using WarMachines.Interfaces;
    public class Fighter : Machine, IFighter, IMachine
    {

        private bool stealthMode;

          public Fighter(string name, IPilot pilot, double attackPoints, double defensePoints,bool stealthMode)
            : base(name, pilot, attackPoints, defensePoints)
        {
            this.StealthMode = stealthMode;
            this.HealthPoints = 200;
        }
        public Fighter(string name,double attackPoints,double defensePoints,bool stealthMode):this(name,null,attackPoints,defensePoints,stealthMode)
        {

        }
        public bool StealthMode
        {
            get { return this.stealthMode; }
            protected set
            {
                this.stealthMode = value;
            }
        }

        public void ToggleStealthMode()
        {

            this.StealthMode = !this.StealthMode;
         

        }

        public override string ToString()
        {

            StringBuilder fighter = new StringBuilder();
            fighter.Append(string.Format("\n *Stealth: {0}", this.StealthMode==true?"ON":"OFF"));
            return base.ToString() + fighter.ToString();
        }


    }
}
