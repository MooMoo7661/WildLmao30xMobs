using System;
using Terraria;
using Terraria.ModLoader;

namespace WildLmao30xMobs
{
	public class GlobalNPCRateModifier : GlobalNPC
	{
        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        {
            spawnRate = 20;
            maxSpawns = 500;
        }
    }
}