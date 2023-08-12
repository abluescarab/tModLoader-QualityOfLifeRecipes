using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class LifeforceBracelet : AccessoryItem {
        protected override AccessoryEffect[] Effects => null;
        protected override int SellPrice => Item.sellPrice(0, 5, 0, 0);
        protected override int Rarity => ItemRarityID.Lime;

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.CharmofMyths),
                new(ItemID.ManaRegenerationBand)
            );
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            // charm of myths
            player.pStone = true;
            // mana regeneration band
            player.statManaMax2 += 20;
            player.manaRegenDelayBonus += 1f;
            player.manaRegenBonus += 25;
        }
    }
}
