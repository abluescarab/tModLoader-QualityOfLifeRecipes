using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Slimes {
    public class UltimateSlimeBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Ultimate Slime Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Sand Slime, Ice Slime, Jungle Slime, Lava Slime, Spiked Slime,\n" +
                "Green Slime, Blue Slime, Purple Slime, Red Slime, Yellow Slime, Black Slime");
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 0, 35, 0);
            item.rare = 2;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("UltimateSlimeBanner");
            item.placeStyle = 0;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "ElementalSlimeBanner");
            recipe.AddIngredient(mod, "SupremeSlimeBanner");
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
