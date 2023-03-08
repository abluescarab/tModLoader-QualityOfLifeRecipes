using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events.Pillars {
    public class VortexPillarBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.Pillars.VortexPillarBanner}");
            Tooltip.SetDefault(
                "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.VortexRifleman}, {$NPCName.VortexSoldier}, {$NPCName.VortexHornetQueen}, {$NPCName.VortexHornet},\n" +
                "{$NPCName.VortexLarva}");
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 0, 12, 0);
            Item.rare = ItemRarityID.Green;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Banners.Events.Pillars.VortexPillarBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.VortexHornetBanner);
            recipe.AddIngredient(ItemID.VortexHornetQueenBanner);
            recipe.AddIngredient(ItemID.VortexLarvaBanner);
            recipe.AddIngredient(ItemID.VortexRiflemanBanner);
            recipe.AddIngredient(ItemID.VortexSoldierBanner);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
