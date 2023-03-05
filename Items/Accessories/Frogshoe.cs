using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class Frogshoe : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Frogshoe");
            Tooltip.SetDefault(
                Language.GetTextValue("ItemTooltip.FrogLeg") + "\n" +
                Language.GetTextValue("ItemTooltip.LuckyHorseshoe"));
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.rare = ItemRarityID.Green;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            // frog leg
            player.autoJump = true;
            player.jumpSpeedBoost += 2.4f;
            player.extraFall += 15;
            // lucky horseshoe
            player.noFallDmg = true;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.FrogLeg);
            recipe.AddIngredient(ItemID.LuckyHorseshoe);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
