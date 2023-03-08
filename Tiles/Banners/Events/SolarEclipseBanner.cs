using Terraria.ID;

namespace QualityOfLifeRecipes.Tiles.Banners.Events {
    public class SolarEclipseBanner : BannerTile<Items.Placeable.Banners.Events.SolarEclipseBanner, SolarEclipseBanner> {
        protected override string Translation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.SolarEclipseBanner}";

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
