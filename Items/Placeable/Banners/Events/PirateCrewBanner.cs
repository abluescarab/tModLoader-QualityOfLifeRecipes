using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class PirateCrewBanner : BannerItem<PirateCrewBanner, Tiles.Banners.Events.PirateCrewBanner> {
        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.PirateCrewBanner}";

        protected override string TooltipTranslation =>
            "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.Parrot}, {$NPCName.PirateCaptain}, {$NPCName.PirateCorsair}, {$NPCName.PirateCrossbower},\n" +
                "{$NPCName.PirateDeadeye}, {$NPCName.PirateDeckhand}";

        protected override int SellPrice => Item.sellPrice(0, 0, 15, 0);

        protected override Ingredient[] Ingredients => new Ingredient[] {
            new(ItemID.ParrotBanner),
            new(ItemID.PirateCaptainBanner),
            new(ItemID.PirateBanner),
            new(ItemID.PirateCorsairBanner),
            new(ItemID.PirateCrossbowerBanner),
            new(ItemID.PirateDeadeyeBanner),
        };
    }
}
