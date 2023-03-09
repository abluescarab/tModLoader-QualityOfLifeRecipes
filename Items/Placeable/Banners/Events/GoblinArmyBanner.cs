using Terraria;
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

        protected override int[] Ingredients => new int[] {
            ItemID.GoblinArcherBanner,
            ItemID.GoblinPeonBanner,
            ItemID.GoblinSorcererBanner,
            ItemID.GoblinThiefBanner,
            ItemID.GoblinWarriorBanner
        };
    }
}
