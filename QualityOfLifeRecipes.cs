using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes {
    public class QualityOfLifeRecipes : Mod {
        public QualityOfLifeRecipes() {
            Properties = new ModProperties() {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }

        public override void AddRecipes() {
            RecipeFinder finder = new RecipeFinder();
            finder.SetResult(ItemID.WireKite);

            foreach(Recipe recipe in finder.SearchRecipes()) {
                RecipeEditor editor = new RecipeEditor(recipe);
                editor.AddIngredient(ItemID.LaserRuler);
            }
        }
    }
}
