﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    [AutoloadEquip(EquipType.Back)]
    public class AnglersFishingGear : AccessoryItem {
        protected override AccessoryEffect[] Effects => null;
        protected override int SellPrice => Item.sellPrice(0, 7, 0, 0);
        protected override int Rarity => ItemRarityID.LightRed;

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.AnglerTackleBag),
                new(ItemID.AnglerHat),
                new(ItemID.AnglerPants),
                new(ItemID.AnglerVest)
            );
        }

        public static void ApplyEffects(Player player) {
            // angler tackle bag + angler armor
            player.accFishingLine = true;
            player.accTackleBox = true;
            player.fishingSkill += 25;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            ApplyEffects(player);
        }
    }
}
