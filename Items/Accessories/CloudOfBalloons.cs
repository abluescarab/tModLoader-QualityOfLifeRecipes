using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class CloudOfBalloons : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Cloud of Balloons");
            Tooltip.SetDefault(
                "Sextuple jump and increases jump height\n" +
                Language.GetTextValue("ItemTooltip.HoneyComb"));
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.rare = 9;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            player.jumpBoost = true;

            // fart in a balloon
            player.doubleJumpFart = true;
            // honey balloon
            player.bee = true;
            // sharkron balloon
            player.doubleJumpSail = true;
            // bundle of balloons
            player.doubleJumpCloud = true;
            player.doubleJumpSandstorm = true;
            player.doubleJumpBlizzard = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "BunchOfBalloons");
            recipe.AddIngredient(ItemID.BundleofBalloons);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
