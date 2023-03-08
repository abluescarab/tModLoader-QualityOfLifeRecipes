using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;

namespace QualityOfLifeRecipes.Items {
    public abstract class DeprecatedItem : ModItem {
        protected struct ReplacementItem {
            public readonly int ID;
            public readonly int Stack;
            public readonly int Prefix;

            public ReplacementItem(int id, int stack = 1, int prefix = 0) {
                ID = id;
                Stack = stack;
                Prefix = prefix;
            }

            public string GetDisplayName() {
                return Lang.GetItemNameValue(ID);
            }
        }

        protected abstract ReplacementItem[] Replacements { get; }

        public sealed override void Load() {
            QualityOfLifeRecipesSystem.DeprecatedMessageShown.Add(GetType(), false);
        }

        public sealed override bool CanRightClick() {
            return true;
        }

        public sealed override bool ConsumeItem(Player player) {
            return true;
        }

        public sealed override void OnConsumeItem(Player player) {
            Replace(player);
        }

        public sealed override void UpdateInventory(Player player) {
            Type thisType = GetType();

            if(QualityOfLifeRecipesSystem.DeprecatedMessageShown.ContainsKey(thisType)
                && !QualityOfLifeRecipesSystem.DeprecatedMessageShown[thisType]) {
                string[] replacements = new string[Replacements.Length];

                for(int i = 0; i < replacements.Length; i++) {
                    replacements[i] = Replacements[i].GetDisplayName();
                }

                string name = Lang.GetItemNameValue(Type);

                Main.NewText($"{name} has been removed from Quality of Life: Recipes. " +
                                 $"Right-click to receive {string.Join(", ", replacements)}. ",
                                 Color.Red);

                QualityOfLifeRecipesSystem.DeprecatedMessageShown[thisType] = true;
            }
        }

        public sealed override void UpdateAccessory(Player player, bool hideVisual) { }

        public sealed override void AddRecipes() { }

        protected void Replace(Player player) {
            if(Replacements == null || Replacements.Length == 0) {
                Item.maxStack = 0;
                Item.TurnToAir();
                return;
            }

            for(int i = 0; i < Replacements.Length; i++) {
                int index = -1;

                if(i == 0) {
                    index = Array.IndexOf(player.inventory, Item);
                }
                else {
                    index = Array.FindIndex(player.inventory, i => i.stack == 0);
                }

                Item item = new Item(Replacements[i].ID, Replacements[i].Stack, Replacements[i].Prefix);

                // copied from game source to highlight as new item
                if(ItemSlot.Options.HighlightNewItems && item.type >= ItemID.None && !ItemID.Sets.NeverAppearsAsNewInInventory[item.type]) {
                    item.newAndShiny = true;
                }

                if(index >= 0 && index < 50) {
                    player.inventory[index] = item;
                }
                else {
                    player.QuickSpawnItem(player.GetSource_Misc("PlayerDropItemCheck"), item);
                }
            }
        }
    }
}
