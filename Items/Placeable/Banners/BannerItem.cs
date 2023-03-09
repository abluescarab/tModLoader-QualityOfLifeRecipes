using QualityOfLifeRecipes.Tiles.Banners;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners {
    public abstract class BannerItem<I, T> : ModItem 
        where I : BannerItem<I, T>
        where T : BannerTile<I, T> {
        protected abstract string DisplayNameTranslation { get; }
        protected abstract string TooltipTranslation { get; }
        protected abstract int SellPrice { get; }
        protected abstract int Rarity { get; }
        protected abstract int[] Ingredients { get; }

        public sealed override void SetStaticDefaults() {
            DisplayName.SetDefault(DisplayNameTranslation);
            Tooltip.SetDefault(TooltipTranslation);
        }

        protected override int Rarity => ItemRarityID.Green;

        public sealed override void SetDefaults() {
            Item.value = SellPrice;
            Item.rare = Rarity;
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

        public sealed override void AddRecipes() {
            Recipe recipe = CreateRecipe();

            foreach(int id in Ingredients) {
                recipe.AddIngredient(id);
            }

            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
