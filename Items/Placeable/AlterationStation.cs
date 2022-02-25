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
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = false;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.rare = ItemRarityID.Green;
            Item.value = Item.sellPrice(0, 5, 0, 0);
            Item.createTile = ModContent.TileType<Tiles.AlterationStation>();
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Extractinator);
            recipe.AddIngredient(ItemID.AlchemyTable);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.Register();

            // copper -> tin
            recipe = Mod.CreateRecipe(ItemID.TinOre);
            recipe.AddIngredient(ItemID.CopperOre);
            recipe.AddTile(Mod, "AlterationStation");
            recipe.Register();

            // tin -> copper
            recipe = Mod.CreateRecipe(ItemID.CopperOre);
            recipe.AddIngredient(ItemID.TinOre);
            recipe.AddTile(Mod, "AlterationStation");
            recipe.Register();

            // iron -> lead
            recipe = Mod.CreateRecipe(ItemID.LeadOre);
            recipe.AddIngredient(ItemID.IronOre);
            recipe.AddTile(Mod, "AlterationStation");
            recipe.Register();
            // lead -> iron
            recipe = Mod.CreateRecipe(ItemID.IronOre);
            recipe.AddIngredient(ItemID.LeadOre);
            recipe.AddTile(Mod, "AlterationStation");
            recipe.Register();

            // silver -> tungsten
            recipe = Mod.CreateRecipe(ItemID.TungstenOre);
            recipe.AddIngredient(ItemID.SilverOre);
            recipe.AddTile(Mod, "AlterationStation");
            recipe.Register();
            // tungsten -> silver
            recipe = Mod.CreateRecipe(ItemID.SilverOre);
            recipe.AddIngredient(ItemID.TungstenOre);
            recipe.AddTile(Mod, "AlterationStation");
            recipe.Register();

            // gold -> platinum
            recipe = Mod.CreateRecipe(ItemID.PlatinumOre);
            recipe.AddIngredient(ItemID.GoldOre);
            recipe.AddTile(Mod, "AlterationStation");
            recipe.Register();
            // platinum -> gold
            recipe = Mod.CreateRecipe(ItemID.GoldOre);
            recipe.AddIngredient(ItemID.PlatinumOre);
            recipe.AddTile(Mod, "AlterationStation");
            recipe.Register();

            // demonite -> crimtane
            recipe = Mod.CreateRecipe(ItemID.CrimtaneOre);
            recipe.AddIngredient(ItemID.DemoniteOre);
            recipe.AddTile(Mod, "AlterationStation");
            recipe.Register();
            // crimtane -> demonite
            recipe = Mod.CreateRecipe(ItemID.DemoniteOre);
            recipe.AddIngredient(ItemID.CrimtaneOre);
            recipe.AddTile(Mod, "AlterationStation");
            recipe.Register();

            // cobalt -> palladium
            recipe = Mod.CreateRecipe(ItemID.PalladiumOre);
            recipe.AddIngredient(ItemID.CobaltOre);
            recipe.AddTile(Mod, "AlterationStation");
            recipe.Register();
            // palladium -> cobalt
            recipe = Mod.CreateRecipe(ItemID.CobaltOre);
            recipe.AddIngredient(ItemID.PalladiumOre);
            recipe.AddTile(Mod, "AlterationStation");
            recipe.Register();

            // mythril -> orichalcum
            recipe = CreateRecipe(ItemID.OrichalcumOre);
            recipe.AddIngredient(ItemID.MythrilOre);
            recipe.AddTile(Mod, "AlterationStation");
            recipe.Register();
            // orichalcum -> mythril
            recipe = Mod.CreateRecipe(ItemID.MythrilOre);
            recipe.AddIngredient(ItemID.OrichalcumOre);
            recipe.AddTile(Mod, "AlterationStation");
            recipe.Register();

            // adamantite -> titanium
            recipe = Mod.CreateRecipe(ItemID.TitaniumOre);
            recipe.AddIngredient(ItemID.AdamantiteOre);
            recipe.AddTile(Mod, "AlterationStation");
            recipe.Register();
            // titanium -> adamantite
            recipe = Mod.CreateRecipe(ItemID.AdamantiteOre);
            recipe.AddIngredient(ItemID.TitaniumOre);
            recipe.AddTile(Mod, "AlterationStation");
            recipe.Register();
        }
    }
}
