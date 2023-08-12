using Terraria.ID;

namespace QualityOfLifeRecipes.Tiles.Banners.Dungeon {
    public class SupremeDungeonBanner : BannerTile<Items.Placeable.Banners.Dungeon.SupremeDungeonBanner, SupremeDungeonBanner> {
        protected override int[] NPCs => new int[] {
            // angry bones
            NPCID.AngryBones,
            NPCID.AngryBonesBig,
            NPCID.AngryBonesBigHelmet,
            NPCID.AngryBonesBigMuscle,
            // blue armored bones
            NPCID.BlueArmoredBones,
            NPCID.BlueArmoredBonesMace,
            NPCID.BlueArmoredBonesNoPants,
            NPCID.BlueArmoredBonesSword,
            // rusty armored bones
            NPCID.RustyArmoredBonesAxe,
            NPCID.RustyArmoredBonesFlail,
            NPCID.RustyArmoredBonesSword,
            NPCID.RustyArmoredBonesSwordNoArmor,
            // hell armored bones
            NPCID.HellArmoredBones,
            NPCID.HellArmoredBonesMace,
            NPCID.HellArmoredBonesSpikeShield,
            NPCID.HellArmoredBonesSword,
            // necromancer
            NPCID.Necromancer,
            NPCID.NecromancerArmored,
            // ragged caster
            NPCID.RaggedCaster,
            NPCID.RaggedCasterOpenCoat,
            // diabolist
            NPCID.DiabolistRed,
            NPCID.DiabolistWhite,
            // other
            NPCID.DarkCaster,
            NPCID.CursedSkull,
            NPCID.DungeonSlime,
            NPCID.GiantCursedSkull
        };
    }
}
