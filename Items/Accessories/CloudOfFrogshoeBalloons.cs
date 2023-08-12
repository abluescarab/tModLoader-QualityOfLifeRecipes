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

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 13, 0, 0);
            Item.rare = ItemRarityID.Red;
            Item.accessory = true;
        }
    }
}
