using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class BunchOfBalloons : AccessoryItem {
        protected override AccessoryEffect[] Effects => new AccessoryEffect[] {
            AccessoryEffect.FartInABalloon,
            AccessoryEffect.HoneyBalloon,
            AccessoryEffect.SharkronBalloon
        };

        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Accessories.BunchOfBalloons}";

        protected override string TooltipTranslation =>
            "{$Mods.QualityOfLifeRecipes.General.JumpThreeTimes}" + "\n" +
                "{$ItemTooltip.ShinyRedBalloon}" + "\n" +
                "{$ItemTooltip.HoneyComb}";

        protected override int SellPrice => Item.sellPrice(0, 8, 0, 0);

        protected override int Rarity => ItemRarityID.Pink;

        protected override Ingredient[] Ingredients => new Ingredient[] {
            new(ItemID.FartInABalloon),
            new(ItemID.HoneyBalloon),
            new(ItemID.SharkronBalloon),
        };
    }
}
