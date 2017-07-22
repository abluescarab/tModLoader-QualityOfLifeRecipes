using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace QualityOfLifeRecipes.Tiles.Banners.Slimes {
    public class SupremeSlimeBanner : ModTile {
        public override void SetDefaults() {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 16 };
            TileObjectData.newTile.StyleHorizontal = true;

            ModTranslation translation = CreateMapEntryName();
            translation.SetDefault("Supreme Slime Banner");

            AddMapEntry(new Color(200, 200, 200), translation);

            disableSmartCursor = true;

            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType("SupremeSlimeBanner"));
        }

        public override void NearbyEffects(int i, int j, bool closer) {
            if(closer) {
                Player player = Main.LocalPlayer;

                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.GreenSlime)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.BlueSlime)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.PurpleSlime)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.RedSlime)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.YellowSlime)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.BlackSlime)] = true;

                player.hasBanner = true;
            }
        }
    }
}
