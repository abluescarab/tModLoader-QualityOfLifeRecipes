using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class Frogshoe : DeprecatedItem {
        protected override ReplacementItem[] Replacements => new ReplacementItem[] {
            new ReplacementItem(ItemID.FrogLeg),
            new ReplacementItem(ItemID.LuckyHorseshoe)
        };

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.rare = ItemRarityID.Green;
            Item.accessory = true;
        }
    }
}
