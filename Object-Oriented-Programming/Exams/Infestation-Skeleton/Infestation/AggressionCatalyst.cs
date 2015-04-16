namespace Infestation
{
    using System;

    public class AggressionCatalyst:Catalyst
    {
        const int AgressionEffectAggressionCatalyst = 3;
        public AggressionCatalyst(int powerEffect=0,int healthEffect=0):base(powerEffect,healthEffect,AggressionCatalyst.AgressionEffectAggressionCatalyst)
        {

        }
    }
}
