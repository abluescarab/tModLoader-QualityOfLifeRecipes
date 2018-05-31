using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class GoblinArmyBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Goblin Army Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Goblin Archers, Goblin Peons, Goblin Sorcerers, Goblin Thieves, Goblin Warriors");
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 0, 12, 0);
            item.rare = 2;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("GoblinArmyBanner");
            item.placeStyle = 0;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoblinArcherBanner);
            recipe.AddIngredient(ItemID.GoblinPeonBanner);
            recipe.AddIngredient(ItemID.GoblinSorcererBanner);
            recipe.AddIngredient(ItemID.GoblinThiefBanner);
            recipe.AddIngredient(ItemID.GoblinWarriorBanner);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
