using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class PirateCrewBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.PirateCrewBanner}");
            Tooltip.SetDefault(
                "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.Parrot}, {$NPCName.PirateCaptain}, {$NPCName.PirateCorsair}, {$NPCName.PirateCrossbower},\n" +
                "{$NPCName.PirateDeadeye}, {$NPCName.PirateDeckhand}");
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
            Item.createTile = ModContent.TileType<Tiles.Banners.Events.PirateCrewBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.ParrotBanner);
            recipe.AddIngredient(ItemID.PirateCaptainBanner);
            recipe.AddIngredient(ItemID.PirateBanner);
            recipe.AddIngredient(ItemID.PirateCorsairBanner);
            recipe.AddIngredient(ItemID.PirateCrossbowerBanner);
            recipe.AddIngredient(ItemID.PirateDeadeyeBanner);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
