using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class PumpkinMoonBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Pumpkin Moon Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Scarecrow, Splinterling, Hellhound, Poltergeist, Headless Horseman");
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
            item.createTile = mod.TileType("PumpkinMoonBanner");
            item.placeStyle = 0;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ScarecrowBanner);
            recipe.AddIngredient(ItemID.SplinterlingBanner);
            recipe.AddIngredient(ItemID.HellhoundBanner);
            recipe.AddIngredient(ItemID.PoltergeistBanner);
            recipe.AddIngredient(ItemID.HeadlessHorsemanBanner);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
