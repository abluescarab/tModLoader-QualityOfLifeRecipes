using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class ElementalNinjaBoots : AccessoryItem {
        protected override AccessoryEffect[] Effects => new AccessoryEffect[] {
            AccessoryEffect.TerrasparkBoots,
            AccessoryEffect.FrogFlipper,
            AccessoryEffect.MasterNinjaGear,
            AccessoryEffect.Magiluminescence
        };

        protected override int SellPrice => Item.sellPrice(0, 25, 0, 0);
        protected override int Rarity => ItemRarityID.Cyan;

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.TerrasparkBoots),
                new(ModContent.ItemType<EnchantedNinjaFrogGear>())
            );
        }
    }
}
