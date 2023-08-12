using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class LavaOrb : DeprecatedItem {
        protected override ReplacementItem[] Replacements => new ReplacementItem[] {
            new ReplacementItem(ItemID.LavaCharm, prefix: Item.prefix),
            new ReplacementItem(ItemID.ObsidianRose, prefix: Item.prefix)
        };

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 10, 0, 0);
            Item.rare = ItemRarityID.LightRed;
            Item.accessory = true;
        }
    }
}
