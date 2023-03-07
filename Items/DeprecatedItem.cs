using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

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
        }

        protected abstract ReplacementItem[] Replacements { get; }

        public sealed override void UpdateInventory(Player player) {
            Replace(player, player.inventory);
        }

        public sealed override void UpdateAccessory(Player player, bool hideVisual) {
            Replace(player, player.armor);
        }

        public sealed override void AddRecipes() { }

        protected void Replace(Player player, Item[] inventory) {
            string originalName = Item.Name;
            List<string> replacementNames = new List<string>();
            int droppedItems = 0;

            if(Replacements == null || Replacements.Length == 0) {
                Item.maxStack = 0;
                Item.TurnToAir();
                return;
            }

            for(int i = 0; i < Replacements.Length; i++) {
                int index = -1;

                if(i == 0) {
                    index = Array.IndexOf(inventory, Item);
                }
                else {
                    index = Array.FindIndex(inventory, i => i.stack == 0);
                }

                if(index >= 0 && index < 50) {
                    inventory[index] = new Item(Replacements[i].ID, Replacements[i].Stack, Replacements[i].Prefix);
                    replacementNames.Add(inventory[index].Name);
                }
                else {
                    Item item = new Item(Replacements[i].ID, Replacements[i].Stack, Replacements[i].Prefix);
                    player.QuickSpawnItem(player.GetSource_Misc("PlayerDropItemCheck"), item);
                    replacementNames.Add(item.Name);
                    droppedItems++;
                }
            }

            Main.NewText($"{originalName} has been removed from Quality of Life: Recipes. " +
                         $"Given {string.Join(", ", replacementNames)}. " +
                         $"{droppedItems} item(s) have been dropped.",
                         Color.Red);
        }
    }
}
