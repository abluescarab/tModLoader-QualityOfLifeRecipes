using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class SolarEclipseBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Solar Eclipse Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Frankenstein, Swamp Thing, Vampire, Creature from the Deep, Fritz, The Possessed");
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
            item.createTile = mod.TileType("SolarEclipseBanner");
            item.placeStyle = 0;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FrankensteinBanner);
            recipe.AddIngredient(ItemID.SwampThingBanner);
            recipe.AddIngredient(ItemID.VampireBanner);
            recipe.AddIngredient(ItemID.CreatureFromTheDeepBanner);
            recipe.AddIngredient(ItemID.FritzBanner);
            recipe.AddIngredient(ItemID.ThePossessedBanner);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
