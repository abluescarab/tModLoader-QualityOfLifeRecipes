using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Armor {
    [AutoloadEquip(EquipType.Head)]
    public class OrangeTintedGoggles : DeprecatedItem {
        protected override ReplacementItem[] Replacements => new ReplacementItem[] {
            new ReplacementItem(ItemID.Goggles),
            new ReplacementItem(ItemID.HunterPotion, 20),
            new ReplacementItem(ItemID.TrapsightPotion, 20),
        };

        public override void SetStaticDefaults() {
            DisplayName.SetDefault("{$Mods.QualityOfLifeRecipes.Armor.OrangeTintedGoggles}");
            Tooltip.SetDefault(
                "{$ItemTooltip.HunterPotion}" + "\n" +
                "{$ItemTooltip.TrapsightPotion}");
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 1, 0, 0);
            Item.rare = ItemRarityID.Green;
            Item.defense = 2;
        }
    }
}
