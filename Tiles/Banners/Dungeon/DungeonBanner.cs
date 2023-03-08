using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace QualityOfLifeRecipes.Tiles.Banners.Dungeon {
    public class DungeonBanner : ModTile {
        public override void SetStaticDefaults() {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 12 };
            TileObjectData.newTile.StyleHorizontal = true;

            ModTranslation translation = CreateMapEntryName();
            translation.SetDefault("{$Mods.QualityOfLifeRecipes.Placeable.Banners.Dungeon.DungeonBanner}");

            AddMapEntry(new Color(200, 200, 200), translation);

            TileID.Sets.DisableSmartCursor[Type] = true;
            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 48, ModContent.ItemType<Items.Placeable.Banners.Dungeon.DungeonBanner>());
        }

        public override void NearbyEffects(int i, int j, bool closer) {
            if(closer) {
                // angry bones
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.AngryBones)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.AngryBonesBig)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.AngryBonesBigHelmet)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.AngryBonesBigMuscle)] = true;
                // other
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.DarkCaster)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.CursedSkull)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.DungeonSlime)] = true;

                Main.SceneMetrics.hasBanner = true;
            }
        }
    }
}
