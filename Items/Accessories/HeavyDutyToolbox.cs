using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class HeavyDutyToolbox : AccessoryItem {
        protected override AccessoryEffect[] Effects => null;
        protected override int SellPrice => Item.sellPrice(0, 3, 0, 0);
        protected override int Rarity => ItemRarityID.LightRed;

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.Toolbox),
                new(ItemID.Toolbelt)
            );
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            // toolbox
            if(player.whoAmI == Main.myPlayer) {
                Player.tileRangeX++;
                Player.tileRangeY++;
            }
            // toolbelt
            player.blockRange++;
        }
    }
}
