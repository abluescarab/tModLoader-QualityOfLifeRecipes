using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes {
    public class QualityOfLifeRecipes : Mod {
        private const string GROUP_GOLD_CROWN = "QOLR:GoldCrown";
        private const string GROUP_GOLD_BAR = "QOLR:GoldBar";
        private const string GROUP_IRON_BAR = "QOLR:IronBar";

        public QualityOfLifeRecipes() {
            Properties = new ModProperties() {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }

        public override void AddRecipeGroups() {
            string any = Language.GetText("LegacyMisc.37").Value;

            RecipeGroup GoldCrown = new RecipeGroup(() => any + Language.GetText("ItemName.GoldCrown"),
                new int[] { ItemID.GoldCrown, ItemID.PlatinumCrown });
            RecipeGroup GoldBar = new RecipeGroup(() => any + " " + Language.GetText("ItemName.GoldBar"),
                new int[] { ItemID.GoldBar, ItemID.PlatinumBar });
            RecipeGroup IronBar = new RecipeGroup(() => any + " " + Language.GetText("ItemName.IronBar"),
                new int[] { ItemID.IronBar, ItemID.LeadBar });

            RecipeGroup.RegisterGroup(GROUP_GOLD_CROWN, GoldCrown);
            RecipeGroup.RegisterGroup(GROUP_GOLD_BAR, GoldBar);
            RecipeGroup.RegisterGroup(GROUP_IRON_BAR, IronBar);
        }

        public override void AddRecipes() {
            RecipeFinder finder = new RecipeFinder();
            finder.SetResult(ItemID.WireKite);

            foreach(Recipe recipe in finder.SearchRecipes()) {
                RecipeEditor editor = new RecipeEditor(recipe);
                editor.AddIngredient(ItemID.LaserRuler);
            }

            // heart statue recipe
            ModRecipe rcp = new ModRecipe(this);
            rcp.AddIngredient(ItemID.LifeCrystal);
            rcp.AddIngredient(ItemID.StoneBlock, 50);
            rcp.AddTile(TileID.HeavyWorkBench);
            rcp.SetResult(ItemID.HeartStatue);
            rcp.AddRecipe();

            // star statue
            rcp = new ModRecipe(this);
            rcp.AddIngredient(ItemID.ManaCrystal, 3);
            rcp.AddIngredient(ItemID.StoneBlock, 50);
            rcp.AddTile(TileID.HeavyWorkBench);
            rcp.SetResult(ItemID.StarStatue);
            rcp.AddRecipe();

            // queen statue
            rcp = new ModRecipe(this);
            rcp.AddRecipeGroup(GROUP_GOLD_CROWN);
            rcp.AddIngredient(ItemID.StoneBlock, 50);
            rcp.AddTile(TileID.HeavyWorkBench);
            rcp.SetResult(ItemID.QueenStatue);
            rcp.AddRecipe();

            // king statue
            rcp = new ModRecipe(this);
            rcp.AddRecipeGroup(GROUP_GOLD_CROWN);
            rcp.AddIngredient(ItemID.StoneBlock, 50);
            rcp.AddTile(TileID.HeavyWorkBench);
            rcp.SetResult(ItemID.KingStatue);
            rcp.AddRecipe();

            // sextant
            rcp = new ModRecipe(this);
            rcp.AddRecipeGroup(GROUP_GOLD_BAR, 15);
            rcp.AddIngredient(ItemID.Lens, 5);
            rcp.AddTile(TileID.Tables);
            rcp.AddTile(TileID.Chairs);
            rcp.SetResult(ItemID.Sextant);
            rcp.AddRecipe();

            // weather radio
            rcp = new ModRecipe(this);
            rcp.AddRecipeGroup(GROUP_GOLD_BAR, 8);
            rcp.AddRecipeGroup(GROUP_IRON_BAR, 15);
            rcp.AddIngredient(ItemID.Cloud, 15);
            rcp.AddIngredient(ItemID.SnowBlock, 15);
            rcp.AddTile(TileID.Tables);
            rcp.AddTile(TileID.Chairs);
            rcp.SetResult(ItemID.WeatherRadio);
            rcp.AddRecipe();

            // fisherman's guide
            rcp = new ModRecipe(this);
            rcp.AddIngredient(ItemID.Book);
            rcp.AddIngredient(ItemID.ArmoredCavefish);
            rcp.AddIngredient(ItemID.SpecularFish);
            rcp.AddIngredient(ItemID.NeonTetra);
            rcp.AddIngredient(ItemID.Bass);
            rcp.AddIngredient(ItemID.Trout);
            rcp.AddIngredient(ItemID.AtlanticCod);
            rcp.AddTile(TileID.Bookcases);
            rcp.SetResult(ItemID.FishermansGuide);
            rcp.AddRecipe();
        }
    }
}
