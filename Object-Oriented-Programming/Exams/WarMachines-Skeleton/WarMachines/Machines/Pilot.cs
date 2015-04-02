namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using WarMachines.Interfaces;
    public class Pilot : IPilot
    {

        private string name;
        private List<IMachine> machines;
        public Pilot(string name)
        {
            this.Name = name;
            machines = new List<IMachine>();

        }

        public string Name
        {
            get { return this.name; }
            private set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public List<IMachine> Machines
        {
            get
            {
                return new List<IMachine>(this.machines);
            }
        }

        public void AddMachine(IMachine machine)
        {
            this.machines.Add(machine);
            this.machines.OrderBy(x => x.HealthPoints).ThenBy(x => x.Name).ToList();
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();
            if (this.Machines.Count == 0)
            {
                report.Append(string.Format("{0} - no machines",this.Name));
            }
            else
            {
                report.Append(string.Format("{0} - {1} {2}",this.Name,this.Machines.Count,(this.Machines.Count==1)?"machine":"machines"));
                foreach (var machine in this.Machines)
                {
                    report.Append(machine.ToString());
                    
                }
            }

            return report.ToString();

        }
       
    }
}
