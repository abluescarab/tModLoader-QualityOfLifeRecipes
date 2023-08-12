using Terraria.ID;

namespace QualityOfLifeRecipes.Tiles.Banners.Events.Pillars {
    public class SolarPillarBanner : BannerTile<Items.Placeable.Banners.Events.Pillars.SolarPillarBanner, SolarPillarBanner> {
        protected override int[] NPCs => new int[] {
            NPCID.SolarCorite,
            NPCID.SolarCrawltipedeHead,
            NPCID.SolarCrawltipedeBody,
            NPCID.SolarCrawltipedeTail,
            NPCID.SolarDrakomire,
            NPCID.SolarDrakomireRider,
            NPCID.SolarSolenian,
            NPCID.SolarSroller
        };
    }
}
