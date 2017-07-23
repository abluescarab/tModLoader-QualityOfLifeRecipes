using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Slimes {
    public class SupremeSlimeBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Supreme Slime Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Green/Blue/Purple/Red/Yellow/Black Slime");
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 0, 15, 0);
            item.rare = 2;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("SupremeSlimeBanner");
            item.placeStyle = 0;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GreenSlimeBanner);
            recipe.AddIngredient(ItemID.SlimeBanner);
            recipe.AddIngredient(ItemID.PurpleSlimeBanner);
            recipe.AddIngredient(ItemID.RedSlimeBanner);
            recipe.AddIngredient(ItemID.YellowSlimeBanner);
            recipe.AddIngredient(ItemID.BlackSlimeBanner);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
