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

        protected override Ingredient[] Ingredients => new Ingredient[] {
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
            new(ItemID.MartianBrainscramblerBanner),
        };
    }
}
