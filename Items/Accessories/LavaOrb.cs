using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class LavaOrb : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Lava Orb");
            Tooltip.SetDefault(
                Language.GetTextValue("ItemTooltip.LavaCharm") + "\n" +
                Language.GetTextValue("ItemTooltip.ObsidianRose"));
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.rare = 4;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            // lava charm
            player.lavaMax += 420;
            // obsidian rose
            player.lavaRose = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LavaCharm);
            recipe.AddIngredient(ItemID.ObsidianRose);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
