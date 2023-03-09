using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class ElementalNinjaBoots : AccessoryItem {
        protected override AccessoryEffect[] Effects => new AccessoryEffect[] {
            AccessoryEffect.TerrasparkBoots,
            AccessoryEffect.FrogFlipper,
            AccessoryEffect.MasterNinjaGear
        };

        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Accessories.ElementalNinjaBoots}";

        protected override string TooltipTranslation =>
            "{$ItemTooltip.TerrasparkBoots}" + "\n" +
            "{$ItemTooltip.FrogFlipper}" + "\n" +
            "{$ItemTooltip.MasterNinjaGear}";

        protected override int SellPrice => Item.sellPrice(0, 25, 0, 0);

        protected override int Rarity => ItemRarityID.Cyan;

        protected override Ingredient[] Ingredients => new Ingredient[] {
            new(ItemID.TerrasparkBoots),
            new(ModContent.ItemType<NinjaFrogGear>()),
        };
    }
}
