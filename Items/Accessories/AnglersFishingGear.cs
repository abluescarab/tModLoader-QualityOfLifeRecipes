using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Accessories {
    [AutoloadEquip(EquipType.Back)]
    public class AnglersFishingGear : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Angler's Fishing Gear");
            Tooltip.SetDefault(Language.GetTextValue("ItemTooltip.AnglerTackleBag"));
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 7, 0, 0);
            item.rare = 4;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            // angler tackle bag + angler armor
            player.accFishingLine = true;
            player.accTackleBox = true;
            player.fishingSkill += 25;
        }
        
        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AnglerTackleBag);
            recipe.AddIngredient(ItemID.AnglerHat);
            recipe.AddIngredient(ItemID.AnglerPants);
            recipe.AddIngredient(ItemID.AnglerVest);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
