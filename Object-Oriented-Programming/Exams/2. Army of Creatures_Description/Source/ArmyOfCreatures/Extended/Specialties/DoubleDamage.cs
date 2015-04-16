namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using ArmyOfCreatures.Logic.Specialties;
    using System.Globalization;
using ArmyOfCreatures.Logic.Battles;
    public class DoubleDamage : Specialty
    {
        
        private int numberOfRounds;
        public DoubleDamage(int numberOfRounds)
            : base()
        {
            if (numberOfRounds < 0 || numberOfRounds > 10)
            {
                throw new ArgumentOutOfRangeException("The number of round should be greather than 0 and less or equal to 10 ");
            }

            this.numberOfRounds = numberOfRounds;
        }
        
        public override decimal ChangeDamageWhenAttacking(Logic.Battles.ICreaturesInBattle attackerWithSpecialty, Logic.Battles.ICreaturesInBattle defender, decimal currentDamage)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }

            if (numberOfRounds <= 0)
            {
                return currentDamage;
            }
            else
            {
                this.numberOfRounds--;
                return currentDamage * 2;
                
            }
           

           
            

            
        }

        

        public override string ToString()
        {
            
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.numberOfRounds);
        }
       
    }
}
