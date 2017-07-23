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
            item.value = Item.sellPrice(0, 0, 10, 0);
            item.rare = 2;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("NebulaPillarBanner");
            item.placeStyle = 0;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.NebulaBeastBanner);
            recipe.AddIngredient(ItemID.NebulaBrainBanner);
            recipe.AddIngredient(ItemID.NebulaHeadcrabBanner);
            recipe.AddIngredient(ItemID.NebulaSoldierBanner);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
