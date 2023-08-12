using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class PirateCrewBanner : BannerItem<PirateCrewBanner, Tiles.Banners.Events.PirateCrewBanner> {
        protected override int SellPrice => Item.sellPrice(0, 0, 15, 0);

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.ParrotBanner),
                new(ItemID.PirateCaptainBanner),
                new(ItemID.PirateBanner),
                new(ItemID.PirateCorsairBanner),
                new(ItemID.PirateCrossbowerBanner),
                new(ItemID.PirateDeadeyeBanner)
            );
        }
    }
}
