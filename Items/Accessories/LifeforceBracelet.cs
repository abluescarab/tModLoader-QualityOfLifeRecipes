using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class LifeforceBracelet : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Lifeforce Bracelet");
            Tooltip.SetDefault(
                Language.GetTextValue("ItemTooltip.CharmofMyths") + "\n" +
                Language.GetTextValue("ItemTooltip.ManaRegenerationBand"));
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 5, 0, 0);
            Item.rare = ItemRarityID.Lime;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            // charm of myths
            player.pStone = true;
            // mana regeneration band
            player.statManaMax2 += 20;
            player.manaRegenDelayBonus++;
            player.manaRegenBonus += 25;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.CharmofMyths);
            recipe.AddIngredient(ItemID.ManaRegenerationBand);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
