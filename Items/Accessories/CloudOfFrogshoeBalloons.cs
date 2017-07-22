using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class CloudOfFrogshoeBalloons : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Cloud of Frogshoe Balloons");
            Tooltip.SetDefault(
                "Increases jump speed and allows auto-jump\n" +
                "Increases fall resistance\n" +
                "Negates fall damage\n" +
                "Sextuple jump and increases jump height\n" +
                "Releases bees when damaged");
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 15, 0, 0);
            item.rare = 10;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            // frog leg
            player.autoJump = true;
            player.jumpSpeedBoost += 2.4f;
            player.extraFall += 15;
            // lucky horseshoe
            player.noFallDmg = true;

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
            recipe.AddIngredient(mod, "Frogshoe");
            recipe.AddIngredient(mod, "CloudOfBalloons");
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
