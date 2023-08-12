using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class FrostMoonBanner : BannerItem<FrostMoonBanner, Tiles.Banners.Events.FrostMoonBanner> {
        protected override int SellPrice => Item.sellPrice(0, 0, 15, 0);

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.PresentMimicBanner),
                new(ItemID.FlockoBanner),
                new(ItemID.GingerbreadManBanner),
                new(ItemID.ZombieElfBanner),
                new(ItemID.ElfArcherBanner),
                new(ItemID.NutcrackerBanner),
                new(ItemID.YetiBanner),
                new(ItemID.ElfCopterBanner),
                new(ItemID.KrampusBanner)
            );
        }
    }
}
