using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Slimes {
    public class SupremeSlimeBanner : BannerItem<SupremeSlimeBanner, Tiles.Banners.Slimes.SupremeSlimeBanner> {
        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Slimes.SupremeSlimeBanner}";

        protected override string TooltipTranslation =>
            "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.GreenSlime}, {$NPCName.BlueSlime}, {$NPCName.PurpleSlime}, {$NPCName.RedSlime},\n" +
                "{$NPCName.YellowSlime}, {$NPCName.BlackSlime}";

        protected override int SellPrice => Item.sellPrice(0, 0, 15, 0);

        protected override int[] Ingredients => new int[] {
            ItemID.GreenSlimeBanner,
            ItemID.SlimeBanner,
            ItemID.PurpleSlimeBanner,
            ItemID.RedSlimeBanner,
            ItemID.YellowSlimeBanner,
            ItemID.BlackSlimeBanner
        };
    }
}
