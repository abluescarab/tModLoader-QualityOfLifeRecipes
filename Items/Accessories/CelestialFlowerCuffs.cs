using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class CelestialFlowerCuffs : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Celestial Flower Cuffs");
            Tooltip.SetDefault(
                "Restores mana when damaged\n" +
                "Increases pickup range for stars\n" + 
                "8% reduced mana usage\n" +
                "Automatically use mana potions when needed");
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.rare = 6;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            // celestial cuffs
            player.manaMagnet = true;
            player.magicCuffs = true;
            // mana flower
            player.manaFlower = true;
            player.manaCost -= 0.08f;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CelestialCuffs);
            recipe.AddIngredient(ItemID.ManaFlower);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
