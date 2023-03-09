using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Dungeon {
    public class SupremeDungeonBanner : BannerItem<SupremeDungeonBanner, Tiles.Banners.Dungeon.SupremeDungeonBanner> {
        protected override string DisplayNameTranslation => 
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Dungeon.SupremeDungeonBanner}";

        protected override string TooltipTranslation =>
            "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.AngryBones}, {$NPCName.DarkCaster}, {$NPCName.CursedSkull}, {$NPCName.RustyArmoredBonesAxe},\n" +
                "{$NPCName.BlueArmoredBones}, {$NPCName.HellArmoredBones}, {$NPCName.Necromancer}, {$NPCName.RaggedCaster},\n" +
                "{$NPCName.DiabolistRed}, {$NPCName.GiantCursedSkull}, {$NPCName.DungeonSlime}";

        protected override int SellPrice => Item.sellPrice(0, 0, 25, 0);

        protected override int[] Ingredients => new int[] {
            ItemID.DungeonSlimeBanner,
            ItemID.BlueArmoredBonesBanner,
            ItemID.RustyArmoredBonesBanner,
            ItemID.HellArmoredBonesBanner,
            ItemID.NecromancerBanner,
            ItemID.RaggedCasterBanner,
            ItemID.DiablolistBanner,
            ItemID.GiantCursedSkullBanner
        };
    }
}
