using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class MartianMadnessBanner : BannerItem<MartianMadnessBanner, Tiles.Banners.Events.MartianMadnessBanner> {
        protected override int SellPrice => Item.sellPrice(0, 0, 25, 0);

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.ScutlixBanner),
                new(ItemID.MartianScutlixGunnerBanner),
                new(ItemID.MartianWalkerBanner),
                new(ItemID.MartianDroneBanner),
                new(ItemID.MartianTeslaTurretBanner),
                new(ItemID.MartianGigazapperBanner),
                new(ItemID.MartianEngineerBanner),
                new(ItemID.MartianOfficerBanner),
                new(ItemID.MartianRaygunnerBanner),
                new(ItemID.MartianGreyGruntBanner),
                new(ItemID.MartianBrainscramblerBanner)
            );
        }
    }
}
