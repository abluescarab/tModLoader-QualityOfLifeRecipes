using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class ElementalBoots : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Elemental Boots");
            Tooltip.SetDefault(
                "Allows flight, super fast running, and extra mobility on ice\n" +
                "8% increased movement speed\n" +
                "Provides the ability to walk on water and lava\n" +
                "Grants immunity to fire blocks and 7 seconds of immunity to lava");
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 20, 0, 0);
            item.rare = 8;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            // lava waders
            player.waterWalk = true;
            player.fireWalk = true;
            player.lavaMax += 420;
            // frostspark boots
            player.accRunSpeed = 6.75f;
            player.rocketBoots = 3;
            player.moveSpeed += 0.08f;
            player.iceSkate = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LavaWaders);
            recipe.AddIngredient(ItemID.FrostsparkBoots);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
