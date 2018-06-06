using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class AtomicCloudBoots : ModItem {
        private Item flowerBoots;

        public AtomicCloudBoots() {
            flowerBoots = new Item();
            flowerBoots.type = ItemID.FlowerBoots;
        }

        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Atomic Cloud Boots");
            Tooltip.SetDefault(
                Language.GetTextValue("ItemTooltip.FrostsparkBoots") + "\n" +
                Language.GetTextValue("ItemTooltip.LavaWaders") + "\n" +
                Language.GetTextValue("ItemTooltip.MasterNinjaGear") + "\n" +
                Language.GetTextValue("ItemTooltip.FlowerBoots") + "\n" +
                Language.GetTextValue("ItemTooltip.GravityGlobe") + "\n" +
                Language.GetTextValue("ItemTooltip.FrogLeg") + "\n" +
                Language.GetTextValue("ItemTooltip.LuckyHorseshoe") + "\n" +
                "Sextuple jump and increases jump height\n" +
                Language.GetTextValue("ItemTooltip.HoneyComb"));
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 55, 0, 0);
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
            // frog leg
            player.autoJump = true;
            player.jumpSpeedBoost += 2.4f;
            player.extraFall += 15;
            // lucky horseshoe
            player.noFallDmg = true;

            player.jumpBoost = true;

            // fart in a balloon
            player.doubleJumpFart = true;
            // honey balloon
            player.bee = true;
            // sharkron balloon
            player.doubleJumpSail = true;
            // bundle of balloons
            player.doubleJumpCloud = true;
            player.doubleJumpSandstorm = true;
            player.doubleJumpBlizzard = true;
        }

        public override void UpdateEquip(Player player) {
            // flower boots
            player.VanillaUpdateEquip(flowerBoots);
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AtomicNinjaBoots");
            recipe.AddIngredient(mod, "CloudOfFrogshoeBalloons");
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
