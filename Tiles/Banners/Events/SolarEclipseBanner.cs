﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace QualityOfLifeRecipes.Tiles.Banners.Events {
    public class SolarEclipseBanner : ModTile {
        public override void SetDefaults() {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 12 };
            TileObjectData.newTile.StyleHorizontal = true;

            ModTranslation translation = CreateMapEntryName();
            translation.SetDefault("Solar Eclipse Banner");

            AddMapEntry(new Color(200, 200, 200), translation);

            disableSmartCursor = true;

            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType("SolarEclipseBanner"));
        }

        public override void NearbyEffects(int i, int j, bool closer) {
            if(closer) {
                Player player = Main.LocalPlayer;

                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.Frankenstein)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.SwampThing)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.Vampire)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.VampireBat)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.CreatureFromTheDeep)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.Fritz)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.ThePossessed)] = true;

                player.hasBanner = true;
            }
        }
    }
}
