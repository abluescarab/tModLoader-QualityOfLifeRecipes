using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Armor {
    [AutoloadEquip(EquipType.Head)]
    public class MiningGear : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Mining Gear");
            Tooltip.SetDefault(
                "Improves vision\n" +
                "Shows the location of treasure and ore\n" +
                "Provides light when worn");
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.rare = 5;
            item.defense = 10;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player) {
            // night vision helmet
            player.nightVision = true;
            // spelunker potion
            player.findTreasure = true;
            // mining helmet
            Lighting.AddLight(player.position, 1f, 1f, 1f);
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "CavingGear");
            recipe.AddIngredient(ItemID.MiningHelmet);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
