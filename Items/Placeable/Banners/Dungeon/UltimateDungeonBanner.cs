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
            item.value = Item.sellPrice(0, 0, 35, 0);
            item.rare = 2;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("UltimateDungeonBanner");
            item.placeStyle = 0;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SupremeDungeonBanner");
            recipe.AddIngredient(ItemID.PaladinBanner);
            recipe.AddIngredient(ItemID.SkeletonCommandoBanner);
            recipe.AddIngredient(ItemID.SkeletonSniperBanner);
            recipe.AddIngredient(ItemID.TacticalSkeletonBanner);
            recipe.AddIngredient(ItemID.BoneLeeBanner);
            recipe.AddIngredient(ItemID.DungeonSpiritBanner);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
