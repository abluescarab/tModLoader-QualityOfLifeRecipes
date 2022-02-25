using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners {
    public class UndeadBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Undead Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Zombie, Raincoat Zombie, Demon Eye");
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 0, 5, 0);
            Item.rare = ItemRarityID.Green;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType < Tiles.Banners.UndeadBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.ZombieBanner);
            recipe.AddIngredient(ItemID.DemonEyeBanner);
            recipe.AddIngredient(ItemID.RaincoatZombieBanner);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
