using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events.Pillars {
    public class NebulaPillarBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Nebula Pillar Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Brain Suckler, Evolution Beast, Nebula Floater, Predictor");
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
            Item.createTile = ModContent.TileType < Tiles.Banners.Events.Pillars.NebulaPillarBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.NebulaBeastBanner);
            recipe.AddIngredient(ItemID.NebulaBrainBanner);
            recipe.AddIngredient(ItemID.NebulaHeadcrabBanner);
            recipe.AddIngredient(ItemID.NebulaSoldierBanner);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
