using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace guaranteedmod_aeruta;

[BepInPlugin(Guid, Name, Version)]
public class GuaranteedModification : BasePlugin {
    private const string Guid = "com.ryocery.guaranteedmod_aeruta";
    private const string Name = "Guaranteed Modification";
    private const string Version = "1.0.0";
    
    private new static ManualLogSource Log { get; set; } = null!;
    private static Harmony _harmony = null!;

    public override void Load() {
        Log = base.Log;
        _harmony = new Harmony(Guid);
        _harmony.PatchAll();
        Log.LogInfo($"Plugin {Guid} is loaded!");
    }
}

