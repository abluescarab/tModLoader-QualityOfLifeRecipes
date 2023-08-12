using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Dungeon {
    public class UltimateDungeonBanner : BannerItem<UltimateDungeonBanner, Tiles.Banners.Dungeon.UltimateDungeonBanner> {
        protected override int SellPrice => Item.sellPrice(0, 0, 35, 0);

        public override void AddRecipes() {
            AddRecipe(
                new(ModContent.ItemType<SupremeDungeonBanner>()),
                new(ItemID.PaladinBanner),
                new(ItemID.SkeletonCommandoBanner),
                new(ItemID.SkeletonSniperBanner),
                new(ItemID.TacticalSkeletonBanner),
                new(ItemID.BoneLeeBanner),
                new(ItemID.DungeonSpiritBanner)
            );
        }
    }
}
