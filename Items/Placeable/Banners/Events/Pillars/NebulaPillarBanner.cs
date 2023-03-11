﻿using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events.Pillars {
    public class NebulaPillarBanner : BannerItem<NebulaPillarBanner, Tiles.Banners.Events.Pillars.NebulaPillarBanner> {
        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.Pillars.NebulaPillarBanner}";

        protected override string TooltipTranslation =>
            "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.NebulaHeadcrab}, {$NPCName.NebulaBeast}, {$NPCName.NebulaBrain}, {$NPCName.NebulaSoldier}";

        protected override int SellPrice => Item.sellPrice(0, 0, 10, 0);

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.NebulaBeastBanner),
                new(ItemID.NebulaBrainBanner),
                new(ItemID.NebulaHeadcrabBanner),
                new(ItemID.NebulaSoldierBanner)
            );
        }
    }
}
