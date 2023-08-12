using Microsoft.Xna.Framework;
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
            Magiluminescence,
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
                player.GrantArmorBenefits(flowerBoots);
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
                case AccessoryEffect.FlowerBoots:
                    player.flowerBoots = true;
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
                    player.hasLuck_LuckyHorseshoe = true;
                    break;
                case AccessoryEffect.Magiluminescence:
                    player.hasMagiluminescence = true;
                    player.MountedCenter.ToTileCoordinates();
                    DelegateMethods.v3_1 = new Vector3(0.9f, 0.8f, 0.5f);
                    Utils.PlotTileLine(
                        player.Center,
                        player.Center + player.velocity * 6f,
                        20f,
                        new Utils.TileActionAttempt(DelegateMethods.CastLightOpen));
                    Utils.PlotTileLine(
                        player.Left,
                        player.Right,
                        20f,
                        new Utils.TileActionAttempt(DelegateMethods.CastLightOpen));
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
