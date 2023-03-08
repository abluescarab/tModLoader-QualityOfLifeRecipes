using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class BunchOfBalloons : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("{$Mods.QualityOfLifeRecipes.Accessories.BunchOfBalloons_Name}");
            Tooltip.SetDefault(
                "{$Mods.QualityOfLifeRecipes.General.JumpThreeTimes}" + "\n" +
                "{$ItemTooltip.ShinyRedBalloon}" + "\n" +
                "{$ItemTooltip.HoneyComb}");
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 8, 0, 0);
            Item.rare = ItemRarityID.Pink;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            player.jumpBoost = true;

            // fart in a balloon
            player.hasJumpOption_Fart = true;
            // honey balloon
            player.jumpBoost = true;
            player.honeyCombItem = Item;
            // sharkron balloon
            player.hasJumpOption_Sail = true;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.FartInABalloon);
            recipe.AddIngredient(ItemID.HoneyBalloon);
            recipe.AddIngredient(ItemID.SharkronBalloon);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
