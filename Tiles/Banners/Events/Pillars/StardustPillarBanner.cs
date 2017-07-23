using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace QualityOfLifeRecipes.Tiles.Banners.Events.Pillars {
    public class StardustPillarBanner : ModTile {
        public override void SetDefaults() {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 12 };
            TileObjectData.newTile.StyleHorizontal = true;

            ModTranslation translation = CreateMapEntryName();
            translation.SetDefault("Stardust Pillar Banner");

            AddMapEntry(new Color(200, 200, 200), translation);

            disableSmartCursor = true;

            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType("StardustPillarBanner"));
        }

        public override void NearbyEffects(int i, int j, bool closer) {
            if(closer) {
                Player player = Main.LocalPlayer;

                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.StardustCellSmall)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.StardustCellBig)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.StardustJellyfishSmall)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.StardustJellyfishBig)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.StardustSpiderSmall)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.StardustSpiderBig)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.StardustWormBody)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.StardustWormHead)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.StardustWormTail)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.StardustSoldier)] = true;

                player.hasBanner = true;
            }
        }
    }
}
