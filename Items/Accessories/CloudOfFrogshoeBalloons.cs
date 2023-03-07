using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class CloudOfFrogshoeBalloons : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Cloud of Frogshoe Balloons");
            Tooltip.SetDefault(
                Language.GetTextValue("ItemTooltip.FrogLeg") + "\n" +
                Language.GetTextValue("ItemTooltip.LuckyHorseshoe") + "\n" +
                "Sextuple jump and increases jump height\n" +
                Language.GetTextValue("ItemTooltip.HoneyComb"));
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
            recipe.AddIngredient(Mod, "Frogshoe");
            recipe.AddIngredient(Mod, "CloudOfBalloons");
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
