using Terraria.ID;

namespace QualityOfLifeRecipes.Tiles.Banners.Events {
    public class PumpkinMoonBanner : BannerTile<Items.Placeable.Banners.Events.PumpkinMoonBanner, PumpkinMoonBanner> {
        protected override string Translation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.PumpkinMoonBanner}";

        protected override int[] NPCs => new int[] {
            NPCID.Scarecrow1,
            NPCID.Scarecrow2,
            NPCID.Scarecrow3,
            NPCID.Scarecrow4,
            NPCID.Scarecrow5,
            NPCID.Scarecrow6,
            NPCID.Scarecrow7,
            NPCID.Scarecrow8,
            NPCID.Scarecrow9,
            NPCID.Scarecrow10,
            NPCID.Splinterling,
            NPCID.Hellhound,
            NPCID.Poltergeist,
            NPCID.HeadlessHorseman,
        };
    }
}
