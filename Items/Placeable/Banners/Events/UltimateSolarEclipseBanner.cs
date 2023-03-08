using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class UltimateSolarEclipseBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.UltimateSolarEclipseBanner}");
            Tooltip.SetDefault(
                "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.Frankenstein}, {$NPCName.SwampThing}, {$NPCName.Vampire}, {$NPCName.CreatureFromTheDeep},\n" +
                "{$NPCName.Fritz}, {$NPCName.ThePossessed}, {$NPCName.Eyezor}, {$NPCName.Reaper},\n" +
                "{$NPCName.Butcher}, {$NPCName.DeadlySphere}, {$NPCName.DrManFly}, {$NPCName.Nailhead},\n" +
                "{$NPCName.Psycho}, {$NPCName.Mothron}");
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 0, 35, 0);
            Item.rare = ItemRarityID.Green;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Banners.Events.UltimateSolarEclipseBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<SupremeSolarEclipseBanner>());
            recipe.AddIngredient(ItemID.MothronBanner);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
