using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Dungeon {
    public class UltimateDungeonBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Ultimate Dungeon Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Angry Bones, Dark Caster, Cursed Skull Armored Bones, Necromancer,\n" +
                "Ragged Caster, Diabolist, Giant Cursed Skull, Dungeon Slime, Paladin, Skeleton Commando, Skeleton Sniper,\n" +
                "Tactical Skeleton, Bone Lee, Dungeon Spirit");
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
            Item.createTile = ModContent.TileType < Tiles.Banners.Dungeon.UltimateDungeonBanner>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(Mod, "SupremeDungeonBanner");
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
