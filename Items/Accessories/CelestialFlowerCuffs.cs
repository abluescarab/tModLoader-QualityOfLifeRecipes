using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class CelestialFlowerCuffs : AccessoryItem {
        protected override AccessoryEffect[] Effects => null;
        protected override int SellPrice => Item.sellPrice(0, 5, 0, 0);
        protected override int Rarity => ItemRarityID.LightPurple;

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.CelestialCuffs),
                new(ItemID.ManaFlower)
            );
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            // celestial cuffs
            player.manaMagnet = true;
            player.magicCuffs = true;
            // mana flower
            player.manaFlower = true;
            player.manaCost -= 0.08f;
        }
    }
}
