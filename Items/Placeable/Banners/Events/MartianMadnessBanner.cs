using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class MartianMadnessBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Martian Madness Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Scutlix, Tesla Turret, Gigazapper, Ray Gunner, Gray Grunt, Brain Scrambler,\n" +
                "Martian Walker, Martian Drone, Martian Engineer, Martian Officer");
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 0, 25, 0);
            item.rare = 2;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("MartianMadnessBanner");
            item.placeStyle = 0;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
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
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
