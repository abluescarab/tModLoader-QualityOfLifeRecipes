using Terraria.ID;

namespace QualityOfLifeRecipes.Tiles.Banners.Slimes {
    public class ElementalSlimeBanner : BannerTile<Items.Placeable.Banners.Slimes.ElementalSlimeBanner, ElementalSlimeBanner> {
        protected override int[] NPCs => new int[] {
            NPCID.SandSlime,
            NPCID.IceSlime,
            NPCID.JungleSlime,
            NPCID.LavaSlime,
            NPCID.SpikedIceSlime,
            NPCID.SpikedJungleSlime
        };
    }
}
