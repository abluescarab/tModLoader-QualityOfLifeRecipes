using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events.Pillars {
    public class SolarPillarBanner : BannerItem<SolarPillarBanner, Tiles.Banners.Events.Pillars.SolarPillarBanner> {
        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.Pillars.SolarPillarBanner}";

        protected override string TooltipTranslation =>
            "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.SolarCorite}, {$NPCName.SolarCrawltipedeHead}, {$NPCName.SolarDrakomire}, {$NPCName.SolarDrakomireRider},\n" +
                "{$NPCName.SolarSolenian}, {$NPCName.SolarSroller}";

        protected override int SellPrice => Item.sellPrice(0, 0, 15, 0);

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.SolarCoriteBanner),
                new(ItemID.SolarCrawltipedeBanner),
                new(ItemID.SolarDrakomireBanner),
                new(ItemID.SolarDrakomireRiderBanner),
                new(ItemID.SolarSolenianBanner),
                new(ItemID.SolarSrollerBanner)
            );
        }
    }
}
