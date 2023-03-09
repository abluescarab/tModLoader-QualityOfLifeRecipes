using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class HeavyDutyToolbox : AccessoryItem {
        protected override AccessoryEffect[] Effects => null;

        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Accessories.HeavyDutyToolbox}";

        protected override string TooltipTranslation =>
            "{$ItemTooltip.Toolbox}" + "\n" +
                "{$ItemTooltip.Toolbelt}";

        protected override int SellPrice => Item.sellPrice(0, 3, 0, 0);

        protected override int Rarity => ItemRarityID.LightRed;

        protected override Ingredient[] Ingredients => new Ingredient[] {
            new(ItemID.Toolbox),
            new(ItemID.Toolbelt),
        };

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
