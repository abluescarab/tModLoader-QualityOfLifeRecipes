﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    public class AtomicNinjaBoots : AccessoryItem {
        protected override AccessoryEffect[] Effects => new AccessoryEffect[] {
            AccessoryEffect.TerrasparkBoots,
            AccessoryEffect.FrogFlipper,
            AccessoryEffect.MasterNinjaGear,
            AccessoryEffect.Magiluminescence,
            AccessoryEffect.FlowerBoots
        };

        protected override int SellPrice => Item.sellPrice(0, 29, 0, 0);
        protected override int Rarity => ItemRarityID.Purple;

        public override void AddRecipes() {
            AddRecipe(
                new(ModContent.ItemType<ElementalNinjaBoots>()),
                new(ItemID.FlowerBoots)
            );
        }
    }
}
