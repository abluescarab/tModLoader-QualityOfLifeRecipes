using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class PumpkinMoonBanner : BannerItem<PumpkinMoonBanner, Tiles.Banners.Events.PumpkinMoonBanner> {
        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.PumpkinMoonBanner}";

        protected override string TooltipTranslation =>
            "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.Scarecrow1}, {$NPCName.Splinterling}, {$NPCName.Hellhound}, {$NPCName.Poltergeist},\n" +
                "{$NPCName.HeadlessHorseman}";

        protected override int SellPrice => Item.sellPrice(0, 0, 12, 0);

        protected override Ingredient[] Ingredients => new Ingredient[] {
            new(ItemID.ScarecrowBanner),
            new(ItemID.SplinterlingBanner),
            new(ItemID.HellhoundBanner),
            new(ItemID.PoltergeistBanner),
            new(ItemID.HeadlessHorsemanBanner),
        };
    }
}
