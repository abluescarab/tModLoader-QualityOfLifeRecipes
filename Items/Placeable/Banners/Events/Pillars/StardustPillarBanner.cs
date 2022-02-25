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
            Item.value = Item.sellPrice(0, 0, 15, 0);
            Item.rare = ItemRarityID.Green;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType < Tiles.Banners.Events.Pillars.StardustPillarBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.StardustJellyfishBanner);
            recipe.AddIngredient(ItemID.StardustLargeCellBanner);
            recipe.AddIngredient(ItemID.StardustSoldierBanner);
            recipe.AddIngredient(ItemID.StardustSpiderBanner);
            recipe.AddIngredient(ItemID.StardustWormBanner);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
