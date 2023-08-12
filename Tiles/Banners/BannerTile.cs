using Microsoft.Xna.Framework;
using QualityOfLifeRecipes.Items.Placeable.Banners;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace QualityOfLifeRecipes.Tiles.Banners {
    public abstract class BannerTile<I, T> : ModTile
        where I : BannerItem<I, T>
        where T : BannerTile<I, T> {
        protected abstract int[] NPCs { get; }

        public sealed override void SetStaticDefaults() {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 12 };
            TileObjectData.newTile.StyleHorizontal = true;

            AddMapEntry(new Color(200, 200, 200), ModContent.GetInstance<I>().DisplayName);

            TileID.Sets.DisableSmartCursor[Type] = true;

            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 48, ModContent.ItemType<I>());
        }

        public override void NearbyEffects(int i, int j, bool closer) {
            if(closer) {
                foreach(int id in NPCs) {
                    Main.SceneMetrics.NPCBannerBuff[Item.NPCtoBanner(id)] = true;
                }

                Main.SceneMetrics.hasBanner = true;
            }
        }
    }
}
