﻿using Terraria.ID;

namespace QualityOfLifeRecipes.Tiles.Banners {
    public class UndeadBanner : BannerTile<Items.Placeable.Banners.UndeadBanner, UndeadBanner> {
        protected override int[] NPCs => new int[] {
            // zombie
            NPCID.Zombie,
            NPCID.ArmedZombie,
            NPCID.BaldZombie,
            NPCID.PincushionZombie,
            NPCID.ArmedZombiePincussion,
            NPCID.SlimedZombie,
            NPCID.ArmedZombieSlimed,
            NPCID.SwampZombie,
            NPCID.ArmedZombieSwamp,
            NPCID.TwiggyZombie,
            NPCID.ArmedZombieTwiggy,
            NPCID.FemaleZombie,
            NPCID.ArmedZombieCenx,
            NPCID.ZombieRaincoat,
            // demon eye
            NPCID.DemonEye,
            NPCID.CataractEye,
            NPCID.DialatedEye,
            NPCID.GreenEye,
            NPCID.SleepyEye,
            NPCID.PurpleEye,
            NPCID.DemonEyeOwl,
            NPCID.DemonEyeSpaceship
        };
    }
}
