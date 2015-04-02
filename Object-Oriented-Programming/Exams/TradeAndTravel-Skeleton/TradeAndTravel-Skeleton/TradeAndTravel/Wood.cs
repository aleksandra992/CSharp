namespace TradeAndTravel
{
    using System;
    public class Wood : Item
    {
        const int generalWoodValue = 2;
        public Wood(string name, Location location = null)
            : base(name, generalWoodValue, ItemType.Wood, location)
        {
            
        }

       
        public override void UpdateWithInteraction(string interaction)
        {
            
            if (interaction == "drop")
            {
                if (this.Value <=0)
                {
                    this.Value = 0;
                }
                else
                this.Value -= 1;
            }
        }
    }
}
