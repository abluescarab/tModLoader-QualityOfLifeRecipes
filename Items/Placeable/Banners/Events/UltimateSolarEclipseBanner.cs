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
            item.value = Item.sellPrice(0, 0, 35, 0);
            item.rare = 2;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("UltimateSolarEclipseBanner");
            item.placeStyle = 0;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SupremeSolarEclipseBanner"));
            recipe.AddIngredient(ItemID.MothronBanner);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
