using Terraria.ID;

namespace QualityOfLifeRecipes.Tiles.Banners.Events {
    public class PirateCrewBanner : BannerTile<Items.Placeable.Banners.Events.PirateCrewBanner, PirateCrewBanner> {
        protected override string Translation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.PirateCrewBanner}";

        protected override int[] NPCs => new int[] {
            NPCID.PirateCaptain,
            NPCID.PirateCorsair,
            NPCID.PirateCrossbower,
            NPCID.PirateDeadeye,
            NPCID.PirateDeckhand,
            NPCID.Parrot,
        };
    }
}
