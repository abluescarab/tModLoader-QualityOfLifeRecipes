using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class SweetStarVeil : AccessoryItem {
        protected override AccessoryEffect[] Effects => null;

        protected override string DisplayNameTranslation => 
            "{$Mods.QualityOfLifeRecipes.Accessories.SweetStarVeil}";

        protected override string TooltipTranslation =>
            "{$ItemTooltip.SweetheartNecklace}" + "\n" +
                "{$ItemTooltip.StarVeil}";

        protected override int SellPrice => Item.sellPrice(0, 4, 0, 0);

        protected override int Rarity => ItemRarityID.Lime;

        protected override Ingredient[] Ingredients => new Ingredient[] {
            new(ItemID.SweetheartNecklace),
            new(ItemID.StarVeil),
        };

        public override void UpdateAccessory(Player player, bool hideVisual) {
            // star veil
            player.starCloakItem = Item;
            player.longInvince = true;
            player.starCloakItem_starVeilOverrideItem = Item;
            // sweetheart necklace
            player.honeyCombItem = Item;
            player.panic = true;
        }
    }
}
