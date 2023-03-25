using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class EnchantedNinjaFrogGear : AccessoryItem {
        protected override AccessoryEffect[] Effects => new AccessoryEffect[] {
            AccessoryEffect.FrogFlipper,
            AccessoryEffect.MasterNinjaGear,
            AccessoryEffect.Magiluminescence
        };

        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Accessories.EnchantedNinjaFrogGear}";

        protected override string TooltipTranslation =>
            "{$ItemTooltip.FrogFlipper}\n" +
            "{$ItemTooltip.MasterNinjaGear}\n" +
            "{$ItemTooltip.Magiluminescence}";

        protected override int SellPrice => Item.sellPrice(0, 0, 13, 0);

        protected override int Rarity => ItemRarityID.Yellow;

        public override void AddRecipes() {
            AddRecipe(
                new(ModContent.ItemType<NinjaFrogGear>()),
                new(ItemID.Magiluminescence)
            );
        }
    }
}
