using QualityOfLifeRecipes.Items.Armor;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class CyberneticMiningMultiTool : AccessoryItem {
        protected override AccessoryEffect[] Effects => null;

        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Accessories.CyberneticMiningMultiTool}";

        protected override string TooltipTranslation =>
            "{$ItemTooltip.UltrabrightHelmet}\n" +
            "{$ItemTooltip.HunterPotion}\n" +
            "{$ItemTooltip.TrapsightPotion}\n" +
            "{$ItemTooltip.SpelunkerPotion}";

        protected override int SellPrice => Item.sellPrice(0, 15, 0, 0);

        protected override int Rarity => ItemRarityID.Lime;

        public override void AddRecipes() {
            AddRecipe(
                new(ModContent.ItemType<UtilityHelmet>()),
                new(ItemID.Nanites, 20)
            );
        }

        public static void ApplyEffects(Player player) {
            UtilityHelmet.ApplyEffects(player);
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            ApplyEffects(player);
        }
    }
}
