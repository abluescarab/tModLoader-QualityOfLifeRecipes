using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Dungeon {
    public class UltimateDungeonBanner : BannerItem<UltimateDungeonBanner, Tiles.Banners.Dungeon.UltimateDungeonBanner> {
        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Dungeon.UltimateDungeonBanner}";

        protected override string TooltipTranslation =>
            "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.AngryBones}, {$NPCName.DarkCaster}, {$NPCName.CursedSkull}, {$NPCName.RustyArmoredBonesAxe},\n" +
                "{$NPCName.BlueArmoredBones}, {$NPCName.HellArmoredBones}, {$NPCName.Necromancer}, {$NPCName.RaggedCaster},\n" +
                "{$NPCName.DiabolistRed}, {$NPCName.GiantCursedSkull}, {$NPCName.DungeonSlime}, {$NPCName.Paladin},\n" +
                "{$NPCName.SkeletonCommando}, {$NPCName.SkeletonSniper}, {$NPCName.TacticalSkeleton}, {$NPCName.BoneLee},\n" +
                "{$NPCName.DungeonSpirit}";

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
