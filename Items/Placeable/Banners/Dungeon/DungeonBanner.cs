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
            item.value = Item.sellPrice(0, 0, 10, 0);
            item.rare = 2;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("DungeonBanner");
            item.placeStyle = 0;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AngryBonesBanner);
            recipe.AddIngredient(ItemID.SkeletonMageBanner);
            recipe.AddIngredient(ItemID.CursedSkullBanner);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
