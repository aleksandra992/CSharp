


namespace ArmyOfCreatures.Extended.Specialties
{
    using ArmyOfCreatures.Logic.Specialties;
    using System;
    using System.Globalization;
    public class DoubleAttackWhenAttacking:Specialty
    {
        private int numberOfRounds;
        public DoubleAttackWhenAttacking(int numberOfRounds):base()
        {
            if (numberOfRounds <= 0)
            {
                throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be greater than 0");
            }
            this.numberOfRounds = numberOfRounds;

        }

        
        public override void ApplyWhenAttacking(Logic.Battles.ICreaturesInBattle attackerWithSpecialty, Logic.Battles.ICreaturesInBattle defender)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }
            if (this.numberOfRounds <= 0)
            {
                return;
            }
            else
            {
                attackerWithSpecialty.CurrentAttack *= 2;
                this.numberOfRounds--;
            }
           

           
        }
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.numberOfRounds);
        }
        
        
    }
}
