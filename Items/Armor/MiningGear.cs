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

        public override void SetStaticDefaults() {
            DisplayName.SetDefault("{$Mods.QualityOfLifeRecipes.Armor.MiningGear}");
            Tooltip.SetDefault(
                "{$ItemTooltip.NightVisionHelmet}" + "\n" +
                "{$ItemTooltip.SpelunkerPotion}" + "\n" +
                "{$ItemTooltip.MiningHelmet}");
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 5, 0, 0);
            Item.rare = ItemRarityID.Pink;
            Item.defense = 10;
        }
    }
}
