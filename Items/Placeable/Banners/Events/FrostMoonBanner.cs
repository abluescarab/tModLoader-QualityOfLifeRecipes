using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class FrostMoonBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Frost Moon Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Present Mimic, Flocko, Gingerbread Man, Zombie Elf, Elf Archer,\n" +
                "Nutcracker, Yeti, Elf Copter, Krampus");
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
            Item.createTile = ModContent.TileType < Tiles.Banners.Events.FrostMoonBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.PresentMimicBanner);
            recipe.AddIngredient(ItemID.FlockoBanner);
            recipe.AddIngredient(ItemID.GingerbreadManBanner);
            recipe.AddIngredient(ItemID.ZombieElfBanner);
            recipe.AddIngredient(ItemID.ElfArcherBanner);
            recipe.AddIngredient(ItemID.NutcrackerBanner);
            recipe.AddIngredient(ItemID.YetiBanner);
            recipe.AddIngredient(ItemID.ElfCopterBanner);
            recipe.AddIngredient(ItemID.KrampusBanner);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
