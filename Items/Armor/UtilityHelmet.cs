using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Armor {
    [AutoloadEquip(EquipType.Head)]
    public class UtilityHelmet : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Utility Helmet");
            Tooltip.SetDefault(
                "Shows the location of enemies\n" +
                "Allows you to see nearby traps\n" +
                "Improves vision\n" +
                "Shows the location of treasure and ore\n" +
                "Provides light when worn");
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 8, 0, 0);
            item.rare = 6;
            item.defense = 12;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player) {
            // night vision helmet
            player.nightVision = true;
            // spelunker potion
            player.findTreasure = true;
            // mining helmet
            Lighting.AddLight(player.position, 1f, 1f, 1f);
            // hunter potion
            player.detectCreature = true;
            // dangersense potion
            player.dangerSense = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "MiningGear");
            recipe.AddIngredient(mod, "OrangeTintedGoggles");
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
