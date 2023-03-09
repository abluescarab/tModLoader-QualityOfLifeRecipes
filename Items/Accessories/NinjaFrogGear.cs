using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Accessories {
    // TODO: add icon
    public class NinjaFrogGear : AccessoryItem {
        protected override AccessoryEffect[] Effects => new AccessoryEffect[] {
            AccessoryEffect.FrogFlipper,
            AccessoryEffect.MasterNinjaGear
        };

        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Accessories.NinjaFrogGear}";

        protected override string TooltipTranslation =>
            "{$ItemTooltip.FrogFlipper}" + "\n" +
            "{$ItemTooltip.MasterNinjaGear}";

        protected override int SellPrice => Item.sellPrice(0, 0, 12, 0);

        protected override int Rarity => ItemRarityID.Yellow;

        protected override Ingredient[] Ingredients => new Ingredient[] {
            new(ItemID.FrogFlipper),
            new(ItemID.MasterNinjaGear)
        };
    }
}
