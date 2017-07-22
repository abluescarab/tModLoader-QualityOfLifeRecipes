using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class BunchOfBalloons : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Bunch of Balloons");
            Tooltip.SetDefault(
                "Triple jump and increases jump height\n" +
                "Releases bees when damaged");
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.rare = 5;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            player.jumpBoost = true;

            // fart in a balloon
            player.doubleJumpFart = true;
            // honey balloon
            player.bee = true;
            // sharkron balloon
            player.doubleJumpSail = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FartInABalloon);
            recipe.AddIngredient(ItemID.HoneyBalloon);
            recipe.AddIngredient(ItemID.SharkronBalloon);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
