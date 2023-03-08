using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class AtomicNinjaBoots : ModItem {
        private Item flowerBoots;

        public AtomicNinjaBoots() {
            flowerBoots = new Item();
            flowerBoots.type = ItemID.FlowerBoots;
        }

        public override void SetStaticDefaults() {
            DisplayName.SetDefault("{$Mods.QualityOfLifeRecipes.Accessories.AtomicNinjaBoots}");
            Tooltip.SetDefault(
                "{$ItemTooltip.TerrasparkBoots}" + "\n" +
                "{$ItemTooltip.MasterNinjaGear}" + "\n" +
                "{$ItemTooltip.FlowerBoots}");
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 29, 0, 0);
            Item.rare = ItemRarityID.Purple;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            // terraspark boots
            player.waterWalk = true;
            player.fireWalk = true;
            player.lavaMax += 420;
            player.lavaRose = true;
            player.accRunSpeed = 6.75f;
            player.rocketBoots = (player.vanityRocketBoots = 4);
            player.moveSpeed += 0.08f;
            player.iceSkate = true;
            // master ninja gear
            player.blackBelt = true;
            player.dash = 1;
            player.spikedBoots = 2;
        }

        public override void UpdateEquip(Player player) {
            // flower boots
            player.VanillaUpdateEquip(flowerBoots);
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<ElementalNinjaBoots>();
            recipe.AddIngredient(ItemID.FlowerBoots);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
