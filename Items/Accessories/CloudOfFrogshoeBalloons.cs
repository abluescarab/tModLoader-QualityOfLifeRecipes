using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class CloudOfFrogshoeBalloons : DeprecatedItem {
        protected override ReplacementItem[] Replacements => new ReplacementItem[] {
            new(ItemID.FrogLeg),
            new(ItemID.LuckyHorseshoe),
            new(ModContent.ItemType<CloudOfBalloons>())
        };

        public override void SetStaticDefaults() {
            DisplayName.SetDefault("{$Mods.QualityOfLifeRecipes.Accessories.CloudOfFrogshoeBalloons}");
            Tooltip.SetDefault(
                "{$ItemTooltip.FrogLeg}\n" +
                "{$ItemTooltip.LuckyHorseshoe}\n" +
                "{$Mods.QualityOfLifeRecipes.General.JumpSixTimes}\n" +
                "{$ItemTooltip.ShinyRedBalloon}\n" +
                "{$ItemTooltip.HoneyComb}");
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 13, 0, 0);
            Item.rare = ItemRarityID.Red;
            Item.accessory = true;
        }
    }
}
