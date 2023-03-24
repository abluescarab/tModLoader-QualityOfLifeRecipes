using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    [AutoloadEquip(EquipType.Back)]
    public class LavaproofFishingGear : AccessoryItem {
        protected override AccessoryEffect[] Effects => null;

        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Accessories.LavaproofFishingGear}";

        protected override string TooltipTranslation =>
            "{$ItemTooltip.LavaproofTackleBag}";

        protected override int SellPrice => Item.sellPrice(0, 9, 0, 0);

        protected override int Rarity => ItemRarityID.LightRed;

        public override void AddRecipes() {
            AddRecipe(
                new(ModContent.ItemType<AnglersFishingGear>()),
                new(ItemID.LavaFishingHook)
            );

            AddRecipe(
                new(ItemID.LavaproofTackleBag),
                new(ItemID.AnglerHat),
                new(ItemID.AnglerPants),
                new(ItemID.AnglerVest)
            );
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            AnglersFishingGear.ApplyEffects(player);
            // lavaproof fishing hook
            player.accLavaFishing = true;
        }
    }
}
