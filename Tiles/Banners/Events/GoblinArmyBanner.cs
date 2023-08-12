using Terraria.ID;

namespace QualityOfLifeRecipes.Tiles.Banners.Events {
    public class GoblinArmyBanner : BannerTile<Items.Placeable.Banners.Events.GoblinArmyBanner, GoblinArmyBanner> {
        protected override int[] NPCs => new int[] {
            NPCID.GoblinArcher,
            NPCID.GoblinPeon,
            NPCID.GoblinSorcerer,
            NPCID.GoblinThief,
            NPCID.GoblinWarrior
        };
    }
}
