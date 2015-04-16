
namespace Infestation
{
    using System;

    public class ExtensionHoldingPen : HoldingPen
    {
        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {

            Unit unit = this.GetUnit(commandWords[2]);

            switch (commandWords[1])
            {
                case "PowerCatalyst":
                    {
                        unit.AddSupplement(new PowerCatalyst());
                        break;
                    }
                case "AggressionCatalyst":
                    {
                        unit.AddSupplement(new AggressionCatalyst());
                        break;
                    }
                case "HealthCatalyst":
                    {
                        unit.AddSupplement(new HealthCatalyst());
                        break;
                    }
                case "Weapon":
                    {
                        unit.AddSupplement(new Weapon());
                        break;
                    }
         
                default:
                    {
                        base.ExecuteAddSupplementCommand(commandWords);
                        break;

                    }

            }


        }
        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "Marine":
                    var marine = new Marine(commandWords[2]);
                    this.InsertUnit(marine);
                    break;
                case "Parasite":
                    var parasite = new Parasite(commandWords[2]);
                   

                    this.InsertUnit(parasite);
                    break;
                case "Queen":
                    var queen = new Queen(commandWords[2]);
                    this.InsertUnit(queen);
                    break;
                case "Tank":
                    var tank = new Tank(commandWords[2]);
                    this.InsertUnit(tank);
                    break;
                default:
                    {
                        base.ExecuteInsertUnitCommand(commandWords);
                        break;
                    }
            }
        }
        protected override void ProcessSingleInteraction(Interaction interaction)
        {
            switch (interaction.InteractionType)
            {
                case InteractionType.Infest:
                    {
                        Unit targetUnit = this.GetUnit(interaction.TargetUnit);
                        Unit sourceUnit = this.GetUnit(interaction.SourceUnit);

                        if (CheckUnitClassification(targetUnit, sourceUnit, UnitClassification.Biological))
                        {
                            targetUnit.AddSupplement(new InfestationSpores());
                            targetUnit.DecreaseBaseHealth(interaction.SourceUnit.Power);
                        }
                        if (CheckUnitClassification(targetUnit, sourceUnit, UnitClassification.Mechanical))
                        {
                            targetUnit.AddSupplement(new InfestationSpores());
                            targetUnit.DecreaseBaseHealth(interaction.SourceUnit.Power);
                        }
                        if (CheckUnitClassification(targetUnit, sourceUnit, UnitClassification.Psionic))
                        {
                            targetUnit.AddSupplement(new InfestationSpores());
                            targetUnit.DecreaseBaseHealth(interaction.SourceUnit.Power);
                        }
                        break;
                    }
                default:
                    {
                        base.ProcessSingleInteraction(interaction);
                        break;
                    }

            }
        }
        

        private static bool CheckUnitClassification(Unit targetUnit, Unit sourceUnit, UnitClassification classification)
        {
            if (sourceUnit.UnitClassification == classification)
            {
                if (targetUnit.UnitClassification == classification)
                {
                    return true;
                }

            }
            return false;
        }

        
    }
}
