using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Accessories {
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

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.FrogFlipper),
                new(ItemID.MasterNinjaGear)
            );

            AddRecipe(
                new(ItemID.FrogGear),
                new(ItemID.Tabi),
                new(ItemID.BlackBelt)
            );
        }
    }
}
