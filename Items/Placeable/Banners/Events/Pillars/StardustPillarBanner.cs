using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events.Pillars {
    public class StardustPillarBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Stardust Pillar Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Star Cell, Flow Invader, Twinkle Popper, Milyway Weaver, Stargazer");
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
            item.createTile = mod.TileType("StardustPillarBanner");
            item.placeStyle = 0;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StardustJellyfishBanner);
            recipe.AddIngredient(ItemID.StardustLargeCellBanner);
            recipe.AddIngredient(ItemID.StardustSoldierBanner);
            recipe.AddIngredient(ItemID.StardustSpiderBanner);
            recipe.AddIngredient(ItemID.StardustWormBanner);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
