using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events.SolarEclipse {
    public class SolarEclipseBanner : BannerItem<SolarEclipseBanner, Tiles.Banners.Events.SolarEclipse.SolarEclipseBanner> {
        protected override int SellPrice => Item.sellPrice(0, 0, 15, 0);

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.FrankensteinBanner),
                new(ItemID.SwampThingBanner),
                new(ItemID.VampireBanner),
                new(ItemID.CreatureFromTheDeepBanner),
                new(ItemID.FritzBanner),
                new(ItemID.ThePossessedBanner)
            );
        }
    }
}
