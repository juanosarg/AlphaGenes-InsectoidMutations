﻿using System.Collections.Generic;
using HarmonyLib;
using RimWorld;
using Verse;

namespace AlphaGenesInsectoids
{
    [HarmonyPatch(typeof(FoodUtility), "ThoughtsFromIngesting", MethodType.Normal)]
    internal class AlphaGenesInsectoids_FoodUtility_ThoughtsFromIngesting_Postfix
    {
        [HarmonyPostfix]
        private static void PostFix(Pawn ingester, ref List<FoodUtility.ThoughtFromIngesting> __result)
        {
            if (ingester.health?.hediffSet?.HasHediff(InternalDefOf.AG_VFEI_VenomGland)==true)
            {
                __result.Clear();
            }
        }
    }
}