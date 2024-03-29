﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class HandsFreeMiningMultiTool : AccessoryItem {
        protected override AccessoryEffect[] Effects => null;
        protected override int SellPrice => Item.sellPrice(0, 16, 0, 0);
        protected override int Rarity => ItemRarityID.Yellow;

        public override void AddRecipes() {
            AddRecipe(
                new(ModContent.ItemType<CyberneticMiningMultiTool>()),
                new(ItemID.MartianConduitPlating, 20)
            );
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            ApplyEffects(player);
        }

        public override void UpdateInventory(Player player) {
            ApplyEffects(player);
        }

        public static void ApplyEffects(Player player) {
            CyberneticMiningMultiTool.ApplyEffects(player);
        }
    }
}
