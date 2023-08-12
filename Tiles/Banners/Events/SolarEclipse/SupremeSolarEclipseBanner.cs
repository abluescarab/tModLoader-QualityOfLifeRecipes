using Terraria.ID;

namespace QualityOfLifeRecipes.Tiles.Banners.Events.SolarEclipse {
    public class SupremeSolarEclipseBanner : BannerTile<Items.Placeable.Banners.Events.SolarEclipse.SupremeSolarEclipseBanner, SupremeSolarEclipseBanner> {
        protected override int[] NPCs => new int[] {
            NPCID.Frankenstein,
            NPCID.SwampThing,
            NPCID.Vampire,
            NPCID.VampireBat,
            NPCID.CreatureFromTheDeep,
            NPCID.Fritz,
            NPCID.ThePossessed,
            NPCID.Eyezor,
            NPCID.Reaper,
            NPCID.Butcher,
            NPCID.DeadlySphere,
            NPCID.DrManFly,
            NPCID.Nailhead,
            NPCID.Psycho
        };
    }
}
