namespace Infestation
{
    using System;

    public class InfestationSpores : Supplement, ISupplement
    {
        const int PowerEffectInfestation = -1;
       
        const int AggresionEffectWInfestation = 20;
        public InfestationSpores(int healthEffect=0)
            :base(InfestationSpores.PowerEffectInfestation,healthEffect,InfestationSpores.AggresionEffectWInfestation)
        {

        }
       
    }
}
