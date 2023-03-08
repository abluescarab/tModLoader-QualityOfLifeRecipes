using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class GoblinArmyBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.GoblinArmyBanner_Name}");
            Tooltip.SetDefault(
                "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.GoblinArcher}, {$NPCName.GoblinPeon}, {$NPCName.GoblinSorcerer}, {$NPCName.GoblinThief},\n" +
                "{$NPCName.GoblinWarrior}");
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
            Item.createTile = ModContent.TileType<Tiles.Banners.Events.GoblinArmyBanner>();
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
