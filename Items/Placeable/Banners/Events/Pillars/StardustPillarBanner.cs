﻿using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events.Pillars {
    public class StardustPillarBanner : BannerItem<StardustPillarBanner, Tiles.Banners.Events.Pillars.StardustPillarBanner> {
        protected override int SellPrice => Item.sellPrice(0, 0, 15, 0);

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.StardustJellyfishBanner),
                new(ItemID.StardustLargeCellBanner),
                new(ItemID.StardustSoldierBanner),
                new(ItemID.StardustSpiderBanner),
                new(ItemID.StardustWormBanner)
            );
        }
    }
}
