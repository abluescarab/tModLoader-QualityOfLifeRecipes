using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace QualityOfLifeRecipes.Tiles {
    public class AlterationStation : ModTile {
        public override void SetDefaults() {
            ModTranslation translation = CreateMapEntryName();
            translation.SetDefault("Alteration Station");

            Main.tileSolidTop[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileLighted[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);

            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
            AddMapEntry(new Color(100, 100, 100), translation);

            dustType = mod.DustType("Sparkle");
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.WorkBenches };

            TileObjectData.addTile(Type);
        }

        public override void NumDust(int i, int j, bool fail, ref int num) {
            num = fail ? 1 : 3;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            Item.NewItem(i * 16, j * 16, 48, 32, mod.ItemType("AlterationStation"));
        }
    }
}
