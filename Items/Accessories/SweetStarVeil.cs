﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class SweetStarVeil : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Sweet Star Veil");
            Tooltip.SetDefault(
                "Releases bees and increases movement speed when damaged\n" +
                "Causes stars to fall and increases length of invincibility after taking damage");
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 20, 0, 0);
            item.rare = 7;
            item.defense = 4;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            // star veil
            player.starCloak = true;
            player.longInvince = true;
            // sweetheart necklace
            player.bee = true;
            player.panic = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SweetheartNecklace);
            recipe.AddIngredient(ItemID.StarVeil);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
