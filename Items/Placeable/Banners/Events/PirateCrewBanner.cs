using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class PirateCrewBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Pirate Crew Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Parrot, Pirate Captain/Corsair/Crossbower/Deadeye/Deckhand");
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
            item.createTile = mod.TileType("PirateCrewBanner");
            item.placeStyle = 0;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ParrotBanner);
            recipe.AddIngredient(ItemID.PirateCaptainBanner);
            recipe.AddIngredient(ItemID.PirateBanner);
            recipe.AddIngredient(ItemID.PirateCorsairBanner);
            recipe.AddIngredient(ItemID.PirateCrossbowerBanner);
            recipe.AddIngredient(ItemID.PirateDeadeyeBanner);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
