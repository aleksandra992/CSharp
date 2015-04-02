namespace WarMachines.Machines
{
    using System;
    using WarMachines.Interfaces;
    using System.Collections.Generic;
    using System.Text;
    public class Machine : IMachine
    {
        // TODO: Implement all machine classes in this namespace - WarMachines.Machines

        private string name;
        private IPilot pilot;
        private double healthPoints;
        private double attackPoints;
        private double deffensePoints;

        private IList<string> targets;
        #region constructors
        public Machine(string name, IPilot pilot, double attackPoints, double deffensePoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = deffensePoints;

            this.Pilot = pilot;
            targets = new List<string>();
        }
        public Machine(string name, double attackPoints, double deffensePoints)
            : this(name, null, attackPoints, deffensePoints)
        {

        }

        #endregion
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("the name cannot be empty");
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                
                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value <= 0)
                {
                    this.healthPoints = 0;

                }
                else
                    this.healthPoints = value;


            }
        }

        public double AttackPoints
        {
            get { return this.attackPoints; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("The attack points cannot be less than zero");
                }
                this.attackPoints = value;
            }
        }

        public double DefensePoints
        {
            get
            {
                return this.deffensePoints;
            }
            protected set
            {

                if (value <= 0)
                {
                    throw new ArgumentNullException("The deffense points cannot be less than zero");
                }
                this.deffensePoints = value;

            }

        }

        public IList<string> Targets
        {
            get { return new List<string>( this.targets); }
        }

        public void Attack(string target)
        {
            this.targets.Add(target);
        }

        public override string ToString()
        {
            StringBuilder machine = new StringBuilder();
            machine.Append(string.Format("\n- {0}", this.Name));
            machine.Append(string.Format("\n *Type: {0}", this.GetType().Name));
            machine.Append(string.Format("\n *Health: {0}", this.HealthPoints));
            machine.Append(string.Format("\n *Attack: {0}", this.AttackPoints));
            machine.Append(string.Format("\n *Defense: {0}", this.deffensePoints));
            machine.Append(string.Format("\n *Targets: {0}", this.Targets.Count == 0 ? "None" : string.Join(", ", this.Targets)));
            return machine.ToString();
        }
    }
}
