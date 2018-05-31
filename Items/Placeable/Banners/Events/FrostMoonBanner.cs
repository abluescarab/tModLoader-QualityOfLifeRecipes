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
            item.value = Item.sellPrice(0, 0, 15, 0);
            item.rare = 2;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("FrostMoonBanner");
            item.placeStyle = 0;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
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
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
