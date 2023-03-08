using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class FrostMoonBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.FrostMoonBanner}");
            Tooltip.SetDefault(
                "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.PresentMimic}, {$NPCName.Flocko}, {$NPCName.GingerbreadMan}, {$NPCName.ZombieElf},\n" +
                "{$NPCName.ElfArcher}, {$NPCName.Nutcracker}, {$NPCName.Yeti}, {$NPCName.ElfCopter},\n" +
                "{$NPCName.Krampus}");
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 0, 15, 0);
            Item.rare = ItemRarityID.Green;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Banners.Events.FrostMoonBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.PresentMimicBanner);
            recipe.AddIngredient(ItemID.FlockoBanner);
            recipe.AddIngredient(ItemID.GingerbreadManBanner);
            recipe.AddIngredient(ItemID.ZombieElfBanner);
            recipe.AddIngredient(ItemID.ElfArcherBanner);
            recipe.AddIngredient(ItemID.NutcrackerBanner);
            recipe.AddIngredient(ItemID.YetiBanner);
            recipe.AddIngredient(ItemID.ElfCopterBanner);
            recipe.AddIngredient(ItemID.KrampusBanner);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
