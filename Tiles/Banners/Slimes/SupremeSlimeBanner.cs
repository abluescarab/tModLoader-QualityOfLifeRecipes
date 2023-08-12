using Terraria.ID;

namespace QualityOfLifeRecipes.Tiles.Banners.Slimes {
    public class SupremeSlimeBanner : BannerTile<Items.Placeable.Banners.Slimes.SupremeSlimeBanner, SupremeSlimeBanner> {
        protected override int[] NPCs => new int[] {
            NPCID.GreenSlime,
            NPCID.BlueSlime,
            NPCID.PurpleSlime,
            NPCID.RedSlime,
            NPCID.YellowSlime,
            NPCID.BlackSlime
        };
    }
}
