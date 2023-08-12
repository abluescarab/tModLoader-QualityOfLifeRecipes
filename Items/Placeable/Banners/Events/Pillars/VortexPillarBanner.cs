using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events.Pillars {
    public class VortexPillarBanner : BannerItem<VortexPillarBanner, Tiles.Banners.Events.Pillars.VortexPillarBanner> {
        protected override int SellPrice => Item.sellPrice(0, 0, 12, 0);

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.VortexHornetBanner),
                new(ItemID.VortexHornetQueenBanner),
                new(ItemID.VortexLarvaBanner),
                new(ItemID.VortexRiflemanBanner),
                new(ItemID.VortexSoldierBanner)
            );
        }
    }
}
