using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class AtomicNinjaBoots : AccessoryItem {
        protected override AccessoryEffect[] Effects => new AccessoryEffect[] {
            AccessoryEffect.TerrasparkBoots,
            AccessoryEffect.FrogFlipper,
            AccessoryEffect.MasterNinjaGear,
            AccessoryEffect.FlowerBoots
        };

        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Accessories.AtomicNinjaBoots}";

        protected override string TooltipTranslation =>
            "{$ItemTooltip.TerrasparkBoots}" + "\n" +
                "{$ItemTooltip.FrogFlipper}" + "\n" +
                "{$ItemTooltip.MasterNinjaGear}" + "\n" +
                "{$ItemTooltip.FlowerBoots}";

        protected override int SellPrice => Item.sellPrice(0, 29, 0, 0);

        protected override int Rarity => ItemRarityID.Purple;

        protected override Ingredient[] Ingredients => new Ingredient[] {
            new(ModContent.ItemType<ElementalNinjaBoots>()),
            new(ItemID.FlowerBoots),
        };
    }
}
