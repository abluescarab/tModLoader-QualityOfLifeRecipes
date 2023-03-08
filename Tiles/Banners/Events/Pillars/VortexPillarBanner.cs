using Terraria.ID;

namespace QualityOfLifeRecipes.Tiles.Banners.Events.Pillars {
    public class VortexPillarBanner : BannerTile<Items.Placeable.Banners.Events.Pillars.VortexPillarBanner, VortexPillarBanner> {
        protected override string Translation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.Pillars.VortexPillarBanner}";

        protected override int[] NPCs => new int[] {
            NPCID.VortexHornet,
            NPCID.VortexHornetQueen,
            NPCID.VortexLarva,
            NPCID.VortexRifleman,
            NPCID.VortexSoldier
        };
    }
}
