using HarmonyLib;

namespace abundance_aeruta.Patches;

[HarmonyPatch(typeof(UI_WeaponModify), nameof(UI_WeaponModify.GetEnhanceSuccessRate))]
public class UI_WeaponModifyPatch {
    static float Prefix(WeaponModifyPart part) {
        return GuaranteedModification.ModificationChance.Value;
    }
}