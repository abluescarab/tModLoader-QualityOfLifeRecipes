using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace QualityOfLifeRecipes.Tiles.Banners.Dungeon {
    public class SupremeDungeonBanner : ModTile {
        public override void SetStaticDefaults() {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 12 };
            TileObjectData.newTile.StyleHorizontal = true;

            ModTranslation translation = CreateMapEntryName();
            translation.SetDefault("{$Mods.QualityOfLifeRecipes.Placeable.Banners.Dungeon.SupremeDungeonBanner}");

            AddMapEntry(new Color(200, 200, 200), translation);

            TileID.Sets.DisableSmartCursor[Type] = true;
            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 48, ModContent.ItemType<Items.Placeable.Banners.Dungeon.SupremeDungeonBanner>());
        }

        public override void NearbyEffects(int i, int j, bool closer) {
            if(closer) {
                // angry bones
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.AngryBones)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.AngryBonesBig)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.AngryBonesBigHelmet)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.AngryBonesBigMuscle)] = true;
                // blue armored bones
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.BlueArmoredBones)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.BlueArmoredBonesMace)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.BlueArmoredBonesNoPants)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.BlueArmoredBonesSword)] = true;
                // rusty armored bones
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.RustyArmoredBonesAxe)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.RustyArmoredBonesFlail)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.RustyArmoredBonesSword)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.RustyArmoredBonesSwordNoArmor)] = true;
                // hell armored bones
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.HellArmoredBones)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.HellArmoredBonesMace)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.HellArmoredBonesSpikeShield)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.HellArmoredBonesSword)] = true;
                // necromancer
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.Necromancer)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.NecromancerArmored)] = true;
                // ragged caster
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.RaggedCaster)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.RaggedCasterOpenCoat)] = true;
                // diabolist
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.DiabolistRed)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.DiabolistWhite)] = true;
                // other
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.DarkCaster)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.CursedSkull)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.DungeonSlime)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.GiantCursedSkull)] = true;

                Main.SceneMetrics.hasBanner = true;
            }
        }
    }
}
