using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Armor {
    [AutoloadEquip(EquipType.Head)]
    public class MiningGear : DeprecatedItem {
        protected override ReplacementItem[] Replacements => new ReplacementItem[] {
            new ReplacementItem(ItemID.UltrabrightHelmet),
            new ReplacementItem(ItemID.SpelunkerPotion, 20)
        };

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 5, 0, 0);
            Item.rare = ItemRarityID.Pink;
            Item.defense = 10;
        }
    }
}
