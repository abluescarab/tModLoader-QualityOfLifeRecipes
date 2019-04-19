using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class GlobalTheGrandDesign : GlobalItem {
        public override void UpdateInventory(Item item, Player player) {
            if(player.HasItem(ItemID.WireKite) && item.type == ItemID.WireKite) {
                player.InfoAccMechShowWires = true;
                player.rulerLine = true;
                player.rulerGrid = true;
            }
        }
    }
}
