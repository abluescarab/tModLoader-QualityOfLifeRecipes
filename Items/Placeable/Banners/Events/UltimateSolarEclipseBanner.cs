using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class UltimateSolarEclipseBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Ultimate Solar Eclipse Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Frankenstein, Swamp Thing, Vampire, Creature from the Deep, Fritz,\n" +
                "The Possessed, Eyezor, Reaper, Butcher, Deadly Sphere, Dr. Man Fly, Nailhead, Psycho, Mothron");
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
            Item.createTile = ModContent.TileType < Tiles.Banners.Events.UltimateSolarEclipseBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.TileType < Tiles.Banners.Events.SupremeSolarEclipseBanner>());
            recipe.AddIngredient(ItemID.MothronBanner);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
