using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class SupremeSolarEclipseBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Supreme Solar Eclipse Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against:\n" +
                "Frankenstein, Swamp Thing, Vampire, Creature from the Deep, Fritz, The Possessed\n" +
                "Eyezor, Reaper, Butcher, Deadly Sphere, Dr. Man Fly, Nailhead, Psycho");
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 0, 30, 0);
            item.rare = 2;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("SupremeSolarEclipseBanner");
            item.placeStyle = 0;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SolarEclipseBanner"));
            recipe.AddIngredient(ItemID.EyezorBanner);
            recipe.AddIngredient(ItemID.ReaperBanner);
            recipe.AddIngredient(ItemID.ButcherBanner);
            recipe.AddIngredient(ItemID.DeadlySphereBanner);
            recipe.AddIngredient(ItemID.DrManFlyBanner);
            recipe.AddIngredient(ItemID.NailheadBanner);
            recipe.AddIngredient(ItemID.PsychoBanner);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
