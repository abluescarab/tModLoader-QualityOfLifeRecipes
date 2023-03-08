using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Tiles.Banners.Events {
    public class FrostMoonBanner : BannerTile<Items.Placeable.Banners.Events.FrostMoonBanner, FrostMoonBanner> {
        protected override string Translation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.FrostMoonBanner}";

        protected override int[] NPCs => new int[] {
            NPCID.PresentMimic,
            NPCID.Flocko,
            NPCID.GingerbreadMan,
            NPCID.ZombieElf,
            NPCID.ZombieElfBeard,
            NPCID.ZombieElfGirl,
            NPCID.ElfArcher,
            NPCID.Nutcracker,
            NPCID.NutcrackerSpinning
        };
    }
}
