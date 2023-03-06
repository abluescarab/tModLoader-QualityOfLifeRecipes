using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable {
    public class AlterationStation : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Alteration Station");
            Tooltip.SetDefault("Transmutes ore and block varieties");
        }

        public override void SetDefaults() {
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = false;
            Item.useAnimation = 15;
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

            #region Ores
            // copper -> tin
            recipe = Recipe.Create(ItemID.TinOre);
            recipe.AddIngredient(ItemID.CopperOre);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();
            // tin -> copper
            recipe = Recipe.Create(ItemID.CopperOre);
            recipe.AddIngredient(ItemID.TinOre);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            // iron -> lead
            recipe = Recipe.Create(ItemID.LeadOre);
            recipe.AddIngredient(ItemID.IronOre);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();
            // lead -> iron
            recipe = Recipe.Create(ItemID.IronOre);
            recipe.AddIngredient(ItemID.LeadOre);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            // silver -> tungsten
            recipe = Recipe.Create(ItemID.TungstenOre);
            recipe.AddIngredient(ItemID.SilverOre);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();
            // tungsten -> silver
            recipe = Recipe.Create(ItemID.SilverOre);
            recipe.AddIngredient(ItemID.TungstenOre);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            // gold -> platinum
            recipe = Recipe.Create(ItemID.PlatinumOre);
            recipe.AddIngredient(ItemID.GoldOre);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();
            // platinum -> gold
            recipe = Recipe.Create(ItemID.GoldOre);
            recipe.AddIngredient(ItemID.PlatinumOre);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            // demonite -> crimtane
            recipe = Recipe.Create(ItemID.CrimtaneOre);
            recipe.AddIngredient(ItemID.DemoniteOre);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();
            // crimtane -> demonite
            recipe = Recipe.Create(ItemID.DemoniteOre);
            recipe.AddIngredient(ItemID.CrimtaneOre);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            // cobalt -> palladium
            recipe = Recipe.Create(ItemID.PalladiumOre);
            recipe.AddIngredient(ItemID.CobaltOre);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();
            // palladium -> cobalt
            recipe = Recipe.Create(ItemID.CobaltOre);
            recipe.AddIngredient(ItemID.PalladiumOre);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            // mythril -> orichalcum
            recipe = Recipe.Create(ItemID.OrichalcumOre);
            recipe.AddIngredient(ItemID.MythrilOre);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();
            // orichalcum -> mythril
            recipe = Recipe.Create(ItemID.MythrilOre);
            recipe.AddIngredient(ItemID.OrichalcumOre);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            // adamantite -> titanium
            recipe = Recipe.Create(ItemID.TitaniumOre);
            recipe.AddIngredient(ItemID.AdamantiteOre);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();
            // titanium -> adamantite
            recipe = Recipe.Create(ItemID.AdamantiteOre);
            recipe.AddIngredient(ItemID.TitaniumOre);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();
            #endregion

            #region Crimson/Corruption
            // ebonstone -> crimstone
            recipe = Recipe.Create(ItemID.CrimstoneBlock);
            recipe.AddIngredient(ItemID.EbonstoneBlock);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();
            // crimstone -> ebonstone
            recipe = Recipe.Create(ItemID.EbonstoneBlock);
            recipe.AddIngredient(ItemID.CrimstoneBlock);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            // ebonstone brick -> crimstone brick
            recipe = Recipe.Create(ItemID.CrimstoneBrick);
            recipe.AddIngredient(ItemID.EbonstoneBrick);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();
            // crimstone brick -> ebonstone brick
            recipe = Recipe.Create(ItemID.EbonstoneBrick);
            recipe.AddIngredient(ItemID.CrimstoneBrick);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            // ebonstone brick wall -> crimstone brick wall
            recipe = Recipe.Create(ItemID.CrimstoneBrickWall);
            recipe.AddIngredient(ItemID.EbonstoneBrickWall);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();
            // crimstone brick wall -> ebonstone brick wall
            recipe = Recipe.Create(ItemID.EbonstoneBrickWall);
            recipe.AddIngredient(ItemID.CrimstoneBrickWall);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            // ebonsand -> crimsand
            recipe = Recipe.Create(ItemID.CrimsandBlock);
            recipe.AddIngredient(ItemID.EbonsandBlock);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();
            // crimsand -> ebonsand
            recipe = Recipe.Create(ItemID.EbonsandBlock);
            recipe.AddIngredient(ItemID.CrimsandBlock);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            // hardened ebonsand -> hardened crimsand
            recipe = Recipe.Create(ItemID.CrimsonHardenedSand);
            recipe.AddIngredient(ItemID.CorruptHardenedSand);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();
            // hardened crimsand -> hardened ebonsand
            recipe = Recipe.Create(ItemID.CorruptHardenedSand);
            recipe.AddIngredient(ItemID.CrimsonHardenedSand);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            // hardened ebonsand wall -> hardened crimsand wall
            recipe = Recipe.Create(ItemID.CrimsonHardenedSandWall);
            recipe.AddIngredient(ItemID.CorruptHardenedSandWall);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();
            // hardened crimsand wall -> hardened ebonsand wall
            recipe = Recipe.Create(ItemID.CorruptHardenedSandWall);
            recipe.AddIngredient(ItemID.CrimsonHardenedSandWall);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            // ebonsandstone -> crimsandstone
            recipe = Recipe.Create(ItemID.CrimsonSandstone);
            recipe.AddIngredient(ItemID.CorruptSandstone);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();
            // crimsandstone -> ebonsandstone
            recipe = Recipe.Create(ItemID.CorruptSandstone);
            recipe.AddIngredient(ItemID.CrimsonSandstone);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            // ebonsandstone wall -> crimsandstone wall
            recipe = Recipe.Create(ItemID.CrimsonSandstoneWall);
            recipe.AddIngredient(ItemID.CorruptSandstoneWall);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();
            // crimsandstone wall -> ebonsandstone wall
            recipe = Recipe.Create(ItemID.CorruptSandstoneWall);
            recipe.AddIngredient(ItemID.CrimsonSandstoneWall);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            // corrupt grass wall -> crimson grass wall
            recipe = Recipe.Create(ItemID.CrimsonGrassEcho);
            recipe.AddIngredient(ItemID.CorruptGrassEcho);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();
            // crimson grass wall -> corrupt grass wall
            recipe = Recipe.Create(ItemID.CorruptGrassEcho);
            recipe.AddIngredient(ItemID.CrimsonGrassEcho);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            // natural corrupt walls -> natural crimson walls
            recipe = Recipe.Create(ItemID.Crimson1Echo);
            recipe.AddIngredient(ItemID.Corruption1Echo);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            recipe = Recipe.Create(ItemID.Crimson2Echo);
            recipe.AddIngredient(ItemID.Corruption2Echo);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            recipe = Recipe.Create(ItemID.Crimson3Echo);
            recipe.AddIngredient(ItemID.Corruption3Echo);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            recipe = Recipe.Create(ItemID.Crimson4Echo);
            recipe.AddIngredient(ItemID.Corruption4Echo);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            // natural crimson walls -> natural corrupt walls
            recipe = Recipe.Create(ItemID.Corruption1Echo);
            recipe.AddIngredient(ItemID.Crimson1Echo);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            recipe = Recipe.Create(ItemID.Corruption2Echo);
            recipe.AddIngredient(ItemID.Crimson2Echo);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            recipe = Recipe.Create(ItemID.Corruption3Echo);
            recipe.AddIngredient(ItemID.Crimson3Echo);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            recipe = Recipe.Create(ItemID.Corruption4Echo);
            recipe.AddIngredient(ItemID.Crimson4Echo);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();

            // ebonwood -> shadewood
            recipe = Recipe.Create(ItemID.Shadewood);
            recipe.AddIngredient(ItemID.Ebonwood);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();
            // shadewood -> ebonwood
            recipe = Recipe.Create(ItemID.Ebonwood);
            recipe.AddIngredient(ItemID.Shadewood);
            recipe.AddTile<Tiles.AlterationStation>();
            recipe.Register();
            #endregion
        }
    }
}
