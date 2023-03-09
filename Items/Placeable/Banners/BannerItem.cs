using QualityOfLifeRecipes.Tiles.Banners;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners {
    public abstract class BannerItem<I, T> : BaseItem 
        where I : BannerItem<I, T>
        where T : BannerTile<I, T> {
        protected override int CraftingStation => TileID.Loom;
        protected override int Rarity => ItemRarityID.Green;

        public sealed override void SetDefaults() {
            base.SetDefaults();

            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<T>();
            Item.placeStyle = 0;
        }
    }
}
