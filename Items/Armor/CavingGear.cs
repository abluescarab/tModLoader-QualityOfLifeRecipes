using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Armor {
    [AutoloadEquip(EquipType.Head)]
    public class CavingGear : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault(Language.GetTextValue("Mods.QualityOfLifeRecipes.Armor.CavingGear_Name"));
            Tooltip.SetDefault(
                Language.GetTextValue("ItemTooltip.NightVisionHelmet") + "\n" +
                Language.GetTextValue("ItemTooltip.SpelunkerPotion"));
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 3, 0, 0);
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 8;
        }

        public override void UpdateEquip(Player player) {
            // night vision helmet
            player.nightVision = true;
            // spelunker potion
            player.findTreasure = true;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.NightVisionHelmet);
            recipe.AddIngredient(ItemID.SpelunkerPotion, 20);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
