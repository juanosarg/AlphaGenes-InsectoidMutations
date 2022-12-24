
using RimWorld;
using System.Reflection;
using Verse;
using HarmonyLib;




namespace AlphaGenesInsectoids
{

    public class AlphaGenesInsectoids : Mod
    {
        public AlphaGenesInsectoids(ModContentPack content) : base(content)
        {
            var harmony = new Harmony("com.alphagenesinsectoids");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }

}
















