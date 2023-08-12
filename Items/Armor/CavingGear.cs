using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Armor {
    [AutoloadEquip(EquipType.Head)]
    public class CavingGear : DeprecatedItem {
        protected override ReplacementItem[] Replacements => new ReplacementItem[] {
            new ReplacementItem(ItemID.NightVisionHelmet),
            new ReplacementItem(ItemID.SpelunkerPotion, 20)
        };

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 3, 0, 0);
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 8;
        }
    }
}
