using HarmonyLib;

namespace Faster3DMark {
    [HarmonyPatch(typeof(SaveLoadSystem), nameof(SaveLoadSystem.LoadGame))]
    public class Patch {
        // ReSharper disable once UnusedMember.Global
        public static void Prefix() {
            ProgramConstants.s_max3DMarkTestDuration = 3;
        }
    }
}
