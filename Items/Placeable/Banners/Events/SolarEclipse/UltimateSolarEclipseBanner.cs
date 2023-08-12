using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events.SolarEclipse {
    public class UltimateSolarEclipseBanner : BannerItem<UltimateSolarEclipseBanner, Tiles.Banners.Events.SolarEclipse.UltimateSolarEclipseBanner> {
        protected override int SellPrice => Item.sellPrice(0, 0, 35, 0);

        public override void AddRecipes() {
            AddRecipe(
                new(ModContent.ItemType<SupremeSolarEclipseBanner>()),
                new(ItemID.MothronBanner)
            );
        }
    }
}
