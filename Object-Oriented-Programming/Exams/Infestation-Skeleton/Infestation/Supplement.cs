using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public abstract class Supplement : ISupplement
    {
        private int powerEffect;
        private int healthEffect;
        private int aggressionEffect;

        public Supplement(int powerEffect, int healthEffect, int aggressionEffect)
        {
            this.powerEffect = powerEffect;
            this.healthEffect = healthEffect;
            this.aggressionEffect = aggressionEffect;

        }


        public virtual int PowerEffect
        {
            get { return this.powerEffect; }
            protected set
            {
                this.powerEffect = value;
            }
        }

        public virtual int HealthEffect
        {
            get { return this.healthEffect; }
            protected set
            {

                this.healthEffect = value;
            }

        }

        public virtual int AggressionEffect
        {
            get { return this.aggressionEffect; }
            protected set
            {

                this.aggressionEffect = value;
            }
        }

        public virtual void  ReactTo(ISupplement otherSupplement)
        {
            this.AggressionEffect += otherSupplement.AggressionEffect;
           
        }

    }
}
