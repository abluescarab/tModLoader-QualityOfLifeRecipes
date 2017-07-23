using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace QualityOfLifeRecipes.Tiles.Banners.Dungeon {
    public class DungeonBanner : ModTile {
        public override void SetDefaults() {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 12 };
            TileObjectData.newTile.StyleHorizontal = true;

            ModTranslation translation = CreateMapEntryName();
            translation.SetDefault("Dungeon Banner");

            AddMapEntry(new Color(200, 200, 200), translation);

            disableSmartCursor = true;

            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType("DungeonBanner"));
        }

        public override void NearbyEffects(int i, int j, bool closer) {
            if(closer) {
                Player player = Main.LocalPlayer;

                // angry bones
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.AngryBones)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.AngryBonesBig)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.AngryBonesBigHelmet)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.AngryBonesBigMuscle)] = true;
                // other
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.DarkCaster)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.CursedSkull)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.DungeonSlime)] = true;

                player.hasBanner = true;
            }
        }
    }
}
