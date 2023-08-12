using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class CloudOfBalloons : AccessoryItem {
        protected override AccessoryEffect[] Effects => new AccessoryEffect[] {
            AccessoryEffect.FartInABalloon,
            AccessoryEffect.HoneyBalloon,
            AccessoryEffect.SharkronBalloon,
            AccessoryEffect.BundleOfBalloons
        };

        protected override int SellPrice => Item.sellPrice(0, 11, 0, 0);
        protected override int Rarity => ItemRarityID.Cyan;

        public override void AddRecipes() {
            AddRecipe(
                new(ModContent.ItemType<BunchOfBalloons>()),
                new(ItemID.BundleofBalloons)
            );
        }
    }
}
