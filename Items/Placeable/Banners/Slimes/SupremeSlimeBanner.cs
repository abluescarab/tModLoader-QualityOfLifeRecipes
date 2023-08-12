using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Slimes {
    public class SupremeSlimeBanner : BannerItem<SupremeSlimeBanner, Tiles.Banners.Slimes.SupremeSlimeBanner> {
        protected override int SellPrice => Item.sellPrice(0, 0, 15, 0);

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.GreenSlimeBanner),
                new(ItemID.SlimeBanner),
                new(ItemID.PurpleSlimeBanner),
                new(ItemID.RedSlimeBanner),
                new(ItemID.YellowSlimeBanner),
                new(ItemID.BlackSlimeBanner)
            );
        }
    }
}
