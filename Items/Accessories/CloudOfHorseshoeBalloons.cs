using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class CloudOfHorseshoeBalloons : AccessoryItem {
        protected override AccessoryEffect[] Effects => new AccessoryEffect[] {
            AccessoryEffect.FartInABalloon,
            AccessoryEffect.HoneyBalloon,
            AccessoryEffect.SharkronBalloon,
            AccessoryEffect.BundleOfBalloons,
            AccessoryEffect.LuckyHorseshoe
        };

        protected override string DisplayNameTranslation => 
            "{$Mods.QualityOfLifeRecipes.Accessories.CloudOfHorseshoeBalloons}";

        protected override string TooltipTranslation =>
            "{$Mods.QualityOfLifeRecipes.General.JumpSixTimes}\n" +
                "{$ItemTooltip.LuckyHorseshoe}\n" +
                "{$ItemTooltip.ShinyRedBalloon}\n" +
                "{$ItemTooltip.HoneyComb}";

        protected override int SellPrice => Item.sellPrice(0, 12, 0, 0);

        protected override int Rarity => ItemRarityID.Cyan;

        public override void AddRecipes() {
            AddRecipe(
                new(ModContent.ItemType<CloudOfBalloons>()),
                new(ItemID.LuckyHorseshoe)
            );
        }
    }
}
