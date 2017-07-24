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
            item.value = Item.sellPrice(0, 15, 0, 0);
            item.rare = 7;
            item.accessory = true;
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
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CharmofMyths);
            recipe.AddIngredient(ItemID.ManaRegenerationBand);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
