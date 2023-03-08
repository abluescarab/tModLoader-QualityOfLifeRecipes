using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Slimes {
    public class UltimateSlimeBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("{$Mods.QualityOfLifeRecipes.Placeable.Banners.Slimes.UltimateSlimeBanner_Name}");
            Tooltip.SetDefault(
                "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.SandSlime}, {$NPCName.IceSlime}, {$NPCName.JungleSlime}, {$NPCName.LavaSlime},\n" +
                "{$NPCName.SlimeSpiked}, {$NPCName.GreenSlime}, {$NPCName.BlueSlime}, {$NPCName.PurpleSlime},\n" +
                "{$NPCName.RedSlime}, {$NPCName.YellowSlime}, {$NPCName.BlackSlime}");
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 0, 35, 0);
            Item.rare = ItemRarityID.Green;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Banners.Slimes.UltimateSlimeBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<ElementalSlimeBanner>();
            recipe.AddIngredient<SupremeSlimeBanner>();
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
