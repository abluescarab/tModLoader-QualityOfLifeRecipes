using Terraria;
using Terraria.ID;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Undead {
    public class UndeadBanner : BannerItem<UndeadBanner, Tiles.Banners.Undead.UndeadBanner> {
        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Undead.UndeadBanner}";

        protected override string TooltipTranslation => 
            "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.Zombie}, {$NPCName.ZombieRaincoat}, {$NPCName.DemonEye}";
        
        protected override int SellPrice => Item.sellPrice(0, 0, 5, 0);
        
        protected override int Rarity => ItemRarityID.Green;
        
        protected override int[] Ingredients => new int[] {
            ItemID.ZombieBanner,
            ItemID.DemonEyeBanner
        };
    }
}
