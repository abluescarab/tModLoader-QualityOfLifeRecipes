using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events.SolarEclipse {
    public class SupremeSolarEclipseBanner : BannerItem<SupremeSolarEclipseBanner, Tiles.Banners.Events.SolarEclipse.SupremeSolarEclipseBanner> {
        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.SupremeSolarEclipseBanner}";

        protected override string TooltipTranslation =>
            "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.Frankenstein}, {$NPCName.SwampThing}, {$NPCName.Vampire}, {$NPCName.CreatureFromTheDeep},\n" +
                "{$NPCName.Fritz}, {$NPCName.ThePossessed} {$NPCName.Eyezor}, {$NPCName.Reaper},\n" +
                "{$NPCName.Butcher}, {$NPCName.DeadlySphere}, {$NPCName.DrManFly}, {$NPCName.Nailhead},\n" +
                "{$NPCName.Psycho}";

        protected override int SellPrice => Item.sellPrice(0, 0, 30, 0);

        protected override Ingredient[] Ingredients => new Ingredient[] {
            new(ModContent.ItemType<SolarEclipseBanner>()),
            new(ItemID.EyezorBanner),
            new(ItemID.ReaperBanner),
            new(ItemID.ButcherBanner),
            new(ItemID.DeadlySphereBanner),
            new(ItemID.DrManFlyBanner),
            new(ItemID.NailheadBanner),
            new(ItemID.PsychoBanner),
        };
    }
}
