


namespace Infestation
{
    using System;
    public class Weapon : Supplement, ISupplement
    {



        public Weapon(int powerEffect = 0, int aggressionEffect = 0)
            : base(powerEffect, 0, aggressionEffect)
        {

        }
    }
       
}
