namespace Infestation
{
    using System;
    public class PowerCatalyst:Catalyst
    {
        const int PowerEffectPowerCatalyst = 3;
        public PowerCatalyst(int healthEffect=0,int aggressionEffect=0):base(PowerCatalyst.PowerEffectPowerCatalyst,healthEffect,aggressionEffect)
        {

        }
    }
}
