using Terraria.ID;

namespace QualityOfLifeRecipes.Tiles.Banners.Events.SolarEclipse {
    public class SolarEclipseBanner : BannerTile<Items.Placeable.Banners.Events.SolarEclipse.SolarEclipseBanner, SolarEclipseBanner> {
        protected override int[] NPCs => new int[] {
            NPCID.Frankenstein,
            NPCID.SwampThing,
            NPCID.Vampire,
            NPCID.VampireBat,
            NPCID.CreatureFromTheDeep,
            NPCID.Fritz,
            NPCID.ThePossessed,
        };
    }
}
