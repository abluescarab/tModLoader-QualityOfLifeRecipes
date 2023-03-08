using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class MartianMadnessBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault(Language.GetTextValue("Mods.QualityOfLifeRecipes.Placeable.Banners.Events.MartianMadnessBanner_Name"));
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Scutlix, Tesla Turret, Gigazapper, Ray Gunner, Gray Grunt, Brain Scrambler,\n" +
                "Martian Walker, Martian Drone, Martian Engineer, Martian Officer");
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 0, 25, 0);
            Item.rare = ItemRarityID.Green;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Banners.Events.MartianMadnessBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.ScutlixBanner);
            recipe.AddIngredient(ItemID.MartianScutlixGunnerBanner);
            recipe.AddIngredient(ItemID.MartianWalkerBanner);
            recipe.AddIngredient(ItemID.MartianDroneBanner);
            recipe.AddIngredient(ItemID.MartianTeslaTurretBanner);
            recipe.AddIngredient(ItemID.MartianGigazapperBanner);
            recipe.AddIngredient(ItemID.MartianEngineerBanner);
            recipe.AddIngredient(ItemID.MartianOfficerBanner);
            recipe.AddIngredient(ItemID.MartianRaygunnerBanner);
            recipe.AddIngredient(ItemID.MartianGreyGruntBanner);
            recipe.AddIngredient(ItemID.MartianBrainscramblerBanner);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
