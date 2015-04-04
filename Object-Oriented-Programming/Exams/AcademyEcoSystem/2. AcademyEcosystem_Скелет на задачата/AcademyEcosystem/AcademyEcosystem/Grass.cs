namespace AcademyEcosystem
{
    using System;
    public class Grass:Plant
    {
        private const int sizePlant = 2;
        public Grass(Point location):base(location,sizePlant)
        {

        }
        public override void Update(int time)
        {
            if (this.IsAlive == true)
            {
                this.Size += time;
            }
            base.Update(time);
        }
    }
}
