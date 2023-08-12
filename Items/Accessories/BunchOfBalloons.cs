using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class BunchOfBalloons : AccessoryItem {
        protected override AccessoryEffect[] Effects => new AccessoryEffect[] {
            AccessoryEffect.FartInABalloon,
            AccessoryEffect.HoneyBalloon,
            AccessoryEffect.SharkronBalloon
        };

        protected override int SellPrice => Item.sellPrice(0, 8, 0, 0);

        protected override int Rarity => ItemRarityID.Pink;

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.FartInABalloon),
                new(ItemID.HoneyBalloon),
                new(ItemID.SharkronBalloon)
            );
        }
    }
}
