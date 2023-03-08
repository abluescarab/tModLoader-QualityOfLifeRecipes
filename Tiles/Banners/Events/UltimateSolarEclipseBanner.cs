using Terraria.ID;

namespace QualityOfLifeRecipes.Tiles.Banners.Events {
    public class UltimateSolarEclipseBanner : BannerTile<Items.Placeable.Banners.Events.UltimateSolarEclipseBanner, UltimateSolarEclipseBanner> {
        protected override string Translation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.UltimateSolarEclipseBanner}";

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
            NPCID.Psycho,
            NPCID.Mothron,
            NPCID.MothronEgg,
            NPCID.MothronSpawn
        };
    }
}
