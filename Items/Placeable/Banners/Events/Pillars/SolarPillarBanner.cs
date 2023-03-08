using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events.Pillars {
    public class SolarPillarBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault(Language.GetTextValue("Mods.QualityOfLifeRecipes.Placeable.Banners.Events.Pillars.SolarPillarBanner_Name"));
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Corite, Crawltipede, Drakomire, Drakomire Rider, Solenian, Sroller");
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
            Item.createTile = ModContent.TileType<Tiles.Banners.Events.Pillars.SolarPillarBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SolarCoriteBanner);
            recipe.AddIngredient(ItemID.SolarCrawltipedeBanner);
            recipe.AddIngredient(ItemID.SolarDrakomireBanner);
            recipe.AddIngredient(ItemID.SolarDrakomireRiderBanner);
            recipe.AddIngredient(ItemID.SolarSolenianBanner);
            recipe.AddIngredient(ItemID.SolarSrollerBanner);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
