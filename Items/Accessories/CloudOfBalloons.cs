using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class CloudOfBalloons : AccessoryItem {
        protected override AccessoryEffect[] Effects => new AccessoryEffect[] {
            AccessoryEffect.FartInABalloon,
            AccessoryEffect.HoneyBalloon,
            AccessoryEffect.SharkronBalloon,
            AccessoryEffect.BundleOfBalloons
        };

        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Accessories.CloudOfBalloons}";

        protected override string TooltipTranslation =>
            "{$Mods.QualityOfLifeRecipes.General.JumpSixTimes}" + "\n" +
                "{$ItemTooltip.ShinyRedBalloon}" + "\n" +
                "{$ItemTooltip.HoneyComb}";

        protected override int SellPrice => Item.sellPrice(0, 11, 0, 0);

        protected override int Rarity => ItemRarityID.Cyan;

        protected override Ingredient[] Ingredients => new Ingredient[] {
            new(ModContent.ItemType<BunchOfBalloons>()),
            new(ItemID.BundleofBalloons),
        };
    }
}
