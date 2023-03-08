using Terraria.ID;

namespace QualityOfLifeRecipes.Tiles.Banners.Dungeon {
    public class DungeonBanner : BannerTile<Items.Placeable.Banners.Dungeon.DungeonBanner, DungeonBanner> {
        protected override string Translation => "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Dungeon.DungeonBanner}";

        protected override int[] NPCs => new int[] {
            // angry bones
            NPCID.AngryBones,
            NPCID.AngryBonesBig,
            NPCID.AngryBonesBigHelmet,
            NPCID.AngryBonesBigMuscle,
            // other
            NPCID.DarkCaster,
            NPCID.CursedSkull,
            NPCID.DungeonSlime
        };
    }
}
