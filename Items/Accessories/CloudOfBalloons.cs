﻿using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class CloudOfBalloons : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Cloud of Balloons");
            Tooltip.SetDefault(
                "Sextuple jump and increases jump height\n" +
                Language.GetTextValue("ItemTooltip.HoneyComb"));
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 11, 0, 0);
            Item.rare = ItemRarityID.Cyan;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            player.jumpBoost = true;

            // fart in a balloon
            player.hasJumpOption_Fart = true;
            // honey balloon
            player.jumpBoost = true;
            player.honeyCombItem = Item;
            // sharkron balloon
            player.hasJumpOption_Sail = true;
            // bundle of balloons
            player.hasJumpOption_Cloud = true;
            player.hasJumpOption_Sandstorm = true;
            player.hasJumpOption_Blizzard = true;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(Mod, "BunchOfBalloons");
            recipe.AddIngredient(ItemID.BundleofBalloons);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
