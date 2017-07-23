using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Dungeon {
    public class SupremeDungeonBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Supreme Dungeon Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against:\n" +
                "Angry Bones/Dark Caster/Cursed Skull\n" +
                "Armored Bones/Necromancer/Ragged Caster/Diabolist/Giant Cursed Skull");
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 0, 25, 0);
            item.rare = 2;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("SupremeDungeonBanner");
            item.placeStyle = 0;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "DungeonBanner");
            recipe.AddIngredient(ItemID.DungeonSlimeBanner);
            recipe.AddIngredient(ItemID.BlueArmoredBonesBanner);
            recipe.AddIngredient(ItemID.RustyArmoredBonesBanner);
            recipe.AddIngredient(ItemID.HellArmoredBonesBanner);
            recipe.AddIngredient(ItemID.NecromancerBanner);
            recipe.AddIngredient(ItemID.RaggedCasterBanner);
            recipe.AddIngredient(ItemID.DiablolistBanner);
            recipe.AddIngredient(ItemID.GiantCursedSkullBanner);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
