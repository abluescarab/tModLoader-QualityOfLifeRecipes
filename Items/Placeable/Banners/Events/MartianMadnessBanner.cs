using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class MartianMadnessBanner : BannerItem<MartianMadnessBanner, Tiles.Banners.Events.MartianMadnessBanner> {
        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.MartianMadnessBanner}";

        protected override string TooltipTranslation =>
            "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.Scutlix}, {$NPCName.MartianTurret}, {$NPCName.GigaZapper}, {$NPCName.RayGunner},\n" +
                "{$NPCName.GrayGrunt}, {$NPCName.BrainScrambler}, {$NPCName.MartianWalker}, {$NPCName.MartianDrone},\n" +
                "{$NPCName.MartianEngineer}, {$NPCName.MartianOfficer}";

        protected override int SellPrice => Item.sellPrice(0, 0, 25, 0);

        protected override int[] Ingredients => new int[] {
            ItemID.ScutlixBanner,
            ItemID.MartianScutlixGunnerBanner,
            ItemID.MartianWalkerBanner,
            ItemID.MartianDroneBanner,
            ItemID.MartianTeslaTurretBanner,
            ItemID.MartianGigazapperBanner,
            ItemID.MartianEngineerBanner,
            ItemID.MartianOfficerBanner,
            ItemID.MartianRaygunnerBanner,
            ItemID.MartianGreyGruntBanner,
            ItemID.MartianBrainscramblerBanner
        };
    }
}
