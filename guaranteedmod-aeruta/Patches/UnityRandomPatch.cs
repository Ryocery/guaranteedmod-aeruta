using HarmonyLib;
using Il2CppSystem.Diagnostics;
using Il2CppSystem.Reflection;

namespace guaranteedmod_aeruta.Patches;

[HarmonyPatch(typeof(UnityEngine.Random), nameof(UnityEngine.Random.Range), typeof(float), typeof(float))]
public class UnityRandomPatch {
    static void Prefix(ref float maxInclusive) {
        StackTrace stackTrace = new();
        for (int i = 0; i < stackTrace.FrameCount; i++) {
            MethodBase? method = stackTrace.GetFrame(i).GetMethod();
            if (method?.DeclaringType?.Name != "UI_WeaponModify" || method.Name != "RunUpgrade") continue; // Still can't manage to get it to display on UI, and couldn't be bothered, it works.
            maxInclusive = 0.001f;
            break;
        }
    }
}