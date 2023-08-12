using Terraria;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Slimes {
    public class UltimateSlimeBanner : BannerItem<UltimateSlimeBanner, Tiles.Banners.Slimes.UltimateSlimeBanner> {
        protected override int SellPrice => Item.sellPrice(0, 0, 35, 0);

        public override void AddRecipes() {
            AddRecipe(
                new(ModContent.ItemType<ElementalSlimeBanner>()),
                new(ModContent.ItemType<SupremeSlimeBanner>())
            );
        }
    }
}
