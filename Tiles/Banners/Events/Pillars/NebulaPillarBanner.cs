using Terraria.ID;

namespace QualityOfLifeRecipes.Tiles.Banners.Events.Pillars {
    public class NebulaPillarBanner : BannerTile<Items.Placeable.Banners.Events.Pillars.NebulaPillarBanner, NebulaPillarBanner> {
        protected override string Translation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.Pillars.NebulaPillarBanner}";

        protected override int[] NPCs => new int[] {
            NPCID.NebulaBeast,
            NPCID.NebulaBrain,
            NPCID.NebulaHeadcrab,
            NPCID.NebulaSoldier
        };
    }
}
