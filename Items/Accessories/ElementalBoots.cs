using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class ElementalBoots : DeprecatedItem {
        protected override ReplacementItem[] Replacements => new ReplacementItem[] {
            new ReplacementItem(ItemID.TerrasparkBoots, prefix: Item.prefix)
        };

        public override void SetStaticDefaults() {
            DisplayName.SetDefault(Language.GetTextValue("Mods.QualityOfLifeRecipes.Accessories.ElementalBoots_Name"));
            Tooltip.SetDefault(
                Language.GetTextValue("ItemTooltip.FrostsparkBoots") + "\n" +
                Language.GetTextValue("ItemTooltip.LavaWaders"));
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 20, 0, 0);
            Item.rare = ItemRarityID.Yellow;
            Item.accessory = true;
        }
    }
}
