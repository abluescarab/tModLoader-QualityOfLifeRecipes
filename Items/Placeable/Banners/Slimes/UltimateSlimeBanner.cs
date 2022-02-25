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
            Item.value = Item.sellPrice(0, 0, 35, 0);
            Item.rare = ItemRarityID.Green;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType < Tiles.Banners.Slimes.UltimateSlimeBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(Mod, "ElementalSlimeBanner");
            recipe.AddIngredient(Mod, "SupremeSlimeBanner");
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
