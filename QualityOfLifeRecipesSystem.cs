using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes {
    internal class QualityOfLifeRecipesSystem : ModSystem {
        private const string GroupGoldCrown = "QOLR:GoldCrown";
        private const string GroupGoldBar = "QOLR:GoldBar";
        private const string GroupIronBar = "QOLR:IronBar";

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
            Recipe wireKiteRecipe = Main.recipe.FirstOrDefault(r => r.HasResult(ItemID.WireKite), null);

            if(wireKiteRecipe != null) {
                wireKiteRecipe.AddIngredient(ItemID.LaserRuler);
            }

            // heart statue recipe
            Recipe rcp = Recipe.Create(ItemID.HeartStatue);
            rcp.AddIngredient(ItemID.LifeCrystal);
            rcp.AddIngredient(ItemID.StoneBlock, 50);
            rcp.AddTile(TileID.HeavyWorkBench);
            rcp.Register();

            // star statue
            rcp = Recipe.Create(ItemID.StarStatue);
            rcp.AddIngredient(ItemID.ManaCrystal, 3);
            rcp.AddIngredient(ItemID.StoneBlock, 50);
            rcp.AddTile(TileID.HeavyWorkBench);
            rcp.Register();

            // queen statue
            rcp = Recipe.Create(ItemID.QueenStatue);
            rcp.AddRecipeGroup(GroupGoldCrown);
            rcp.AddIngredient(ItemID.StoneBlock, 50);
            rcp.AddTile(TileID.HeavyWorkBench);
            rcp.Register();

            // king statue
            rcp = Recipe.Create(ItemID.KingStatue);
            rcp.AddRecipeGroup(GroupGoldCrown);
            rcp.AddIngredient(ItemID.StoneBlock, 50);
            rcp.AddTile(TileID.HeavyWorkBench);
            rcp.Register();

            // sextant
            rcp = Recipe.Create(ItemID.Sextant);
            rcp.AddRecipeGroup(GroupGoldBar, 15);
            rcp.AddIngredient(ItemID.Lens, 5);
            rcp.AddTile(TileID.Tables);
            rcp.AddTile(TileID.Chairs);
            rcp.Register();

            // weather radio
            rcp = Recipe.Create(ItemID.WeatherRadio);
            rcp.AddRecipeGroup(GroupGoldBar, 8);
            rcp.AddRecipeGroup(GroupIronBar, 15);
            rcp.AddIngredient(ItemID.Cloud, 15);
            rcp.AddIngredient(ItemID.SnowBlock, 15);
            rcp.AddTile(TileID.Tables);
            rcp.AddTile(TileID.Chairs);
            rcp.Register();

            // fisherman's guide
            rcp = Recipe.Create(ItemID.FishermansGuide);
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
    }
}
