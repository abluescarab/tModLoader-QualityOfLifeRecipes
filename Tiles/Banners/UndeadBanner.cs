using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace QualityOfLifeRecipes.Tiles.Banners {
    public class UndeadBanner : ModTile {
        public override void SetStaticDefaults() {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 12 };
            TileObjectData.newTile.StyleHorizontal = true;

            ModTranslation translation = CreateMapEntryName();
            translation.SetDefault("{$Mods.QualityOfLifeRecipes.Placeable.Banners.UndeadBanner}");

            AddMapEntry(new Color(200, 200, 200), translation);

            TileID.Sets.DisableSmartCursor[Type] = true;

            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 48, ModContent.ItemType<Items.Placeable.Banners.UndeadBanner>());
        }

        public override void NearbyEffects(int i, int j, bool closer) {
            if(closer) {
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.Zombie)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.ArmedZombie)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.BaldZombie)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.PincushionZombie)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.ArmedZombiePincussion)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.SlimedZombie)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.ArmedZombieSlimed)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.SwampZombie)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.ArmedZombieSwamp)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.TwiggyZombie)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.ArmedZombieTwiggy)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.FemaleZombie)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.ArmedZombieCenx)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.ZombieRaincoat)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.DemonEye)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.CataractEye)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.DialatedEye)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.GreenEye)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.SleepyEye)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.PurpleEye)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.DemonEyeOwl)] = true;
                Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(NPCID.DemonEyeSpaceship)] = true;

                Main.SceneMetrics.hasBanner = true;
            }
        }
    }
}
