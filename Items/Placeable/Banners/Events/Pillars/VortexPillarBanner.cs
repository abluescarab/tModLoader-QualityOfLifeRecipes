using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events.Pillars {
    public class VortexPillarBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Vortex Pillar Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Storm Diver, Vortexian, Alien Queen, Alien Hornet, Alien Larva");
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
            item.createTile = mod.TileType("VortexPillarBanner");
            item.placeStyle = 0;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.VortexHornetBanner);
            recipe.AddIngredient(ItemID.VortexHornetQueenBanner);
            recipe.AddIngredient(ItemID.VortexLarvaBanner);
            recipe.AddIngredient(ItemID.VortexRiflemanBanner);
            recipe.AddIngredient(ItemID.VortexSoldierBanner);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
