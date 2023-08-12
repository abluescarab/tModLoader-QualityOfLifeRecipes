using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class CloudOfHorseshoeBalloons : AccessoryItem {
        protected override AccessoryEffect[] Effects => new AccessoryEffect[] {
            AccessoryEffect.FartInABalloon,
            AccessoryEffect.HoneyBalloon,
            AccessoryEffect.SharkronBalloon,
            AccessoryEffect.BundleOfBalloons,
            AccessoryEffect.LuckyHorseshoe
        };

        protected override int SellPrice => Item.sellPrice(0, 12, 0, 0);
        protected override int Rarity => ItemRarityID.Cyan;

        public override void AddRecipes() {
            AddRecipe(
                new(ModContent.ItemType<CloudOfBalloons>()),
                new(ItemID.LuckyHorseshoe)
            );
        }
    }
}
