


namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using ArmyOfCreatures.Logic.Specialties;
    using System.Globalization;
    public class AddAttackWhenSkip:Specialty
    {
        private int attackToAdd;
        public AddAttackWhenSkip(int attackToAdd):base()
        {
            if (attackToAdd < 0 || attackToAdd > 10)
            {
                throw new ArgumentOutOfRangeException("The number of round should be greather than 0 and less or equal to 10 ");
            }

            this.attackToAdd = attackToAdd;
        }

        public override void ApplyOnSkip(Logic.Battles.ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature");
            }

            skipCreature.PermanentAttack += this.attackToAdd;
           
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.attackToAdd);
        }
    }
}
