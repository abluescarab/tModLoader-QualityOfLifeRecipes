using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class HeavyDutyToolbox : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Heavy-Duty Toolbox");
            Tooltip.SetDefault(
                Language.GetTextValue("ItemTooltip.Toolbox") + "\n" +
                Language.GetTextValue("ItemTooltip.Toolbelt"));
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 3, 0, 0);
            Item.rare = ItemRarityID.LightRed;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            // toolbox
            if(player.whoAmI == Main.myPlayer && Item.type == ItemID.Toolbox) {
                Player.tileRangeX++;
                Player.tileRangeY++;
            }
            // toolbelt
            player.blockRange = 1;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Toolbox);
            recipe.AddIngredient(ItemID.Toolbelt);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
