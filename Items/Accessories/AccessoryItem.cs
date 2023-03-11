using System;
using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Accessories {
    public abstract class AccessoryItem : BaseItem {
        protected enum AccessoryEffect {
            BundleOfBalloons,
            FartInABalloon,
            FlowerBoots,
            FrogFlipper,
            HoneyBalloon,
            LuckyHorseshoe,
            MasterNinjaGear,
            SharkronBalloon,
            TerrasparkBoots,
        }

        private readonly Item flowerBoots = null;

        protected abstract AccessoryEffect[] Effects { get; }

        public AccessoryItem() {
            if(Effects != null && Array.IndexOf(Effects, AccessoryEffect.FlowerBoots) > -1) {
                flowerBoots = new Item(ItemID.FlowerBoots);
            }
        }

        public override void SetDefaults() {
            base.SetDefaults();
            Item.accessory = true;
        }

        protected void AddRecipe(params Ingredient[] ingredients) {
            AddRecipe(TileID.TinkerersWorkbench, ingredients);
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            if(Effects == null) {
                return;
            }

            foreach(AccessoryEffect effect in Effects) {
                ApplyEffect(effect, player);
            }
        }

        public override void UpdateEquip(Player player) {
            if(flowerBoots != null) {
                player.VanillaUpdateEquip(flowerBoots);
            }
        }

        protected virtual void ApplyEffect(AccessoryEffect effect, Player player) {
            switch(effect) {
                case AccessoryEffect.BundleOfBalloons:
                    player.hasJumpOption_Cloud = true;
                    player.hasJumpOption_Sandstorm = true;
                    player.hasJumpOption_Blizzard = true;
                    player.jumpBoost = true;
                    break;
                case AccessoryEffect.FartInABalloon:
                    player.hasJumpOption_Fart = true;
                    player.jumpBoost = true;
                    break;
                case AccessoryEffect.FrogFlipper:
                    player.autoJump = true;
                    player.jumpSpeedBoost += 1.6f;
                    player.extraFall += 10;
                    player.accFlipper = true;
                    break;
                case AccessoryEffect.HoneyBalloon:
                    player.jumpBoost = true;
                    player.honeyCombItem = Item;
                    break;
                case AccessoryEffect.LuckyHorseshoe:
                    player.noFallDmg = true;
                    //player.hasLuck_LuckyHorseshoe = true; // 1.4.4 only
                    break;
                case AccessoryEffect.MasterNinjaGear:
                    player.blackBelt = true;
                    player.dashType = 1;
                    player.spikedBoots = 2;
                    break;
                case AccessoryEffect.SharkronBalloon:
                    player.jumpBoost = true;
                    player.hasJumpOption_Sail = true;
                    break;
                case AccessoryEffect.TerrasparkBoots:
                    player.waterWalk = true;
                    player.fireWalk = true;
                    player.lavaMax += 420;
                    player.lavaRose = true;
                    player.accRunSpeed = 6.75f;
                    player.rocketBoots = (player.vanityRocketBoots = 4);
                    player.moveSpeed += 0.08f;
                    player.iceSkate = true;
                    break;
            }
        }
    }
}
