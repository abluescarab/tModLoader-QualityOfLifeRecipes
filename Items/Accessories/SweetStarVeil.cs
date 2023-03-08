using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class SweetStarVeil : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("{$Mods.QualityOfLifeRecipes.Accessories.SweetStarVeil_Name}");
            Tooltip.SetDefault(
                "{$ItemTooltip.SweetheartNecklace}" + "\n" +
                "{$ItemTooltip.StarVeil}");
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 4, 0, 0);
            Item.rare = ItemRarityID.Lime;
            Item.defense = 4;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            // star veil
            player.starCloakItem = Item;
            player.longInvince = true;
            // sweetheart necklace
            player.honeyCombItem = Item;
            player.panic = true;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SweetheartNecklace);
            recipe.AddIngredient(ItemID.StarVeil);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
