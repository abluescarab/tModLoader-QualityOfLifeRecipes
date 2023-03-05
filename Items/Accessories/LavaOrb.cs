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
            Item.value = Item.sellPrice(0, 10, 0, 0);
            Item.rare = ItemRarityID.LightRed;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            // lava charm
            player.lavaMax += 420;
            // obsidian rose
            player.lavaRose = true;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.LavaCharm);
            recipe.AddIngredient(ItemID.ObsidianRose);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
