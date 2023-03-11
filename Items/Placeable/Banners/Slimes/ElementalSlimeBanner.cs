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

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.SandSlimeBanner),
                new(ItemID.IceSlimeBanner),
                new(ItemID.SpikedIceSlimeBanner),
                new(ItemID.JungleSlimeBanner),
                new(ItemID.SpikedJungleSlimeBanner),
                new(ItemID.LavaSlimeBanner)
            );
        }
    }
}
