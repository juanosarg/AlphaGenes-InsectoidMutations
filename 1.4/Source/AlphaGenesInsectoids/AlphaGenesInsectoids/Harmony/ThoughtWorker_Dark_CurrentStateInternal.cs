using HarmonyLib;
using RimWorld;
using Verse;

namespace AlphaGenesInsectoids
{
    [HarmonyPatch(typeof(ThoughtWorker_Dark), "CurrentStateInternal", MethodType.Normal)]
    internal class AlphaGenesInsectoids_ThoughtWorker_Dark_CurrentStateInternal_Postfix
    {
        [HarmonyPostfix]
        private static void PostFix(Pawn p, ref ThoughtState __result)
        {
            if (p.Awake() && p.needs?.mood?.recentMemory?.TicksSinceLastLight > 240 && p.health?.hediffSet?.HasHediff(InternalDefOf.AG_VFEI_Antenna)==true)
            {
                __result = ThoughtState.Inactive;
            }
        }
    }
}