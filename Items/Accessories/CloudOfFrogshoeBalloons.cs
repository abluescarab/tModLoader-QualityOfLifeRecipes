using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class CloudOfFrogshoeBalloons : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("{$Mods.QualityOfLifeRecipes.Accessories.CloudOfFrogshoeBalloons}");
            Tooltip.SetDefault(
                "{$ItemTooltip.FrogLeg}" + "\n" +
                "{$ItemTooltip.LuckyHorseshoe}" + "\n" +
                "{$Mods.QualityOfLifeRecipes.General.JumpSixTimes}" + "\n" +
                "{$ItemTooltip.ShinyRedBalloon}" + "\n" +
                "{$ItemTooltip.HoneyComb}");
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 13, 0, 0);
            Item.rare = ItemRarityID.Red;
            Item.accessory = true;
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
            player.hasJumpOption_Fart = true;
            // honey balloon
            player.jumpBoost = true;
            player.honeyCombItem = Item;
            // sharkron balloon
            player.hasJumpOption_Sail = true;
            // bundle of balloons
            player.hasJumpOption_Cloud = true;
            player.hasJumpOption_Sandstorm = true;
            player.hasJumpOption_Blizzard = true;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Frogshoe>();
            recipe.AddIngredient<CloudOfBalloons>();
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
