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
            Item.value = Item.sellPrice(0, 0, 15, 0);
            Item.rare = ItemRarityID.Green;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType < Tiles.Banners.Events.SolarEclipseBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.FrankensteinBanner);
            recipe.AddIngredient(ItemID.SwampThingBanner);
            recipe.AddIngredient(ItemID.VampireBanner);
            recipe.AddIngredient(ItemID.CreatureFromTheDeepBanner);
            recipe.AddIngredient(ItemID.FritzBanner);
            recipe.AddIngredient(ItemID.ThePossessedBanner);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
