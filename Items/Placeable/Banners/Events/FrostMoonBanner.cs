using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class FrostMoonBanner : BannerItem<FrostMoonBanner, Tiles.Banners.Events.FrostMoonBanner> {
        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.FrostMoonBanner}";

        protected override string TooltipTranslation =>
            "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.PresentMimic}, {$NPCName.Flocko}, {$NPCName.GingerbreadMan}, {$NPCName.ZombieElf},\n" +
                "{$NPCName.ElfArcher}, {$NPCName.Nutcracker}, {$NPCName.Yeti}, {$NPCName.ElfCopter},\n" +
                "{$NPCName.Krampus}";

        protected override int SellPrice => Item.sellPrice(0, 0, 15, 0);

        protected override int[] Ingredients => new int[] {
            ItemID.PresentMimicBanner,
            ItemID.FlockoBanner,
            ItemID.GingerbreadManBanner,
            ItemID.ZombieElfBanner,
            ItemID.ElfArcherBanner,
            ItemID.NutcrackerBanner,
            ItemID.YetiBanner,
            ItemID.ElfCopterBanner,
            ItemID.KrampusBanner
        };
    }
}
