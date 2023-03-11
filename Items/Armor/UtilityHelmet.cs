using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Armor {
    [AutoloadEquip(EquipType.Head)]
    public class UtilityHelmet : BaseItem {
        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Armor.UtilityHelmet}";

        protected override string TooltipTranslation =>
            "{$ItemTooltip.UltrabrightHelmet}" + "\n" +
                "{$ItemTooltip.HunterPotion}" + "\n" +
                "{$ItemTooltip.TrapsightPotion}" + "\n" +
                "{$ItemTooltip.SpelunkerPotion}";

        protected override int SellPrice => Item.sellPrice(0, 8, 0, 0);

        protected override int Rarity => ItemRarityID.LightPurple;

        public override void SetDefaults() {
            base.SetDefaults();
            Item.defense = 4;
        }

        public override void AddRecipes() {
            AddRecipe(
                TileID.TinkerersWorkbench,
                new(ItemID.UltrabrightHelmet),
                new(ItemID.HunterPotion, 20),
                new(ItemID.TrapsightPotion, 20),
                new(ItemID.SpelunkerPotion, 20)
            );
        }

        public override void UpdateEquip(Player player) {
            ApplyEffects(player);
        }

        public override bool IsArmorSet(Item head, Item body, Item legs) {
            return body.type == ItemID.MiningShirt &&
                   legs.type == ItemID.MiningPants;
        }

        public override void UpdateArmorSet(Player player) {
            player.setBonus = Language.GetTextValue("ArmorSetBonus.Mining");
            player.pickSpeed -= 0.3f;
        }

        public static void ApplyEffects(Player player) {
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
    }
}
