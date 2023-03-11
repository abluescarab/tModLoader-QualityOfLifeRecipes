using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners {
    public class UndeadBanner : BannerItem<UndeadBanner, Tiles.Banners.UndeadBanner> {
        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Undead.UndeadBanner}";

        protected override string TooltipTranslation =>
            "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.Zombie}, {$NPCName.ZombieRaincoat}, {$NPCName.DemonEye}";

        protected override int SellPrice => Item.sellPrice(0, 0, 5, 0);

        protected override int Rarity => ItemRarityID.Green;

        public override void AddRecipes() {
            AddRecipe(
                new(ItemID.ZombieBanner),
                new(ItemID.RaincoatZombieBanner),
                new(ItemID.DemonEyeBanner)
            );
        }
    }
}
