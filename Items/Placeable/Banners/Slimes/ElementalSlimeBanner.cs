using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Slimes {
    public class ElementalSlimeBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Elemental Slime Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Sand Slime, Ice Slime, Jungle Slime, Lava Slime, Spiked Slime");
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 0, 15, 0);
            item.rare = 2;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("ElementalSlimeBanner");
            item.placeStyle = 0;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SandSlimeBanner);
            recipe.AddIngredient(ItemID.IceSlimeBanner);
            recipe.AddIngredient(ItemID.SpikedIceSlimeBanner);
            recipe.AddIngredient(ItemID.JungleSlimeBanner);
            recipe.AddIngredient(ItemID.SpikedJungleSlimeBanner);
            recipe.AddIngredient(ItemID.LavaSlimeBanner);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
