using Terraria.ID;

namespace QualityOfLifeRecipes.Tiles.Banners.Slimes {
    public class UltimateSlimeBanner : BannerTile<Items.Placeable.Banners.Slimes.UltimateSlimeBanner, UltimateSlimeBanner> {
        protected override int[] NPCs => new int[] {
            NPCID.SandSlime,
            NPCID.IceSlime,
            NPCID.JungleSlime,
            NPCID.LavaSlime,
            NPCID.SpikedIceSlime,
            NPCID.SpikedJungleSlime,
            NPCID.GreenSlime,
            NPCID.BlueSlime,
            NPCID.PurpleSlime,
            NPCID.RedSlime,
            NPCID.YellowSlime,
            NPCID.BlackSlime
        };
    }
}
