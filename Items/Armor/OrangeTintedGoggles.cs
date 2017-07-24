using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Armor {
    [AutoloadEquip(EquipType.Head)]
    public class OrangeTintedGoggles : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Oranged-Tinted Goggles");
            Tooltip.SetDefault(
                Language.GetTextValue("ItemTooltip.HunterPotion") + "\n" +
                Language.GetTextValue("ItemTooltip.TrapsightPotion"));
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 2;
            item.defense = 2;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player) {
            // hunter potion
            player.detectCreature = true;
            // dangersense potion
            player.dangerSense = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Goggles);
            recipe.AddIngredient(ItemID.HunterPotion, 20);
            recipe.AddIngredient(ItemID.TrapsightPotion, 20);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
