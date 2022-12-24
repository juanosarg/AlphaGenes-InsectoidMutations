
using RimWorld;
using Verse;


namespace AlphaGenesInsectoids
{
	[DefOf]
	public static class InternalDefOf
	{
		public static HediffDef AG_VFEI_Antenna;
		public static HediffDef AG_VFEI_VenomGland;
		public static HediffDef AG_VFEI_PredatorStomach;

		static InternalDefOf()
		{
			DefOfHelper.EnsureInitializedInCtor(typeof(InternalDefOf));
		}
	}
}
