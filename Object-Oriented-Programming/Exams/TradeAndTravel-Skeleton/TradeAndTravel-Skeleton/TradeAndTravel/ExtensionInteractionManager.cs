namespace TradeAndTravel
{
    using System;
    using System.Linq;
    public class ExtensionInteractionManager : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "armor":
                    {
                        item = base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
                        break;
                    }
                case "wood":
                    {
                        item = new Wood(itemNameString, itemLocation);
                        break;
                    }
                case "iron":
                    {
                        item = new Iron(itemNameString, itemLocation);
                        break;
                    }
                case "weapon":
                    {
                        item = new Weapon(itemNameString, itemLocation);
                        break;
                    }
                default:
                    break;
            }
            return item;

        }
        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "town":
                    {
                        location = base.CreateLocation(locationTypeString, locationName);
                        break;
                    }
                case "forest":
                    {
                        location = new Forest(locationName);
                        break;
                    }
                case "mine":
                    {
                        location = new Mine(locationName);
                        break;
                    }
            }
            return location;
        }
        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {
                case "shopkeeper":
                    {
                        person = base.CreatePerson(personTypeString, personNameString, personLocation);
                        break;
                    }
                case "traveller":
                    {
                        person = base.CreatePerson(personTypeString, personNameString, personLocation);
                        break;
                    }
                case "merchant":
                    {
                        person = new Merchant(personNameString, personLocation);
                        break;
                    }
                default:
                    break;
            }
            return person;
        }
        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    {
                        HandleGatherInteraction(commandWords, actor);
                        break;
                    }
                case "craft":
                    {
                        HandleCraftInteraction(commandWords, actor);
                        break;
                    }
                default:
                    {
                        base.HandlePersonCommand(commandWords, actor);
                        break;
                    }
            }

        }
        private void HandleGatherInteraction(string[] commandWords, Person actor)
        {
            if (actor.Location is Forest)
            {
                if (actor.ListInventory().Any(x => x is Weapon))
                {
                    Wood wood = new Wood(commandWords[2]);
                    actor.AddToInventory(wood);
                    this.ownerByItem.Add(wood,actor);
                }
            }
            else
                if (actor.Location is Mine)
                {
                    if (actor.ListInventory().Any(x => x is Armor))
                    {
                        Iron iron = new Iron(commandWords[2]);
                        actor.AddToInventory(iron);
                        this.ownerByItem.Add(iron, actor);
                    }
                }
        }

        private void HandleCraftInteraction(string[] commandWords, Person actor)
        {
            if (commandWords[2] == "weapon")
            {
                if (actor.ListInventory().Any(x => x is Iron) && actor.ListInventory().Any(x => x is Wood))
                {
                    Weapon weapon = new Weapon(commandWords[3]);
                    actor.AddToInventory(weapon);
                    this.ownerByItem.Add(weapon, actor);
                    
                }
            }
            else
                if (commandWords[2] == "armor")
                {
                    if (actor.ListInventory().Any(x => x is Iron))
                    {
                        Armor armor = new Armor(commandWords[3]);
                        actor.AddToInventory(armor);
                        this.ownerByItem.Add(armor, actor);
                    }
                }

        }
    }
}
