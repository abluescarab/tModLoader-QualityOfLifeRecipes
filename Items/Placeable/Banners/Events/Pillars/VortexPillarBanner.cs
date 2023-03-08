using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events.Pillars {
    public class VortexPillarBanner : BannerItem<VortexPillarBanner, Tiles.Banners.Events.Pillars.VortexPillarBanner> {
        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.Pillars.VortexPillarBanner}";

        protected override string TooltipTranslation =>
            "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.VortexRifleman}, {$NPCName.VortexSoldier}, {$NPCName.VortexHornetQueen}, {$NPCName.VortexHornet},\n" +
                "{$NPCName.VortexLarva}";

        protected override int SellPrice => Item.sellPrice(0, 0, 12, 0);

        protected override int Rarity => ItemRarityID.Green;

        protected override int[] Ingredients => new int[] {
            ItemID.VortexHornetBanner,
            ItemID.VortexHornetQueenBanner,
            ItemID.VortexLarvaBanner,
            ItemID.VortexRiflemanBanner,
            ItemID.VortexSoldierBanner
        };
    }
}
