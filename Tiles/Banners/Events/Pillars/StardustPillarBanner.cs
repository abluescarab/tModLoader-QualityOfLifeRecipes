using Terraria.ID;

namespace QualityOfLifeRecipes.Tiles.Banners.Events.Pillars {
    public class StardustPillarBanner : BannerTile<Items.Placeable.Banners.Events.Pillars.StardustPillarBanner, StardustPillarBanner> {
        protected override string Translation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.Pillars.StardustPillarBanner}";

        protected override int[] NPCs => new int[] {
            NPCID.StardustCellSmall,
            NPCID.StardustCellBig,
            NPCID.StardustJellyfishSmall,
            NPCID.StardustJellyfishBig,
            NPCID.StardustSpiderSmall,
            NPCID.StardustSpiderBig,
            NPCID.StardustWormBody,
            NPCID.StardustWormHead,
            NPCID.StardustWormTail,
            NPCID.StardustSoldier
        };
    }
}
