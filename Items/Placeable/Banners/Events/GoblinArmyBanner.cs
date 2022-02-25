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
            Item.value = Item.sellPrice(0, 0, 12, 0);
            Item.rare = ItemRarityID.Green;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType < Tiles.Banners.Events.GoblinArmyBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.GoblinArcherBanner);
            recipe.AddIngredient(ItemID.GoblinPeonBanner);
            recipe.AddIngredient(ItemID.GoblinSorcererBanner);
            recipe.AddIngredient(ItemID.GoblinThiefBanner);
            recipe.AddIngredient(ItemID.GoblinWarriorBanner);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
