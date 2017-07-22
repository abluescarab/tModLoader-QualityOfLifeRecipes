using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class HeavyDutyToolbox : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Heavy-Duty Toolbox");
            Tooltip.SetDefault(
                "Increases item placement and tool range by 1\n" +
                "Increases block placement range");
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.rare = 4;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            // toolbox
            if(player.whoAmI == Main.myPlayer && item.type == 1923) {
                Player.tileRangeX++;
                Player.tileRangeY++;
            }
            // toolbelt
            player.blockRange = 1;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Toolbox);
            recipe.AddIngredient(ItemID.Toolbelt);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
