﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events.SolarEclipse {
    public class SupremeSolarEclipseBanner : BannerItem<SupremeSolarEclipseBanner, Tiles.Banners.Events.SolarEclipse.SupremeSolarEclipseBanner> {
        protected override int SellPrice => Item.sellPrice(0, 0, 30, 0);

        public override void AddRecipes() {
            AddRecipe(
                new(ModContent.ItemType<SolarEclipseBanner>()),
                new(ItemID.EyezorBanner),
                new(ItemID.ReaperBanner),
                new(ItemID.ButcherBanner),
                new(ItemID.DeadlySphereBanner),
                new(ItemID.DrManFlyBanner),
                new(ItemID.NailheadBanner),
                new(ItemID.PsychoBanner)
            );
        }
    }
}
