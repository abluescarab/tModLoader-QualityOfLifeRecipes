using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class AtomicNinjaBoots : ModItem {
        private Item flowerBoots;

        public AtomicNinjaBoots() {
            flowerBoots = new Item();
            flowerBoots.type = ItemID.FlowerBoots;
        }

        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Atomic Boots");
            Tooltip.SetDefault(
                "Allows flight, super fast running, and extra mobility on ice\n" +
                "8% increased movement speed\n" +
                "Provides the ability to walk on water and lava\n" +
                "Grants immunity to fire blocks and 7 seconds of immunity to lava\n" +
                "Allows the ability to climb walls and dash\n" +
                "Gives a chance to dodge attacks\n" +
                "Flowers grow on the grass you walk on\n" +
                "Allows the holder to reverse gravity with UP");
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 35, 0, 0);
            item.rare = 11;
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
            // master ninja gear
            player.blackBelt = true;
            player.dash = 1;
            player.spikedBoots = 2;
            // gravity globe
            player.gravControl = true;
        }

        public override void UpdateEquip(Player player) {
            // flower boots
            player.VanillaUpdateEquip(flowerBoots);
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "ElementalNinjaBoots");
            recipe.AddIngredient(ItemID.FlowerBoots);
            recipe.AddIngredient(ItemID.GravityGlobe);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
