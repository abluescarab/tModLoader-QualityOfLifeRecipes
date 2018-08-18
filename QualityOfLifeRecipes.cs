using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes {
    public class QualityOfLifeRecipes : Mod {
        private const string GroupGoldCrown = "QOLR:GoldCrown";
        private const string GroupGoldBar = "QOLR:GoldBar";
        private const string GroupIronBar = "QOLR:IronBar";

        public QualityOfLifeRecipes() {
            Properties = new ModProperties() {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }

        public override void AddRecipeGroups() {
            string any = Language.GetText("LegacyMisc.37").Value;

            RecipeGroup goldCrown = new RecipeGroup(() => any + Language.GetText("ItemName.GoldCrown"), 
                ItemID.GoldCrown, ItemID.PlatinumCrown);
            RecipeGroup goldBar = new RecipeGroup(() => any + " " + Language.GetText("ItemName.GoldBar"), 
                ItemID.GoldBar, ItemID.PlatinumBar);
            RecipeGroup ironBar = new RecipeGroup(() => any + " " + Language.GetText("ItemName.IronBar"), 
                ItemID.IronBar, ItemID.LeadBar);

            RecipeGroup.RegisterGroup(GroupGoldCrown, goldCrown);
            RecipeGroup.RegisterGroup(GroupGoldBar, goldBar);
            RecipeGroup.RegisterGroup(GroupIronBar, ironBar);
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
            rcp.AddRecipeGroup(GroupGoldCrown);
            rcp.AddIngredient(ItemID.StoneBlock, 50);
            rcp.AddTile(TileID.HeavyWorkBench);
            rcp.SetResult(ItemID.QueenStatue);
            rcp.AddRecipe();

            // king statue
            rcp = new ModRecipe(this);
            rcp.AddRecipeGroup(GroupGoldCrown);
            rcp.AddIngredient(ItemID.StoneBlock, 50);
            rcp.AddTile(TileID.HeavyWorkBench);
            rcp.SetResult(ItemID.KingStatue);
            rcp.AddRecipe();

            // sextant
            rcp = new ModRecipe(this);
            rcp.AddRecipeGroup(GroupGoldBar, 15);
            rcp.AddIngredient(ItemID.Lens, 5);
            rcp.AddTile(TileID.Tables);
            rcp.AddTile(TileID.Chairs);
            rcp.SetResult(ItemID.Sextant);
            rcp.AddRecipe();

            // weather radio
            rcp = new ModRecipe(this);
            rcp.AddRecipeGroup(GroupGoldBar, 8);
            rcp.AddRecipeGroup(GroupIronBar, 15);
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
