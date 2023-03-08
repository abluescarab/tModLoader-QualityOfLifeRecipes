using QualityOfLifeRecipes.Items.Armor;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class CyberneticMiningMultiTool : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault(Language.GetTextValue("Mods.QualityOfLifeRecipes.Accessories.CyberneticMiningMultiTool_Name"));
            Tooltip.SetDefault(
                Language.GetTextValue("ItemTooltip.HunterPotion") + "\n" +
                Language.GetTextValue("ItemTooltip.TrapsightPotion") + "\n" +
                Language.GetTextValue("ItemTooltip.NightVisionHelmet") + "\n" +
                Language.GetTextValue("ItemTooltip.SpelunkerPotion") + "\n" +
                Language.GetTextValue("ItemTooltip.MiningHelmet"));
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 15, 0, 0);
            Item.rare = ItemRarityID.Lime;
            Item.accessory = true;
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
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<UtilityHelmet>();
            recipe.AddIngredient(ItemID.Nanites, 20);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
