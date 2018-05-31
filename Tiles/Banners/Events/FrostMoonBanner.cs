using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace QualityOfLifeRecipes.Tiles.Banners.Events {
    public class FrostMoonBanner : ModTile {
        public override void SetDefaults() {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 12 };
            TileObjectData.newTile.StyleHorizontal = true;

            ModTranslation translation = CreateMapEntryName();
            translation.SetDefault("Frost Moon Banner");

            AddMapEntry(new Color(200, 200, 200), translation);

            disableSmartCursor = true;

            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType("FrostMoonBanner"));
        }

        public override void NearbyEffects(int i, int j, bool closer) {
            if(closer) {
                Player player = Main.LocalPlayer;

                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.PresentMimic)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.Flocko)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.GingerbreadMan)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.ZombieElf)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.ZombieElfBeard)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.ZombieElfGirl)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.ElfArcher)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.Nutcracker)] = true;
                player.NPCBannerBuff[Item.NPCtoBanner(NPCID.NutcrackerSpinning)] = true;

                player.hasBanner = true;
            }
        }
    }
}
