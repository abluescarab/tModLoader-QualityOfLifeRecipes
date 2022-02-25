using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Slimes {
    public class SupremeSlimeBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Supreme Slime Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Green Slime, Blue Slime, Purple Slime, Red Slime, Yellow Slime, Black Slime");
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 0, 15, 0);
            Item.rare = ItemRarityID.Green;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType < Tiles.Banners.Slimes.SupremeSlimeBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.GreenSlimeBanner);
            recipe.AddIngredient(ItemID.SlimeBanner);
            recipe.AddIngredient(ItemID.PurpleSlimeBanner);
            recipe.AddIngredient(ItemID.RedSlimeBanner);
            recipe.AddIngredient(ItemID.YellowSlimeBanner);
            recipe.AddIngredient(ItemID.BlackSlimeBanner);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
