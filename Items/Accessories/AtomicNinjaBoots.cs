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
            DisplayName.SetDefault("Atomic Ninja Boots");
            Tooltip.SetDefault(
                Language.GetTextValue("ItemTooltip.FrostsparkBoots") + "\n" +
                Language.GetTextValue("ItemTooltip.LavaWaders") + "\n" +
                Language.GetTextValue("ItemTooltip.MasterNinjaGear") + "\n" +
                Language.GetTextValue("ItemTooltip.FlowerBoots"));
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 35, 0, 0);
            Item.rare = ItemRarityID.Purple;
            Item.accessory = true;
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
        }

        public override void UpdateEquip(Player player) {
            // flower boots
            player.VanillaUpdateEquip(flowerBoots);
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(Mod, "ElementalNinjaBoots");
            recipe.AddIngredient(ItemID.FlowerBoots);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
