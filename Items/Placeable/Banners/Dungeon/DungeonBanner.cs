using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Dungeon {
    public class DungeonBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Dungeon Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Angry Bones, Dark Caster, Cursed Skull");
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 0, 10, 0);
            Item.rare = ItemRarityID.Green;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Banners.Dungeon.DungeonBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.AngryBonesBanner);
            recipe.AddIngredient(ItemID.SkeletonMageBanner);
            recipe.AddIngredient(ItemID.CursedSkullBanner);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
