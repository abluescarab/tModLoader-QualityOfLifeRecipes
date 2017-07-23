using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace QualityOfLifeRecipes.Tiles.Banners.Dungeon {
    public class SupremeDungeonBanner : ModTile {
        public override void SetDefaults() {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 12 };
            TileObjectData.newTile.StyleHorizontal = true;

            ModTranslation translation = CreateMapEntryName();
            translation.SetDefault("Supreme Dungeon Banner");

            AddMapEntry(new Color(200, 200, 200), translation);

            disableSmartCursor = true;

            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType("SupremeDungeonBanner"));
        }

        public override void NearbyEffects(int i, int j, bool closer) {
            if(closer) {
                Player player = Main.LocalPlayer;

                // angry bones
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.AngryBones)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.AngryBonesBig)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.AngryBonesBigHelmet)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.AngryBonesBigMuscle)] = true;
                // blue armored bones
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.BlueArmoredBones)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.BlueArmoredBonesMace)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.BlueArmoredBonesNoPants)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.BlueArmoredBonesSword)] = true;
                // rusty armored bones
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.RustyArmoredBonesAxe)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.RustyArmoredBonesFlail)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.RustyArmoredBonesSword)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.RustyArmoredBonesSwordNoArmor)] = true;
                // hell armored bones
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.HellArmoredBones)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.HellArmoredBonesMace)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.HellArmoredBonesSpikeShield)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.HellArmoredBonesSword)] = true;
                // necromancer
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.Necromancer)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.NecromancerArmored)] = true;
                // ragged caster
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.RaggedCaster)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.RaggedCasterOpenCoat)] = true;
                // diabolist
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.DiabolistRed)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.DiabolistWhite)] = true;
                // other
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.DarkCaster)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.CursedSkull)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.DungeonSlime)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.GiantCursedSkull)] = true;

                player.hasBanner = true;
            }
        }
    }
}
