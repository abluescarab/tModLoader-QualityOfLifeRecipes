using Terraria.ID;

namespace QualityOfLifeRecipes.Tiles.Banners.Events {
    public class MartianMadnessBanner : BannerTile<Items.Placeable.Banners.Events.MartianMadnessBanner, MartianMadnessBanner> {
        protected override string Translation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.MartianMadnessBanner}";

        protected override int[] NPCs => new int[] {
            NPCID.Scutlix,
            NPCID.ScutlixRider,
            NPCID.MartianWalker,
            NPCID.MartianDrone,
            NPCID.MartianTurret,
            NPCID.GigaZapper,
            NPCID.MartianEngineer,
            NPCID.MartianOfficer,
            NPCID.RayGunner,
            NPCID.GrayGrunt,
            NPCID.BrainScrambler,
        };
    }
}
