using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Dungeon {
    public class SupremeDungeonBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault(Language.GetTextValue("Mods.QualityOfLifeRecipes.Placeable.Banners.Dungeon.SupremeDungeonBanner_Name"));
            Tooltip.SetDefault(
                "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.AngryBones}, {$NPCName.DarkCaster}, {$NPCName.CursedSkull}, {$NPCName.RustyArmoredBonesAxe},\n" +
                "{$NPCName.BlueArmoredBones}, {$NPCName.HellArmoredBones}, {$NPCName.Necromancer}, {$NPCName.RaggedCaster},\n" +
                "{$NPCName.DiabolistRed}, {$NPCName.GiantCursedSkull}, {$NPCName.DungeonSlime}");
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 0, 25, 0);
            Item.rare = ItemRarityID.Green;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Banners.Dungeon.SupremeDungeonBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<DungeonBanner>();
            recipe.AddIngredient(ItemID.DungeonSlimeBanner);
            recipe.AddIngredient(ItemID.BlueArmoredBonesBanner);
            recipe.AddIngredient(ItemID.RustyArmoredBonesBanner);
            recipe.AddIngredient(ItemID.HellArmoredBonesBanner);
            recipe.AddIngredient(ItemID.NecromancerBanner);
            recipe.AddIngredient(ItemID.RaggedCasterBanner);
            recipe.AddIngredient(ItemID.DiablolistBanner);
            recipe.AddIngredient(ItemID.GiantCursedSkullBanner);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
