using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Dungeon {
    public class DungeonBanner : BannerItem<DungeonBanner, Tiles.Banners.Dungeon.DungeonBanner> {
        protected override int SellPrice => Item.sellPrice(0, 0, 10, 0);

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.AngryBonesBanner),
                new(ItemID.SkeletonMageBanner),
                new(ItemID.CursedSkullBanner)
            );
        }
    }
}
