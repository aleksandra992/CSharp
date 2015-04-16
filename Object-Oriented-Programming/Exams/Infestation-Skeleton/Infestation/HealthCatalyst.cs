using System;


namespace Infestation
{
    public class HealthCatalyst:Catalyst
    {
        const int HealthEffectHealthCatalyst=3;
        public HealthCatalyst(int powerEffect=0,int aggressionEffect=0):base(powerEffect,HealthCatalyst.HealthEffectHealthCatalyst,aggressionEffect)
        {

        }
    }
}
