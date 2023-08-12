using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class PumpkinMoonBanner : BannerItem<PumpkinMoonBanner, Tiles.Banners.Events.PumpkinMoonBanner> {
        protected override int SellPrice => Item.sellPrice(0, 0, 12, 0);

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.ScarecrowBanner),
                new(ItemID.SplinterlingBanner),
                new(ItemID.HellhoundBanner),
                new(ItemID.PoltergeistBanner),
                new(ItemID.HeadlessHorsemanBanner)
            );
        }
    }
}
