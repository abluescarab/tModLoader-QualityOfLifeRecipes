﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace QualityOfLifeRecipes.Tiles.Banners.Events.Pillars {
    public class SolarPillarBanner : ModTile {
        public override void SetDefaults() {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 12 };
            TileObjectData.newTile.StyleHorizontal = true;

            ModTranslation translation = CreateMapEntryName();
            translation.SetDefault("Solar Pillar Banner");

            AddMapEntry(new Color(200, 200, 200), translation);

            disableSmartCursor = true;

            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType("SolarPillarBanner"));
        }

        public override void NearbyEffects(int i, int j, bool closer) {
            if(closer) {
                Player player = Main.LocalPlayer;

                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.SolarCorite)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.SolarCrawltipedeHead)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.SolarCrawltipedeBody)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.SolarCrawltipedeTail)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.SolarDrakomire)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.SolarDrakomireRider)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.SolarSolenian)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.SolarSroller)] = true;

                player.hasBanner = true;
            }
        }
    }
}
