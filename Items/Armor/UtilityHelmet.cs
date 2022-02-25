using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Armor {
    [AutoloadEquip(EquipType.Head)]
    public class UtilityHelmet : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Utility Helmet");
            Tooltip.SetDefault(
                Language.GetTextValue("ItemTooltip.HunterPotion") + "\n" +
                Language.GetTextValue("ItemTooltip.TrapsightPotion") + "\n" +
                Language.GetTextValue("ItemTooltip.NightVisionHelmet") + "\n" +
                Language.GetTextValue("ItemTooltip.SpelunkerPotion") + "\n" +
                Language.GetTextValue("ItemTooltip.MiningHelmet"));
        }

        public override void SetDefaults() {
            Item.value = Item.sellPrice(0, 8, 0, 0);
            Item.rare = ItemRarityID.LightPurple;
            Item.defense = 12;
        }

        public override void UpdateEquip(Player player) {
            // night vision helmet
            player.nightVision = true;
            // spelunker potion
            player.findTreasure = true;
            // mining helmet
            Lighting.AddLight(player.position, 1f, 1f, 1f);
            // hunter potion
            player.detectCreature = true;
            // dangersense potion
            player.dangerSense = true;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs) {
            return body.type == ItemID.MiningShirt &&
                   legs.type == ItemID.MiningPants;
        }

        public override void UpdateArmorSet(Player player) {
            player.setBonus = Language.GetTextValue("ArmorSetBonus.Mining");
            player.pickSpeed -= 0.3f;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(Mod, "MiningGear");
            recipe.AddIngredient(Mod, "OrangeTintedGoggles");
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
