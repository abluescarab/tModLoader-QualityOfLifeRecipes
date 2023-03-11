using Terraria;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items {
    public abstract class BaseItem : ModItem {
        protected struct Ingredient {
            public readonly int ID;
            public readonly int Stack;

            public Ingredient(int id, int stack = 1) {
                ID = id;
                Stack = stack;
            }
        }

        protected abstract string DisplayNameTranslation { get; }
        protected abstract string TooltipTranslation { get; }
        protected abstract int SellPrice { get; }
        protected abstract int Rarity { get; }

        public override void SetStaticDefaults() {
            DisplayName.SetDefault(DisplayNameTranslation);
            Tooltip.SetDefault(TooltipTranslation);
        }

        public override void SetDefaults() {
            Item.value = SellPrice;
            Item.rare = Rarity;
        }

        protected void AddRecipe(int craftingStation, params Ingredient[] ingredients) {
            Recipe recipe = CreateRecipe();

            foreach(Ingredient ingredient in ingredients) {
                recipe.AddIngredient(ingredient.ID, ingredient.Stack);
            }

            recipe.AddTile(craftingStation);
            recipe.Register();
        }
    }
}
