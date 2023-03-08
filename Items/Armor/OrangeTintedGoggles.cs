using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Armor {
    [AutoloadEquip(EquipType.Head)]
    public class OrangeTintedGoggles : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("{$Mods.QualityOfLifeRecipes.Armor.OrangeTintedGoggles}");
            Tooltip.SetDefault(
                "{$ItemTooltip.HunterPotion}" + "\n" +
                "{$ItemTooltip.TrapsightPotion}");
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 1, 0, 0);
            Item.rare = ItemRarityID.Green;
            Item.defense = 2;
        }

        public override void UpdateEquip(Player player) {
            // hunter potion
            player.detectCreature = true;
            // dangersense potion
            player.dangerSense = true;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Goggles);
            recipe.AddIngredient(ItemID.HunterPotion, 20);
            recipe.AddIngredient(ItemID.TrapsightPotion, 20);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
