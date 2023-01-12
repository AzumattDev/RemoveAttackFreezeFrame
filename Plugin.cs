using System.IO;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace RemoveAttackFreezeFrame
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class RemoveAttackFreezeFramePlugin : BaseUnityPlugin
    {
        internal const string ModName = "RemoveAttackFreezeFrame";
        internal const string ModVersion = "1.0.0";
        internal const string Author = "Azumatt";
        private const string ModGUID = Author + "." + ModName;
        private readonly Harmony _harmony = new(ModGUID);

        public static readonly ManualLogSource RemoveAttackFreezeFrameLogger =
            BepInEx.Logging.Logger.CreateLogSource(ModName);

        public void Awake()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            _harmony.PatchAll(assembly);
        }
    }
}