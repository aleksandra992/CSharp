namespace Infestation
{
    using System;

    public class Marine:Human
    {
       
        public Marine(string id):base(id)
        {
            this.AddSupplement(new WeaponrySkill());
        }

        public override void AddSupplement(ISupplement newSupplement)
        {
            if (newSupplement is Weapon)
            {
                base.AddSupplement(new Weapon(10, 3));
            }
            else
                base.AddSupplement(newSupplement);
        }
     
        protected override UnitInfo GetOptimalAttackableUnit(System.Collections.Generic.IEnumerable<UnitInfo> attackableUnits)
        {
            UnitInfo optimalAttackableUnit = new UnitInfo(null, UnitClassification.Unknown, 0, int.MinValue, 0);

            foreach (var unit in attackableUnits)
            {
                if (unit.Health > optimalAttackableUnit.Health)
                {
                    optimalAttackableUnit = unit;
                }
            }

            return optimalAttackableUnit;
        }
    }
}
