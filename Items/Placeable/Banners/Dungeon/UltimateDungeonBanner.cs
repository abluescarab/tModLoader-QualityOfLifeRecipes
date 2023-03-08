using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Dungeon {
    public class UltimateDungeonBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault(Language.GetTextValue("Mods.QualityOfLifeRecipes.Placeable.Banners.Dungeon.UltimateDungeonBanner_Name"));
            Tooltip.SetDefault(
                "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.AngryBones}, {$NPCName.DarkCaster}, {$NPCName.CursedSkull}, {$NPCName.RustyArmoredBonesAxe},\n" +
                "{$NPCName.BlueArmoredBones}, {$NPCName.HellArmoredBones}, {$NPCName.Necromancer}, {$NPCName.RaggedCaster},\n" +
                "{$NPCName.DiabolistRed}, {$NPCName.GiantCursedSkull}, {$NPCName.DungeonSlime}, {$NPCName.Paladin},\n" +
                "{$NPCName.SkeletonCommando}, {$NPCName.SkeletonSniper}, {$NPCName.TacticalSkeleton}, {$NPCName.BoneLee},\n" +
                "{$NPCName.DungeonSpirit}");
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
            Item.createTile = ModContent.TileType<Tiles.Banners.Dungeon.UltimateDungeonBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<SupremeDungeonBanner>();
            recipe.AddIngredient(ItemID.PaladinBanner);
            recipe.AddIngredient(ItemID.SkeletonCommandoBanner);
            recipe.AddIngredient(ItemID.SkeletonSniperBanner);
            recipe.AddIngredient(ItemID.TacticalSkeletonBanner);
            recipe.AddIngredient(ItemID.BoneLeeBanner);
            recipe.AddIngredient(ItemID.DungeonSpiritBanner);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}
