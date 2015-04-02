namespace WarMachines.Engine
{
    using System.Collections.Generic;
    using WarMachines.Interfaces;
    using WarMachines.Machines;
    using System.Linq;
    using System;

    public class MachineFactory : IMachineFactory
    {

        private IList<IPilot> pilots;
        private IList<ITank> tanks;
        private IList<IFighter> fighters;

        public MachineFactory()
        {
            pilots = new List<IPilot>();
            tanks = new List<ITank>();
            fighters = new List<IFighter>();
        }
        public IPilot HirePilot(string name)
        {
            IPilot pilot = new Pilot(name);
            var k = this.pilots.Any(x => x.Name == name);
            if (k)
            {
                throw new ArgumentException("The pilot name already exist");
            }

            this.pilots.Add(pilot);
            return pilot;
            // TODO: Implement this method
        }

        public ITank ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            ITank tank = new Tank(name, attackPoints, defensePoints);
            var k = this.tanks.Any(x => x.Name == name);
            if (k)
            {
                throw new ArgumentException("The tank name already exist");
            }
            this.tanks.Add(tank);
            return tank;
            // TODO: Implement this method
        }

        public IFighter ManufactureFighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            IFighter fighter = new Fighter(name, attackPoints, defensePoints, stealthMode);
            var k = this.fighters.Any(x => x.Name == name);
            if (k)
            {
                throw new ArgumentException("The fighter name already exist");
            }
            this.fighters.Add(fighter);
            return fighter;
            
            // TODO: Implement this method
        }
    }
}
