using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class PumpkinMoonBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Pumpkin Moon Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Scarecrow, Splinterling, Hellhound, Poltergeist, Headless Horseman");
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 0, 12, 0);
            Item.rare = ItemRarityID.Green;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType < Tiles.Banners.Events.PumpkinMoonBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.ScarecrowBanner);
            recipe.AddIngredient(ItemID.SplinterlingBanner);
            recipe.AddIngredient(ItemID.HellhoundBanner);
            recipe.AddIngredient(ItemID.PoltergeistBanner);
            recipe.AddIngredient(ItemID.HeadlessHorsemanBanner);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
