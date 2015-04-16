namespace Infestation
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Parasite : InfestUnit
    {

        const int ParasitePower = 1;
        const int ParasiteAggression = 1;
        const int ParasiteHealth = 1;

        public Parasite(string id) :
            base(id, UnitClassification.Biological, Parasite.ParasiteHealth, Parasite.ParasitePower, Parasite.ParasitePower)
        {
        }
        protected override bool CanAttackUnit(UnitInfo unit)
        {
             bool attackUnit = false;
             if (this.Id != unit.Id)
             {
                 attackUnit = true;
             }

             return attackUnit;
        }
        protected override UnitInfo GetOptimalAttackableUnit(System.Collections.Generic.IEnumerable<UnitInfo> attackableUnits)
        {
            //This method finds the unit with the least health and attacks it
            UnitInfo optimalAttackableUnit = new UnitInfo(null, UnitClassification.Unknown, 0, int.MaxValue, 0);

            foreach (var unit in attackableUnits)
            {
                if (unit.Health < optimalAttackableUnit.Health)
                {
                    optimalAttackableUnit = unit;
                }
            }

            return optimalAttackableUnit;
        }
        public override Interaction DecideInteraction(System.Collections.Generic.IEnumerable<UnitInfo> units)
        {
            IEnumerable<UnitInfo> infensibleUnits = units.Where((unit) => this.CanAttackUnit(unit));

            UnitInfo optimalInfensibleUnit = GetOptimalAttackableUnit(infensibleUnits);

            if (optimalInfensibleUnit.Id != null)
            {
                return new Interaction(new UnitInfo(this), optimalInfensibleUnit, InteractionType.Infest);
            }

            return Interaction.PassiveInteraction;
        }

    }


}

