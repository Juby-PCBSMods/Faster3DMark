using BepInEx;
using HarmonyLib;

namespace Faster3DMark {
    [BepInPlugin("io.github.juby210.pcbsmods.faster3dmark", "Faster3DMark", "1.0.0")]
    public class Faster3DMark : BaseUnityPlugin {
        public void Awake() {
            Harmony.CreateAndPatchAll(typeof(Patch));
            Logger.LogInfo("Faster3DMark Loaded");
        }
    }
}
