using Terraria;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Slimes {
    public class UltimateSlimeBanner : BannerItem<UltimateSlimeBanner, Tiles.Banners.Slimes.UltimateSlimeBanner> {
        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Slimes.UltimateSlimeBanner}";

        protected override string TooltipTranslation =>
            "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.SandSlime}, {$NPCName.IceSlime}, {$NPCName.JungleSlime}, {$NPCName.LavaSlime},\n" +
                "{$NPCName.SlimeSpiked}, {$NPCName.GreenSlime}, {$NPCName.BlueSlime}, {$NPCName.PurpleSlime},\n" +
                "{$NPCName.RedSlime}, {$NPCName.YellowSlime}, {$NPCName.BlackSlime}";

        protected override int SellPrice => Item.sellPrice(0, 0, 35, 0);

        public override void AddRecipes() {
            AddRecipe(
                new(ModContent.ItemType<ElementalSlimeBanner>()),
                new(ModContent.ItemType<SupremeSlimeBanner>())
            );
        }
    }
}
