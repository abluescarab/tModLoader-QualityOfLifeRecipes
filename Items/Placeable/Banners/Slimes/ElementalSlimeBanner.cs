using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Slimes {
    public class ElementalSlimeBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault(Language.GetTextValue("Mods.QualityOfLifeRecipes.Placeable.Banners.Slimes.ElementalSlimeBanner_Name"));
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Sand Slime, Ice Slime, Jungle Slime, Lava Slime, Spiked Slime");
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
            Item.createTile = ModContent.TileType<Tiles.Banners.Slimes.ElementalSlimeBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SandSlimeBanner);
            recipe.AddIngredient(ItemID.IceSlimeBanner);
            recipe.AddIngredient(ItemID.SpikedIceSlimeBanner);
            recipe.AddIngredient(ItemID.JungleSlimeBanner);
            recipe.AddIngredient(ItemID.SpikedJungleSlimeBanner);
            recipe.AddIngredient(ItemID.LavaSlimeBanner);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
