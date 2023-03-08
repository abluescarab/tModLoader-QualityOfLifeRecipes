using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class SupremeSolarEclipseBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault(Language.GetTextValue("Mods.QualityOfLifeRecipes.Placeable.Banners.Events.SupremeSolarEclipseBanner_Name"));
            Tooltip.SetDefault(
                "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.Frankenstein}, {$NPCName.SwampThing}, {$NPCName.Vampire}, {$NPCName.CreatureFromTheDeep},\n" +
                "{$NPCName.Fritz}, {$NPCName.ThePossessed} {$NPCName.Eyezor}, {$NPCName.Reaper},\n" +
                "{$NPCName.Butcher}, {$NPCName.DeadlySphere}, {$NPCName.DrManFly}, {$NPCName.Nailhead},\n" +
                "{$NPCName.Psycho}");
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 0, 30, 0);
            Item.rare = ItemRarityID.Green;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Banners.Events.SupremeSolarEclipseBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<SolarEclipseBanner>());
            recipe.AddIngredient(ItemID.EyezorBanner);
            recipe.AddIngredient(ItemID.ReaperBanner);
            recipe.AddIngredient(ItemID.ButcherBanner);
            recipe.AddIngredient(ItemID.DeadlySphereBanner);
            recipe.AddIngredient(ItemID.DrManFlyBanner);
            recipe.AddIngredient(ItemID.NailheadBanner);
            recipe.AddIngredient(ItemID.PsychoBanner);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
