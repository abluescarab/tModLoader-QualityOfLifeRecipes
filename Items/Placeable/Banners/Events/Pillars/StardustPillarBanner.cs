using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events.Pillars {
    public class StardustPillarBanner : BannerItem<StardustPillarBanner, Tiles.Banners.Events.Pillars.StardustPillarBanner> {
        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.Pillars.StardustPillarBanner}";

        protected override string TooltipTranslation =>
            "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.StardustCellBig}, {$NPCName.StardustJellyfishBig}, {$NPCName.StardustSpiderBig}, {$NPCName.StardustWormHead},\n" +
                "{$NPCName.StardustSoldier}";

        protected override int SellPrice => Item.sellPrice(0, 0, 15, 0);

        protected override int Rarity => ItemRarityID.Green;

        protected override int[] Ingredients => new int[] {
            ItemID.StardustJellyfishBanner,
            ItemID.StardustLargeCellBanner,
            ItemID.StardustSoldierBanner,
            ItemID.StardustSpiderBanner,
            ItemID.StardustWormBanner
        };
    }
}
