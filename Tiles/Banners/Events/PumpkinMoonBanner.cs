using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace QualityOfLifeRecipes.Tiles.Banners.Events {
    public class PumpkinMoonBanner : ModTile {
        public override void SetDefaults() {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 12 };
            TileObjectData.newTile.StyleHorizontal = true;

            ModTranslation translation = CreateMapEntryName();
            translation.SetDefault("Pumpkin Moon Banner");

            AddMapEntry(new Color(200, 200, 200), translation);

            disableSmartCursor = true;

            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType("PumpkinMoonBanner"));
        }

        public override void NearbyEffects(int i, int j, bool closer) {
            if(closer) {
                Player player = Main.LocalPlayer;

                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.Scarecrow1)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.Scarecrow2)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.Scarecrow3)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.Scarecrow4)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.Scarecrow5)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.Scarecrow6)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.Scarecrow7)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.Scarecrow8)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.Scarecrow9)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.Scarecrow10)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.Splinterling)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.Hellhound)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.Poltergeist)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.HeadlessHorseman)] = true;

                player.hasBanner = true;
            }
        }
    }
}
