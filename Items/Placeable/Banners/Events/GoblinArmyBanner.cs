﻿using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class GoblinArmyBanner : BannerItem<GoblinArmyBanner, Tiles.Banners.Events.GoblinArmyBanner> {
        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.GoblinArmyBanner}";

        protected override string TooltipTranslation =>
            "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.GoblinArcher}, {$NPCName.GoblinPeon}, {$NPCName.GoblinSorcerer}, {$NPCName.GoblinThief},\n" +
                "{$NPCName.GoblinWarrior}";

        protected override int SellPrice => Item.sellPrice(0, 0, 12, 0);

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.GoblinArcherBanner),
                new(ItemID.GoblinPeonBanner),
                new(ItemID.GoblinSorcererBanner),
                new(ItemID.GoblinThiefBanner),
                new(ItemID.GoblinWarriorBanner)
            );
        }
    }
}
