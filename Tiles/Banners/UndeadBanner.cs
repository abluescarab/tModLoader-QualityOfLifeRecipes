using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace QualityOfLifeRecipes.Tiles.Banners {
    public class UndeadBanner : ModTile {
        public override void SetDefaults() {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 12 };
            TileObjectData.newTile.StyleHorizontal = true;

            ModTranslation translation = CreateMapEntryName();
            translation.SetDefault("Undead Banner");

            AddMapEntry(new Color(200, 200, 200), translation);

            disableSmartCursor = true;

            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType("UndeadBanner"));
        }

        public override void NearbyEffects(int i, int j, bool closer) {
            if(closer) {
                Player player = Main.LocalPlayer;

                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.Zombie)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.ArmedZombie)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.BaldZombie)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.PincushionZombie)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.ArmedZombiePincussion)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.SlimedZombie)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.ArmedZombieSlimed)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.SwampZombie)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.ArmedZombieSwamp)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.TwiggyZombie)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.ArmedZombieTwiggy)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.FemaleZombie)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.ArmedZombieCenx)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.ZombieRaincoat)] = true;

                player.hasBanner = true;
            }
        }
    }
}
