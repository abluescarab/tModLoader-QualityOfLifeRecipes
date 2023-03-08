using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace QualityOfLifeRecipes.Tiles.Banners.Events {
    public class PumpkinMoonBanner : ModTile {
        public override void SetStaticDefaults() {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 12 };
            TileObjectData.newTile.StyleHorizontal = true;

            ModTranslation translation = CreateMapEntryName();
            translation.SetDefault("{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.PumpkinMoonBanner}");

            AddMapEntry(new Color(200, 200, 200), translation);

            TileID.Sets.DisableSmartCursor[Type] = true;

            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 48, ModContent.ItemType<Items.Placeable.Banners.Events.PumpkinMoonBanner>());
        }

        public override void NearbyEffects(int i, int j, bool closer) {
            if(closer) {
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.Scarecrow1)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.Scarecrow2)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.Scarecrow3)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.Scarecrow4)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.Scarecrow5)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.Scarecrow6)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.Scarecrow7)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.Scarecrow8)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.Scarecrow9)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.Scarecrow10)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.Splinterling)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.Hellhound)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.Poltergeist)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.HeadlessHorseman)] = true;

                Main.SceneMetrics.hasBanner = true;
            }
        }
    }
}
