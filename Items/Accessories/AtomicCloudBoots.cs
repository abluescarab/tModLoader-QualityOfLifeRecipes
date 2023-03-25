using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class AtomicCloudBoots : AccessoryItem {
        protected override AccessoryEffect[] Effects => new AccessoryEffect[] {
            AccessoryEffect.TerrasparkBoots,
            AccessoryEffect.FrogFlipper,
            AccessoryEffect.MasterNinjaGear,
            AccessoryEffect.Magiluminescence,
            AccessoryEffect.FlowerBoots,
            AccessoryEffect.FartInABalloon,
            AccessoryEffect.HoneyBalloon,
            AccessoryEffect.SharkronBalloon,
            AccessoryEffect.BundleOfBalloons,
            AccessoryEffect.LuckyHorseshoe
        };

        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Accessories.AtomicCloudBoots}";

        protected override string TooltipTranslation =>
            "{$ItemTooltip.TerrasparkBoots}\n" +
            "{$ItemTooltip.FrogFlipper}\n" +
            "{$ItemTooltip.MasterNinjaGear}\n" +
            "{$ItemTooltip.Magiluminescence}\n" +
            "{$ItemTooltip.FlowerBoots}\n" +
            "{$ItemTooltip.LuckyHorseshoe}\n" +
            "{$Mods.QualityOfLifeRecipes.General.JumpSixTimes}\n" +
            "{$ItemTooltip.ShinyRedBalloon}\n" +
            "{$ItemTooltip.HoneyComb}";

        protected override int SellPrice => Item.sellPrice(0, 42, 0, 0);

        protected override int Rarity => ItemRarityID.Purple;

        public override void AddRecipes() {
            AddRecipe(
                new(ModContent.ItemType<AtomicNinjaBoots>()),
                new(ModContent.ItemType<CloudOfHorseshoeBalloons>())
            );
        }
    }
}
