using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Dungeon {
    public class SupremeDungeonBanner : BannerItem<SupremeDungeonBanner, Tiles.Banners.Dungeon.SupremeDungeonBanner> {
        protected override int SellPrice => Item.sellPrice(0, 0, 25, 0);

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.DungeonSlimeBanner),
                new(ItemID.BlueArmoredBonesBanner),
                new(ItemID.RustyArmoredBonesBanner),
                new(ItemID.HellArmoredBonesBanner),
                new(ItemID.NecromancerBanner),
                new(ItemID.RaggedCasterBanner),
                new(ItemID.DiablolistBanner),
                new(ItemID.GiantCursedSkullBanner)
            );
        }
    }
}
