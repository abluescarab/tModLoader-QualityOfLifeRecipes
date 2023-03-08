using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Slimes {
    public class ElementalSlimeBanner : BannerItem<ElementalSlimeBanner, Tiles.Banners.Slimes.ElementalSlimeBanner> {
        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Slimes.ElementalSlimeBanner}";

        protected override string TooltipTranslation =>
            "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.SandSlime}, {$NPCName.IceSlime}, {$NPCName.JungleSlime}, {$NPCName.LavaSlime},\n" +
                "{$NPCName.SlimeSpiked}";

        protected override int SellPrice => Item.sellPrice(0, 0, 15, 0);

        protected override int Rarity => ItemRarityID.Green;

        protected override int[] Ingredients => new int[] {
            ItemID.SandSlimeBanner,
            ItemID.IceSlimeBanner,
            ItemID.SpikedIceSlimeBanner,
            ItemID.JungleSlimeBanner,
            ItemID.SpikedJungleSlimeBanner,
            ItemID.LavaSlimeBanner
        };
    }
}
