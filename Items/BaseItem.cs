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
        protected abstract Ingredient[] Ingredients { get; }
        protected abstract int CraftingStation { get; }

        public override void SetStaticDefaults() {
            DisplayName.SetDefault(DisplayNameTranslation);
            Tooltip.SetDefault(TooltipTranslation);
        }

        public override void SetDefaults() {
            Item.value = SellPrice;
            Item.rare = Rarity;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();

            foreach(Ingredient ingredient in Ingredients) {
                recipe.AddIngredient(ingredient.ID, ingredient.Stack);
            }

            recipe.AddTile(CraftingStation);
            recipe.Register();
        }
    }
}
