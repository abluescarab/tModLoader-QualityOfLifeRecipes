using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Dungeon {
    public class DungeonBanner : BannerItem<DungeonBanner, Tiles.Banners.Dungeon.DungeonBanner> {
        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Dungeon.DungeonBanner}";

        protected override string TooltipTranslation =>
            "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.AngryBones}, {$NPCName.DarkCaster}, {$NPCName.CursedSkull}";

        protected override int SellPrice => Item.sellPrice(0, 0, 10, 0);

        protected override int Rarity => ItemRarityID.Green;

        protected override int[] Ingredients => new int[] {
            ItemID.AngryBonesBanner,
            ItemID.SkeletonMageBanner,
            ItemID.CursedSkullBanner
        };
    }
}
