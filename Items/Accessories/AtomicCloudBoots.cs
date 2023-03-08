﻿using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class AtomicCloudBoots : ModItem {
        private readonly Item flowerBoots;

        public AtomicCloudBoots() {
            flowerBoots = new Item(ItemID.FlowerBoots);
        }

        public override void SetStaticDefaults() {
            DisplayName.SetDefault(Language.GetTextValue("Mods.QualityOfLifeRecipes.Accessories.AtomicCloudBoots_Name"));
            Tooltip.SetDefault(
                Language.GetTextValue("ItemTooltip.TerrasparkBoots") + "\n" +
                Language.GetTextValue("ItemTooltip.MasterNinjaGear") + "\n" +
                Language.GetTextValue("ItemTooltip.FlowerBoots") + "\n" +
                Language.GetTextValue("ItemTooltip.FrogLeg") + "\n" +
                Language.GetTextValue("ItemTooltip.LuckyHorseshoe") + "\n" +
                Language.GetTextValue("Mods.QualityOfLifeRecipes.General.JumpSixTimes") + "\n" +
                Language.GetTextValue("ItemTooltip.ShinyRedBalloon") + "\n" +
                Language.GetTextValue("ItemTooltip.HoneyComb"));
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 42, 0, 0);
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
            // frog leg
            player.autoJump = true;
            player.jumpSpeedBoost += 2.4f;
            player.extraFall += 15;
            // lucky horseshoe
            player.noFallDmg = true;

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

        public override void UpdateEquip(Player player) {
            // flower boots
            player.VanillaUpdateEquip(flowerBoots);
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<AtomicNinjaBoots>();
            recipe.AddIngredient<CloudOfFrogshoeBalloons>();
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
