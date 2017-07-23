using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners {
    public class UndeadBanner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Undead Banner");
            Tooltip.SetDefault(
                "Nearby players get a bonus against: Zombie, Raincoat Zombie, Demon Eye");
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 0, 5, 0);
            item.rare = 2;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("UndeadBanner");
            item.placeStyle = 0;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ZombieBanner);
            recipe.AddIngredient(ItemID.DemonEyeBanner);
            recipe.AddIngredient(ItemID.RaincoatZombieBanner);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
