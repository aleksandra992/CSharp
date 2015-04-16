


namespace Infestation
{
    using System;
    public class InfestUnit:Unit   
    {
       public InfestUnit(string id, UnitClassification unitType, int health, int power, int aggression)
           :base(id,unitType,health,power,aggression)
        {

        }
    }
}
