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

            ContentAutoloadingEnabled = true;
            GoreAutoloadingEnabled = true;
            SoundAutoloadingEnabled = true;
        }

        public override void PostSetupContent() {

            Mod wikiSearch ;

            if (ModLoader.TryGetMod("WikiSearch", out wikiSearch)) {
                wikiSearch.Call("RegisterMod", this, "https://github.com/abluescarab/tModLoader-QualityOfLifeRecipes/wiki/%s");
            }
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
   
            // heart statue recipe
            Recipe rcp = CreateRecipe(ItemID.HeartStatue);
            rcp.AddIngredient(ItemID.LifeCrystal);
            rcp.AddIngredient(ItemID.StoneBlock, 50);
            rcp.AddTile(TileID.HeavyWorkBench);
            rcp.Register();

            // star statue
            rcp = CreateRecipe(ItemID.StarStatue); 
            rcp.AddIngredient(ItemID.ManaCrystal, 3);
            rcp.AddIngredient(ItemID.StoneBlock, 50);
            rcp.AddTile(TileID.HeavyWorkBench);
            rcp.Register();

            // queen statue
            rcp = CreateRecipe(ItemID.QueenStatue);
            rcp.AddRecipeGroup(GroupGoldCrown);
            rcp.AddIngredient(ItemID.StoneBlock, 50);
            rcp.AddTile(TileID.HeavyWorkBench);
            rcp.Register();

            // king statue
            rcp = CreateRecipe(ItemID.KingStatue);
            rcp.AddRecipeGroup(GroupGoldCrown);
            rcp.AddIngredient(ItemID.StoneBlock, 50);
            rcp.AddTile(TileID.HeavyWorkBench);
            rcp.Register();

            // sextant
            rcp = CreateRecipe(ItemID.Sextant);
            rcp.AddRecipeGroup(GroupGoldBar, 15);
            rcp.AddIngredient(ItemID.Lens, 5);
            rcp.AddTile(TileID.Tables);
            rcp.AddTile(TileID.Chairs);
            rcp.Register();

            // weather radio
            rcp = CreateRecipe(ItemID.WeatherRadio);
            rcp.AddRecipeGroup(GroupGoldBar, 8);
            rcp.AddRecipeGroup(GroupIronBar, 15);
            rcp.AddIngredient(ItemID.Cloud, 15);
            rcp.AddIngredient(ItemID.SnowBlock, 15);
            rcp.AddTile(TileID.Tables);
            rcp.AddTile(TileID.Chairs);
            rcp.Register();

            // fisherman's guide
            rcp = CreateRecipe(ItemID.FishermansGuide);
            rcp.AddIngredient(ItemID.Book);
            rcp.AddIngredient(ItemID.ArmoredCavefish);
            rcp.AddIngredient(ItemID.SpecularFish);
            rcp.AddIngredient(ItemID.NeonTetra);
            rcp.AddIngredient(ItemID.Bass);
            rcp.AddIngredient(ItemID.Trout);
            rcp.AddIngredient(ItemID.AtlanticCod);
            rcp.AddTile(TileID.Bookcases);
            rcp.Register();
        }


        public override void PostAddRecipes()
        {

            Recipe[] Recipes = System.Array.FindAll(Main.recipe,r => r.HasResult(ItemID.WireKite));
            foreach (Recipe recipe in Recipes)
            {
                recipe.AddIngredient(ItemID.LaserRuler);
            }


        }
    }


}
