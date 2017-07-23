using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events.Pillars {
    public class SolarPillarBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Solar Pillar Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Corite, Crawltipede, Drakomire, Drakomire Rider, Solenian, Sroller");
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
            item.createTile = mod.TileType("SolarPillarBanner");
            item.placeStyle = 0;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SolarCoriteBanner);
            recipe.AddIngredient(ItemID.SolarCrawltipedeBanner);
            recipe.AddIngredient(ItemID.SolarDrakomireBanner);
            recipe.AddIngredient(ItemID.SolarDrakomireRiderBanner);
            recipe.AddIngredient(ItemID.SolarSolenianBanner);
            recipe.AddIngredient(ItemID.SolarSrollerBanner);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
