using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class CyberneticMiningMultiTool : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Cybernetic Mining Multi-Tool");
            Tooltip.SetDefault(
                Language.GetTextValue("ItemTooltip.HunterPotion") + "\n" +
                Language.GetTextValue("ItemTooltip.TrapsightPotion") + "\n" +
                Language.GetTextValue("ItemTooltip.NightVisionHelmet") + "\n" +
                Language.GetTextValue("ItemTooltip.SpelunkerPotion") + "\n" +
                Language.GetTextValue("ItemTooltip.MiningHelmet"));
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 15, 0, 0);
            item.rare = 7;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
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
            recipe.AddIngredient(mod, "UtilityHelmet");
            recipe.AddIngredient(ItemID.Nanites, 20);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
