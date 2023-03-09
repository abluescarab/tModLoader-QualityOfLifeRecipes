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

        protected override Ingredient[] Ingredients => new Ingredient[] {
            new(ItemID.StardustJellyfishBanner),
            new(ItemID.StardustLargeCellBanner),
            new(ItemID.StardustSoldierBanner),
            new(ItemID.StardustSpiderBanner),
            new(ItemID.StardustWormBanner),
        };
    }
}
