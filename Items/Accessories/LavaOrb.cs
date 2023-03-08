using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class LavaOrb : DeprecatedItem {
        protected override ReplacementItem[] Replacements => new ReplacementItem[] {
            new ReplacementItem(ItemID.LavaCharm, prefix: Item.prefix),
            new ReplacementItem(ItemID.ObsidianRose, prefix: Item.prefix)
        };

        public override void SetStaticDefaults() {
            DisplayName.SetDefault(Language.GetTextValue("Mods.QualityOfLifeRecipes.Accessories.LavaOrb_Name"));
            Tooltip.SetDefault(
                Language.GetTextValue("ItemTooltip.LavaCharm") + "\n" +
                Language.GetTextValue("ItemTooltip.ObsidianRose"));
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 10, 0, 0);
            Item.rare = ItemRarityID.LightRed;
            Item.accessory = true;
        }
    }
}
