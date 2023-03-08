using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    [AutoloadEquip(EquipType.Back)]
    public class AnglersFishingGear : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault(Language.GetTextValue("Mods.QualityOfLifeRecipes.Accessories.AnglersFishingGear_Name"));
            Tooltip.SetDefault(Language.GetTextValue("ItemTooltip.AnglerTackleBag"));
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 7, 0, 0);
            Item.rare = ItemRarityID.LightRed;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            // angler tackle bag + angler armor
            player.accFishingLine = true;
            player.accTackleBox = true;
            player.fishingSkill += 25;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.AnglerTackleBag);
            recipe.AddIngredient(ItemID.AnglerHat);
            recipe.AddIngredient(ItemID.AnglerPants);
            recipe.AddIngredient(ItemID.AnglerVest);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
