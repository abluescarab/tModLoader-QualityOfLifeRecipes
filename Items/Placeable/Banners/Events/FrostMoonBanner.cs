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

        protected override Ingredient[] Ingredients => new Ingredient[] {
            new(ItemID.PresentMimicBanner),
            new(ItemID.FlockoBanner),
            new(ItemID.GingerbreadManBanner),
            new(ItemID.ZombieElfBanner),
            new(ItemID.ElfArcherBanner),
            new(ItemID.NutcrackerBanner),
            new(ItemID.YetiBanner),
            new(ItemID.ElfCopterBanner),
            new(ItemID.KrampusBanner),
        };
    }
}
