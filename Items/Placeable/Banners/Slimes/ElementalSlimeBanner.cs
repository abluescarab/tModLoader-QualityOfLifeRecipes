using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Slimes {
    public class ElementalSlimeBanner : BannerItem<ElementalSlimeBanner, Tiles.Banners.Slimes.ElementalSlimeBanner> {
        protected override int SellPrice => Item.sellPrice(0, 0, 15, 0);

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.SandSlimeBanner),
                new(ItemID.IceSlimeBanner),
                new(ItemID.SpikedIceSlimeBanner),
                new(ItemID.JungleSlimeBanner),
                new(ItemID.SpikedJungleSlimeBanner),
                new(ItemID.LavaSlimeBanner)
            );
        }
    }
}
