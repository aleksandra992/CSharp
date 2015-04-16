namespace Infestation
{
    using System;
    using System.Linq;
using System.Collections.Generic;

    public class Queen:InfestUnit
    {
        const int QueenPower = 1;
        const int QueenAggression = 1;
        const int QueenHealth = 30;

        public Queen(string id) :
            base(id, UnitClassification.Psionic, Queen.QueenHealth, Queen.QueenPower, Queen.QueenHealth)
        {

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
