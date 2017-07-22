using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable {
    public class AlterationStation : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Alteration Station");
            Tooltip.SetDefault("Transmutes ores varieties");
        }

        public override void SetDefaults() {
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = false;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.rare = 2;
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.createTile = mod.TileType("AlterationStation");
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Extractinator);
            recipe.AddIngredient(ItemID.AlchemyTable);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();

            // copper -> tin
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CopperOre);
            recipe.AddTile(mod, "AlterationStation");
            recipe.SetResult(ItemID.TinOre);
            recipe.AddRecipe();
            // tin -> copper
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TinOre);
            recipe.AddTile(mod, "AlterationStation");
            recipe.SetResult(ItemID.CopperOre);
            recipe.AddRecipe();

            // iron -> lead
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronOre);
            recipe.AddTile(mod, "AlterationStation");
            recipe.SetResult(ItemID.LeadOre);
            recipe.AddRecipe();
            // lead -> iron
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LeadOre);
            recipe.AddTile(mod, "AlterationStation");
            recipe.SetResult(ItemID.IronOre);
            recipe.AddRecipe();

            // silver -> tungsten
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SilverOre);
            recipe.AddTile(mod, "AlterationStation");
            recipe.SetResult(ItemID.TungstenOre);
            recipe.AddRecipe();
            // tungsten -> silver
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TungstenOre);
            recipe.AddTile(mod, "AlterationStation");
            recipe.SetResult(ItemID.SilverOre);
            recipe.AddRecipe();

            // gold -> platinum
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldOre);
            recipe.AddTile(mod, "AlterationStation");
            recipe.SetResult(ItemID.PlatinumOre);
            recipe.AddRecipe();
            // platinum -> gold
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PlatinumOre);
            recipe.AddTile(mod, "AlterationStation");
            recipe.SetResult(ItemID.GoldOre);
            recipe.AddRecipe();

            // demonite -> crimtane
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemoniteOre);
            recipe.AddTile(mod, "AlterationStation");
            recipe.SetResult(ItemID.CrimtaneOre);
            recipe.AddRecipe();
            // crimtane -> demonite
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimtaneOre);
            recipe.AddTile(mod, "AlterationStation");
            recipe.SetResult(ItemID.DemoniteOre);
            recipe.AddRecipe();

            // cobalt -> palladium
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CobaltOre);
            recipe.AddTile(mod, "AlterationStation");
            recipe.SetResult(ItemID.PalladiumOre);
            recipe.AddRecipe();
            // palladium -> cobalt
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PalladiumOre);
            recipe.AddTile(mod, "AlterationStation");
            recipe.SetResult(ItemID.CobaltOre);
            recipe.AddRecipe();

            // mythril -> orichalcum
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MythrilOre);
            recipe.AddTile(mod, "AlterationStation");
            recipe.SetResult(ItemID.OrichalcumOre);
            recipe.AddRecipe();
            // orichalcum -> mythril
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.OrichalcumOre);
            recipe.AddTile(mod, "AlterationStation");
            recipe.SetResult(ItemID.MythrilOre);
            recipe.AddRecipe();

            // adamantite -> titanium
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AdamantiteOre);
            recipe.AddTile(mod, "AlterationStation");
            recipe.SetResult(ItemID.TitaniumOre);
            recipe.AddRecipe();
            // titanium -> adamantite
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TitaniumOre);
            recipe.AddTile(mod, "AlterationStation");
            recipe.SetResult(ItemID.AdamantiteOre);
            recipe.AddRecipe();
        }
    }
}
