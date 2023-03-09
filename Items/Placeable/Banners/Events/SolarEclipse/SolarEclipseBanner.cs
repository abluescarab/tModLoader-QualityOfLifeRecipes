using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events.SolarEclipse {
    public class SolarEclipseBanner : BannerItem<SolarEclipseBanner, Tiles.Banners.Events.SolarEclipse.SolarEclipseBanner> {
        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.SolarEclipseBanner}";

        protected override string TooltipTranslation =>
            "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.Frankenstein}, {$NPCName.SwampThing}, {$NPCName.Vampire}, {$NPCName.CreatureFromTheDeep},\n" +
                "{$NPCName.Fritz}, {$NPCName.ThePossessed}";

        protected override int SellPrice => Item.sellPrice(0, 0, 15, 0);

        protected override Ingredient[] Ingredients => new Ingredient[] {
            new(ItemID.FrankensteinBanner),
            new(ItemID.SwampThingBanner),
            new(ItemID.VampireBanner),
            new(ItemID.CreatureFromTheDeepBanner),
            new(ItemID.FritzBanner),
            new(ItemID.ThePossessedBanner),
        };
    }
}
